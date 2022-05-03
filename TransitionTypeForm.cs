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
    public partial class TransitionTypeForm : TransForm
    {

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

        private void btShoulderTurning_Click(object sender, EventArgs e)
        {
            ShoulderTurningForm1 = new ShoulderTurningForm();
            ShoulderTurningForm1.StartPosition = FormStartPosition.Manual;
            ShoulderTurningForm1.Left = this.Left;
            ShoulderTurningForm1.Top = this.Top;
            ShoulderTurningForm1.lBoxTransitions = this.lBoxTransitions;
            ShoulderTurningForm1.Show();
            this.Hide();
        }

        private void btUninstall_Click(object sender, EventArgs e)
        {
            UninstallPieceForm1 = new UninstallPieceForm();
            UninstallPieceForm1.StartPosition = FormStartPosition.Manual;
            UninstallPieceForm1.Left = this.Left;
            UninstallPieceForm1.Top = this.Top;
            UninstallPieceForm1.lBoxTransitions = this.lBoxTransitions;
            UninstallPieceForm1.Show();
            this.Hide();
        }

        private void btFacing_Click(object sender, EventArgs e)
        {
            FacingForm1 = new FacingForm();
            FacingForm1.StartPosition = FormStartPosition.Manual;
            FacingForm1.Left = this.Left;
            FacingForm1.Top = this.Top;
            FacingForm1.lBoxTransitions = this.lBoxTransitions;
            FacingForm1.Show();
            this.Hide();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
