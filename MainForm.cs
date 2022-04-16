namespace G_Code_Postprocessor
{
    public partial class MainForm : Form
    {
        public static TransitionTypeForm TransitionTypeForm1 = new TransitionTypeForm();
        public static InstallPieceForm InstallPieceForm1 = new InstallPieceForm();

        public static CirclePiece circlePiece = new CirclePiece();
        public static Tool tool = new Tool();
        public static List<Transition> transitions = new List<Transition>();

        public static bool editTransition = false;

        public MainForm()
        {
            InitializeComponent();
            //чтобы была точка вместо запятой в выводе:
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void btAddTransition_Click(object sender, EventArgs e)
        {
            transitions.Add(new Transition().Init(Transition.TransitionType.Install,"Установ"));

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
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(tBoxGcode.Text);
                    sw.Close();
                }
            }
        }

        private void btGenerateGcode_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < transitions.Count; i++)
            {
                tBoxGcode.Text = transitions[i].gcode.GetGcode();
            }
        }
    }
}