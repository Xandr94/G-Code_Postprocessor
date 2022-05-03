namespace G_Code_Postprocessor
{

    public partial class MainForm : Form
    {
        public static TransitionTypeForm TransitionTypeForm1 = new TransitionTypeForm();
        public static InstallPieceForm InstallPieceForm1 = new InstallPieceForm();
        public static UninstallPieceForm UninstallPieceForm1 = new UninstallPieceForm();
        public static ShoulderTurningForm ShoulderTurningForm1 = new ShoulderTurningForm();
        public static FacingForm FacingForm1 = new FacingForm();

        public static CirclePiece circlePiece = new CirclePiece();
        public static List<Transition> transitions = new List<Transition>();

        public static bool editTransition = false;

        public MainForm()
        {
            InitializeComponent();
            //чтобы была точка вместо запятой в выводе:
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        public void UpdateButtons()
        {
            if (lBoxTransitions.SelectedIndex < 0)
            {
                btRemoveTransition.Enabled = false;
                btEdit.Enabled = false;
            }
            else
            {
                btRemoveTransition.Enabled = true;
                btEdit.Enabled = true;
            }
            if (transitions.Count == 0) btClear.Enabled = false;
            else btClear.Enabled = true;
        }
        public void UpdateTransitions()
        {
            lBoxTransitions.Items.Clear();
            tBoxGcode.Text = "";
            int cnt = 0;
            for (int i = 0; i < transitions.Count; i++)
            {
                lBoxTransitions.Items.Add((i + 1) + ". " + transitions[i].description);
                cnt += (i == 0) ? 0 : transitions[i - 1].gcode.frames.Count;
                transitions[i].GenerateGcode(cnt);
                tBoxGcode.Text += transitions[i].gcode.GetGcode();
            }
            UpdateButtons();
        }

        public static void ShowForm(TransForm form, TransForm mainform)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Left = mainform.Left;
            form.Top = mainform.Top;
            form.lBoxTransitions = mainform.lBoxTransitions;
            form.Show();
        }
        public static void ShowForm(TransForm form, Form mainform, ListBox listBox)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Left = mainform.Left;
            form.Top = mainform.Top;
            form.lBoxTransitions = listBox;
            form.Show();
        }

        public void EditTransition(int index)
        {
            editTransition = true;
            switch (transitions[index].transitionType)
            {
                case TransitionType.Install:
                    ShowForm(new InstallPieceForm(), this, lBoxTransitions);
                    break;
                case TransitionType.Uninstall:
                    ShowForm(new UninstallPieceForm(), this, lBoxTransitions);
                    break;
                case TransitionType.ShoulderTurning:
                    ShowForm(new ShoulderTurningForm(), this, lBoxTransitions);
                    break;
                case TransitionType.Facing:
                    ShowForm(new FacingForm(), this, lBoxTransitions);
                    break;
                default:
                    break;
            }
        }

        public void RemoveTranzition()
        {
            int index = lBoxTransitions.SelectedIndex;
            if (index != -1)
            {
                transitions.RemoveAt(index);
                UpdateTransitions();
                if (lBoxTransitions.Items.Count == 0)
                    btRemoveTransition.Enabled = false;
                else
                {
                    if (lBoxTransitions.Items.Count - 1 < index)
                        index--;
                    lBoxTransitions.SelectedIndex = index;
                }
            }
            UpdateButtons();
        }

        private void btAddTransition_Click(object sender, EventArgs e)
        {
            editTransition = false;
            TransitionTypeForm1 = new TransitionTypeForm();
            TransitionTypeForm1.StartPosition = FormStartPosition.Manual;
            TransitionTypeForm1.Left = this.Left;
            TransitionTypeForm1.Top = this.Top;
            TransitionTypeForm1.lBoxTransitions = this.lBoxTransitions;
            TransitionTypeForm1.Show();
        }

        private void btSaveGcode_Click(object sender, EventArgs e)
        {
            UpdateTransitions();
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                tBoxGcode.SaveFile(saveFile1.FileName, System.Windows.Forms.RichTextBoxStreamType.PlainText);
            }
        }

        private void btGenerateGcode_Click(object sender, EventArgs e)
        {
            UpdateTransitions();
            Clipboard.Clear();
            string text = " ";
            for (int i = 0; i < tBoxGcode.Lines.Length; i++)
                text += tBoxGcode.Lines[i] + Environment.NewLine;
            Clipboard.SetText(text);
        }

        private void lBoxTransitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void btRemoveTransition_Click(object sender, EventArgs e)
        {
            RemoveTranzition();
        }

        private void btUpdateTransitions_Click(object sender, EventArgs e)
        {
            UpdateTransitions();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            UpdateTransitions();
        }

        //Начало функций для переноса слов в листбоксе
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(lBoxTransitions.Items[e.Index].ToString(), lBoxTransitions.Font, lBoxTransitions.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lBoxTransitions.Items.Count > 0 && e.Index >= 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(lBoxTransitions.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        //Окончание функций для переноса слов в листбоксе

        private void MainForm_Load(object sender, EventArgs e)
        {
            pbSafetyScreen.Visible = true;
            pbSafetyScreen.Location = new Point(0,0);
            pbSafetyScreen.Width = this.Width;
            pbSafetyScreen.Height = this.Height-45;
            btOk.Left -= 10;
            btOk.Top -= 10;

            comboBox1.SelectedIndex = 0;
        }

        private void lBoxTransitions_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    RemoveTranzition();
                break;
                default:

                break;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            transitions.Clear();
            UpdateTransitions();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int index = lBoxTransitions.SelectedIndex;
            if (transitions.Count > 0 && index > -1) EditTransition(index);
        }

        private void lBoxTransitions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lBoxTransitions.SelectedIndex;
            if (transitions.Count > 0 && index > -1) EditTransition(index);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            pbSafetyScreen.Visible = false;
            btOk.Visible = false;
        }
    }

    public class TransForm : Form
    {
        public ListBox lBoxTransitions = new();

    }
}