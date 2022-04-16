using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static G_Code_Postprocessor.MainForm;

namespace G_Code_Postprocessor
{
    public partial class TransitionTypeForm : Form
    {
        public ListBox lBoxTransitions;

        public TransitionTypeForm()
        {
            InitializeComponent();
        }

        private void btInstallPiece_Click(object sender, EventArgs e)
        {
            InstallPieceForm1 = new InstallPieceForm();
            InstallPieceForm1.StartPosition = FormStartPosition.Manual;
            InstallPieceForm1.Left = this.Left;
            InstallPieceForm1.Top = this.Top;
            InstallPieceForm1.lBoxTransitions = this.lBoxTransitions;
            InstallPieceForm1.Show();
            this.Hide();
        }
    }
}
