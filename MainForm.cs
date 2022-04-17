namespace G_Code_Postprocessor
{
    public partial class MainForm : Form
    {
        public static TransitionTypeForm TransitionTypeForm1 = new TransitionTypeForm();
        public static InstallPieceForm InstallPieceForm1 = new InstallPieceForm();
        public static UninstallPieceForm UninstallPieceForm1 = new UninstallPieceForm();
        public static ShoulderTurningForm ShoulderTurningForm1 = new ShoulderTurningForm();

        public static CirclePiece circlePiece = new CirclePiece();
        public static List<Transition> transitions = new List<Transition>();

        public static bool editTransition = false;

        public MainForm()
        {
            InitializeComponent();
            //чтобы была точка вместо запятой в выводе:
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        public void UpdateTransitions()
        {
            lBoxTransitions.Items.Clear();
            tBoxGcode.Text = "";
            for (int i = 0; i < transitions.Count; i++)
            {
                lBoxTransitions.Items.Add((i + 1) + ". " + transitions[i].description);
                transitions[i].GenerateGcode((i == 0) ? 0 : transitions[i - 1].gcode.frames.Count);
                tBoxGcode.Text += transitions[i].gcode.GetGcode();
            }
        }

        private void btAddTransition_Click(object sender, EventArgs e)
        {
            TransitionTypeForm1 = new TransitionTypeForm();
            TransitionTypeForm1.StartPosition = FormStartPosition.Manual;
            TransitionTypeForm1.Left = this.Left;
            TransitionTypeForm1.Top = this.Top;
            TransitionTypeForm1.lBoxTransitions = this.lBoxTransitions;
            TransitionTypeForm1.Show();
        }

        private void btSaveGcode_Click(object sender, EventArgs e)
        {
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
            tBoxGcode.Text = "";
            for (int i = 0; i < transitions.Count; i++)
            {
                transitions[i].GenerateGcode((i == 0) ? 0 : transitions[i - 1].gcode.frames.Count);
                tBoxGcode.Text += transitions[i].gcode.GetGcode();
            }
        }

        private void lBoxTransitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxTransitions.SelectedIndex == -1)
                btRemoveTransition.Enabled = false;
            else
                btRemoveTransition.Enabled = true;
        }

        private void btRemoveTransition_Click(object sender, EventArgs e)
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
        }

        private void btUpdateTransitions_Click(object sender, EventArgs e)
        {
            UpdateTransitions();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            UpdateTransitions();
        }

        //Для переноса слов в листбоксе
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(lBoxTransitions.Items[e.Index].ToString(), lBoxTransitions.Font, lBoxTransitions.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lBoxTransitions.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(lBoxTransitions.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}