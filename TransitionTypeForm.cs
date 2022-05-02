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
            ShowForm(new InstallPieceForm(), this);
            this.Hide();
        }

        private void btShoulderTurning_Click(object sender, EventArgs e)
        {
            ShowForm(new ShoulderTurningForm(), this);
            this.Hide();
        }

        private void btUninstall_Click(object sender, EventArgs e)
        {
            ShowForm(new UninstallPieceForm(), this);
            this.Hide();
        }

        private void btFacing_Click(object sender, EventArgs e)
        {
            ShowForm(new FacingForm(), this);
            this.Hide();
        }
    }
}
