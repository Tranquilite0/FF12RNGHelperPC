using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace FF12RNGHelperPC
{
    public partial class FormMain : Form
    {
        private FF12PCMemory MemoryReader = new FF12PCMemory();
        private RNG2002 TrackRNG = new RNG2002();
        private const int DEFAULT_DISPLAY_COUNT = 500;
        private int DisplayCount = DEFAULT_DISPLAY_COUNT;
        private const int DEFAULT_UPDATE_INTERVAL_MS = 120;
        private BindingList<RNGInfo> RowInfo;
        private int CountSinceLostSync = 0;

        private readonly Chest DEFAULT_CHEST = new Chest(50, 1, 50, 50, 100);

        private StealResult DesiredStealNormal = new StealResult(true, false, false);
        private StealFuture DesiredStealNormalFuture;
        private StealResult DesiredStealCuff = new StealResult(true, false, false);
        private StealFuture DesiredStealCuffFuture;

        private Chest Chest1;
        private ChestResult DesiredChest1 = new ChestResult(ChestResultType.Item2);
        private ChestFuture DesiredChestFuture1;
        private Chest Chest2;
        private ChestResult DesiredChest2 = new ChestResult(ChestResultType.Item2);
        private ChestFuture DesiredChestFuture2;

        public FormMain()
        {
            InitializeComponent();
            RowInfo = new BindingList<RNGInfo>();
            dataGridViewDisp.DataSource = RowInfo;

            //Enable double buffering of the DataBridView to improve scrolling performance (if you are not in a remote desktop session)
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                dataGridViewDisp,
                new object[] { true });
            }

            UpdateMemoryReadInterval();
            textBoxDisplayCount.Text = DisplayCount.ToString();
            DesiredStealNormalFuture = new StealFuture(DesiredStealNormal, false, DisplayCount);
            DesiredStealCuffFuture = new StealFuture(DesiredStealCuff, true, DisplayCount);

            Chest1 = DEFAULT_CHEST;
            Chest2 = DEFAULT_CHEST;
            DesiredChestFuture1 = new ChestFuture(DesiredChest1, DEFAULT_CHEST, DisplayCount);
            DesiredChestFuture2 = new ChestFuture(DesiredChest2, DEFAULT_CHEST, DisplayCount);
        }

        private void TimerReadMemory_Tick(object sender, EventArgs e)
        {
            if (MemoryReader.ReadState(out RNGState state))
            {
                int stateDelta = TrackRNG.SyncState(state);
                if (stateDelta >= 0)
                {
                    CountSinceLostSync += stateDelta;
                    toolStripStatusLabelSync.Text = String.Format("{0} : Since last sync", CountSinceLostSync);
                }
                else
                {
                    CountSinceLostSync = 0;
                    toolStripStatusLabelSync.Text = "Lost sync";
                }
                //Update Grid
                UpdateGridView(stateDelta);
                UpdateFutures(stateDelta);

                UpdateCombo();
            }
            else
            {
                toolStripStatusLabelSync.Text = "Waiting to attach to process";
            }
        }

        private void UpdateMemoryReadInterval(int ms = DEFAULT_UPDATE_INTERVAL_MS)
        {
            textBoxRefreshInterval.Text = ms.ToString();
            timerReadMemory.Interval = ms;
        }

        private void UpdateDisplayCount(int count)
        {
            if (count != DisplayCount)
            {
                DisplayCount = count;
                DesiredStealCuffFuture.SearchDepth = DisplayCount;
                DesiredStealNormalFuture.SearchDepth = DisplayCount;
                DesiredChestFuture1.SearchDepth = DisplayCount;
                DesiredChestFuture2.SearchDepth = DisplayCount;

                UpdateGridView();
                UpdateFutures();
            }

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateGridView(int syncCount = -1)
        {
            if(syncCount == 0)
            {
                //We good
                return;
            }
            else if(syncCount > 0)
            {
                //Remove first syncCount Rows, add synccount rows to end.
                RowInfo.RaiseListChangedEvents = false;
                for (int i = 0; i < syncCount; i++)
                {
                    RowInfo.RemoveAt(0);
                    AddRow(DisplayCount - syncCount + i);
                }
                RowInfo.RaiseListChangedEvents = true;
                RowInfo.ResetBindings();
                UpdateColumnVisibility();
            }
            else if(syncCount < 0)
            {
                //Rebuild Grid
                RowInfo.RaiseListChangedEvents = false;
                RowInfo.Clear();
                for(int offset = 0; offset < DisplayCount; offset++)
                {
                    AddRow(offset);
                }
                RowInfo.RaiseListChangedEvents = true;
                RowInfo.ResetBindings();
                UpdateColumnVisibility();
            }
        }

        private void UpdateCombo()
        {
            if(Combo.DoesCombo(TrackRNG))
            {
                labelCombo.Text = "Yes";
            }
            else
            {
                labelCombo.Text = "No";
            }
        }

        private void UpdateChests()
        {
            //Chest 1
            Chest1 = new Chest(
                textBoxSpawnChance1.Text,
                textBoxSpawnPosition1.Text,
                textBoxGilChance1.Text,
                textBoxItemChance1.Text,
                textBoxMaxGil1.Text);

            Chest2 = new Chest(
                textBoxSpawnChance2.Text,
                textBoxSpawnPosition2.Text,
                textBoxGilChance2.Text,
                textBoxItemChance2.Text,
                textBoxMaxGil2.Text);

            DesiredChestFuture1.Chest = Chest1;
            DesiredChestFuture2.Chest = Chest2;

            RowInfo.RaiseListChangedEvents = false;
            for (int i = 0; i < RowInfo.Count; i++)
            {
                var row = RowInfo[i];
                row.Chest1 = Chest1.CheckChest(TrackRNG, i);
                row.Chest2 = Chest2.CheckChest(TrackRNG, i);
                RowInfo[i] = row;
            }
            RowInfo.RaiseListChangedEvents = true;
            RowInfo.ResetBindings();
            UpdateColumnVisibility();
            UpdateChestFutures();
        }

        private void UpdateFutures(int syncCount = -1)
        {
            UpdateStealFutures(syncCount);
            UpdateChestFutures(syncCount);
        }

        private void UpdateStealFutures(int syncCount = -1)
        {
            int NewNormalFuture = -1;
            int NewCuffFuture = -1;
            if (syncCount == 0)
            {
                //We good
                return;
            }
            else if(syncCount > 0)
            {
                NewCuffFuture = DesiredStealCuffFuture.SyncFuture(syncCount, TrackRNG);
                NewNormalFuture = DesiredStealNormalFuture.SyncFuture(syncCount, TrackRNG);
            }
            else if (syncCount < 0)
            {
                NewCuffFuture = DesiredStealCuffFuture.GetFuture(TrackRNG);
                NewNormalFuture = DesiredStealNormalFuture.GetFuture(TrackRNG);
            }

            if(NewNormalFuture < 0)
            {
                labelAdvanceNormal.Text = "Unknown";
            }
            else
            {
                labelAdvanceNormal.Text = NewNormalFuture.ToString();
            }

            if(NewCuffFuture < 0)
            {
                labelAdvanceCuffs.Text = "Unknown";
            }
            else
            {
                labelAdvanceCuffs.Text = NewCuffFuture.ToString();
            }
        }

        private void UpdateChestFutures(int syncCount = -1)
        {
            int NewChest1SpawnFuture = -1;
            int NewChest1ResultFuture = -1;
            int NewChest2SpawnFuture = -1;
            int NewChest2ResultFuture = -1;

            if(syncCount == 0)
            {
                return;
            }
            else if(syncCount > 0)
            {
                NewChest1SpawnFuture = DesiredChestFuture1.GetSpawnFuture(TrackRNG);
                NewChest1ResultFuture = DesiredChestFuture1.SyncFuture(syncCount, TrackRNG);
                NewChest2SpawnFuture = DesiredChestFuture2.GetSpawnFuture(TrackRNG);
                NewChest2ResultFuture = DesiredChestFuture2.SyncFuture(syncCount, TrackRNG);
            }
            else if(syncCount < 0)
            {
                NewChest1SpawnFuture = DesiredChestFuture1.GetSpawnFuture(TrackRNG);
                NewChest1ResultFuture = DesiredChestFuture1.GetFuture(TrackRNG);
                NewChest2SpawnFuture = DesiredChestFuture2.GetSpawnFuture(TrackRNG);
                NewChest2ResultFuture = DesiredChestFuture2.GetFuture(TrackRNG);
            }

            if (NewChest1SpawnFuture < 0)
            {
                labelAdvanceSpawnChest1.Text = "Unknown";
            }
            else
            {
                labelAdvanceSpawnChest1.Text = NewChest1SpawnFuture.ToString();
            }

            if (NewChest1ResultFuture < 0)
            {
                labelAdvanceChestReward1.Text = "Unknown";
            }
            else
            {
                labelAdvanceChestReward1.Text = NewChest1ResultFuture.ToString();
            }

            if (NewChest2SpawnFuture < 0)
            {
                labelAdvanceSpawnChest2.Text = "Unknown";
            }
            else
            {
                labelAdvanceSpawnChest2.Text = NewChest2SpawnFuture.ToString();
            }

            if (NewChest2ResultFuture < 0)
            {
                labelAdvanceChestReward2.Text = "Unknown";
            }
            else
            {
                labelAdvanceChestReward2.Text = NewChest2ResultFuture.ToString();
            }
        }

        private void AddRow(int offset)
        {
            RowInfo.Add(new RNGInfo(TrackRNG, offset, Chest1, Chest2));
        }

        private void FormMain_ResizeBegin(object sender, EventArgs e)
        {
            timerReadMemory.Enabled = false;
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            timerReadMemory.Enabled = true;
        }

        private void DataGridViewDisp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;
            
            if(dgv == null)
            {
                return;
            }

            switch(dgv.Columns[e.ColumnIndex].Name)
            {
                case "ColumnSteal":
                    if(DesiredStealNormal == (StealResult)e.Value)
                    {
                        e.CellStyle.BackColor = Color.LimeGreen;
                    }
                    break;
                case "ColumnStealCuffs":
                    if(((StealResult)e.Value).SameOrBetter(DesiredStealCuff))
                    {
                        e.CellStyle.BackColor = Color.LimeGreen;
                    }
                    break;
                case "ColumnChest1":
                    if(((ChestResult)e.Value).SameOrBetter(DesiredChest1))
                    {
                        e.CellStyle.BackColor = Color.LimeGreen;
                    }
                    break;
                case "ColumnChest2":
                    if (((ChestResult)e.Value).SameOrBetter(DesiredChest2))
                    {
                        e.CellStyle.BackColor = Color.LimeGreen;
                    }
                    break;
            }
        }

        private void TextBoxRefreshInterval_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse((sender as TextBox).Text, out int n) && n > 0)
            {
                UpdateMemoryReadInterval(n);
            }
            else
            {
                (sender as TextBox).Text = timerReadMemory.Interval.ToString();
            }
        }

        private void CheckBoxDisplay_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnVisibility();
        }

        private void UpdateColumnVisibility()
        {
                dataGridViewDisp.Columns["ColumnPercent"].Visible = checkBoxDisplayPercent.Checked;
                dataGridViewDisp.Columns["ColumnSteal"].Visible = checkBoxDisplaySteal.Checked;
                dataGridViewDisp.Columns["ColumnStealCuffs"].Visible = checkBoxDisplayStealCuff.Checked;
                dataGridViewDisp.Columns["ColumnChest1"].Visible = checkBoxDisplayChest1.Checked;
                dataGridViewDisp.Columns["ColumnChest2"].Visible = checkBoxDisplayChest2.Checked;
                dataGridViewDisp.Columns["ColumnRaw"].Visible = checkBoxDisplayRawRNG.Checked;
        }

        private void TextBoxDisplayCount_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse((sender as TextBox).Text, out int n) && n > 0)
            {
                UpdateDisplayCount(n);
            }
            else
            {
                (sender as TextBox).Text = DisplayCount.ToString();
            }
        }

        private void RadioButtonSteal_CheckedChanged(object sender, EventArgs e)
        {
            var RadioButton = sender as RadioButton;
            switch(RadioButton.Text)
            {
                case "Common":
                    DesiredStealNormal = new StealResult(false, false, true);
                    break;
                case "Uncommon":
                    DesiredStealNormal = new StealResult(false, true, false);
                    break;
                case "Rare":
                    DesiredStealNormal = new StealResult(true, false, false);
                    break;
            }
            //Redraw DGV
            dataGridViewDisp.InvalidateColumn(dataGridViewDisp.Columns["ColumnSteal"].Index);
            //Update Future
            DesiredStealNormalFuture.DesiredResult = DesiredStealNormal;
            UpdateStealFutures();
        }

        private void CheckBoxStealCuffs_CheckedChanged(object sender, EventArgs e)
        {
            DesiredStealCuff = new StealResult(
                checkBoxRare.Checked,
                checkBoxUncommon.Checked,
                checkBoxCommon.Checked);

            //Redraw DGV
            dataGridViewDisp.InvalidateColumn(dataGridViewDisp.Columns["ColumnStealCuffs"].Index);
            //Update Future
            DesiredStealCuffFuture.DesiredResult = DesiredStealCuff;
            UpdateStealFutures();
        }

        private bool ValidatePercent(string s, out int n)
        {
            return int.TryParse(s, out n) && (n >= 0 || n <= 100);
        }

        private void TextBoxSpawnChance1_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if(ValidatePercent(tb.Text, out int n) && n != Chest1.SpawnChance)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                (sender as TextBox).Text = Chest1.SpawnChance.ToString();
            }
        }

        private void TextBoxSpawnChance2_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (ValidatePercent(tb.Text, out int n) && n != Chest2.SpawnChance)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                (sender as TextBox).Text = Chest2.SpawnChance.ToString();
            }
        }

        private void TextBoxSpawnPosition1_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (int.TryParse(tb.Text, out int n) && n >= 0 && n != Chest1.SpawnPosition)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                tb.Text = Chest1.SpawnPosition.ToString();
            }
        }

        private void TextBoxSpawnPosition2_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (int.TryParse(tb.Text, out int n) && n >= 0 && n != Chest2.SpawnPosition)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                tb.Text = Chest2.SpawnPosition.ToString();
            }
        }

        private void TextBoxGilChance1_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (ValidatePercent(tb.Text, out int n) && n != Chest1.GilChance)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                (sender as TextBox).Text = Chest1.GilChance.ToString();
            }
        }

        private void TextBoxGilChance2_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (ValidatePercent(tb.Text, out int n) && n != Chest2.GilChance)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                (sender as TextBox).Text = Chest2.GilChance.ToString();
            }
        }

        private void TextBoxItemChance1_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (ValidatePercent(tb.Text, out int n) && n != Chest1.ItemChance)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                (sender as TextBox).Text = Chest1.ItemChance.ToString();
            }
        }

        private void TextBoxItemChance2_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (ValidatePercent(tb.Text, out int n) && n != Chest2.ItemChance)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                (sender as TextBox).Text = Chest2.ItemChance.ToString();
            }
        }

        private void TextBoxMaxGil1_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (int.TryParse(tb.Text, out int n) && n >= 0 && n != Chest1.MaxGilAmount)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                tb.Text = Chest1.MaxGilAmount.ToString();
            }
        }

        private void TextBoxMaxGil2_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (int.TryParse(tb.Text, out int n) && n >= 0 && n != Chest2.MaxGilAmount)
            {
                //Update Chests
                UpdateChests();
            }
            else
            {
                tb.Text = Chest2.MaxGilAmount.ToString();
            }
        }

        private void RadioButtonDR1_CheckedChanged(object sender, EventArgs e)
        {
            var CheckButton = sender as RadioButton;
            if(CheckButton.Checked)
            {
                if(CheckButton == radioButtonDR1Item1)
                {
                    DesiredChest1 = new ChestResult(ChestResultType.Item1);
                }
                else if(CheckButton == radioButtonDR1Item2)
                {
                    DesiredChest1 = new ChestResult(ChestResultType.Item2);
                }
                else if(CheckButton == radioButtonDR1Gil)
                {
                    DesiredChest1 = new ChestResult(ChestResultType.Gil);
                }

                //Redraw DGV
                dataGridViewDisp.InvalidateColumn(dataGridViewDisp.Columns["ColumnChest1"].Index);

                DesiredChestFuture1.DesiredResult = DesiredChest1;
                UpdateChestFutures();
            }
        }
        private void RadioButtonDR2_CheckedChanged(object sender, EventArgs e)
        {
            var CheckButton = sender as RadioButton;
            if (CheckButton.Checked)
            {
                if (CheckButton == radioButtonDR2Item1)
                {
                    DesiredChest2 = new ChestResult(ChestResultType.Item1);
                }
                else if (CheckButton == radioButtonDR2Item2)
                {
                    DesiredChest2 = new ChestResult(ChestResultType.Item2);
                }
                else if (CheckButton == radioButtonDR2Gil)
                {
                    DesiredChest2 = new ChestResult(ChestResultType.Gil);
                }

                //Redraw DGV
                dataGridViewDisp.InvalidateColumn(dataGridViewDisp.Columns["ColumnChest2"].Index);

                DesiredChestFuture2.DesiredResult = DesiredChest2;
                UpdateChestFutures();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "FF12 RNG Helper PC\nVersion 1.0\nA program for manipulating random events in the PC version of Final Fantasy XII.";
            MessageBox.Show(message, "About this program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    //TODO: Move struct to better location.
    public struct RNGInfo
    {
        [DisplayName("%")]
        public UInt32 Percent
        {
            get
            {
                return RawRNG % 100;
            }
        }

        [DisplayName("Steal")]
        public StealResult StealNormal { get; set; }

        [DisplayName("Steal w/ Cuffs")]
        public StealResult StealWithCuffs { get; set; }

        [DisplayName("Contents 1")]
        public ChestResult Chest1 { get; set; }

        [DisplayName("Contents 2")]
        public ChestResult Chest2 { get; set; }

        [DisplayName("Raw RNG")]
        public UInt32 RawRNG { get; set; }

        public RNGInfo(UInt32 rawRng, StealResult steal, StealResult stealWithCuffs, ChestResult chestResult1, ChestResult chestResult2)
        {
            RawRNG = rawRng;
            StealNormal = steal;
            StealWithCuffs = stealWithCuffs;
            Chest1 = new ChestResult();
            Chest2 = new ChestResult();
        }

        public RNGInfo(IRNG rng, int offset, Chest chestInfo1, Chest chestInfo2)
        {
            UInt32 prng1 = rng.PeekRand(offset);
            UInt32 prng2 = rng.PeekRand(offset + 1);
            UInt32 prng3 = rng.PeekRand(offset + 2);

            this.RawRNG = prng1;
            this.StealNormal = Steal.CheckSteal(prng1, prng2, prng3);
            this.StealWithCuffs = Steal.CheckStealCuffs(prng1, prng2, prng3);

            Chest1 = chestInfo1.CheckChest(prng1, prng2);
            Chest2 = chestInfo2.CheckChest(prng1, prng2);
        }
    }
}
