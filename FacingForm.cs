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
    public partial class FacingForm : TransForm
    {
        public FacingForm()
        {
            InitializeComponent();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            float v; int i;
            //Проверка правильности введёных данных
            bool valid = float.TryParse(tBoxD.Text.ToString(), out v)
                && float.TryParse(tBoxL.Text.ToString(), out v)
                && float.TryParse(tBoxDpiece.Text.ToString(), out v)
                && float.TryParse(tBoxLpiece.Text.ToString(), out v)
                && float.TryParse(tBoxh.Text.ToString(), out v)
                && float.TryParse(tBoxR.Text.ToString(), out v)
                && float.TryParse(tBoxU.Text.ToString(), out v)
                && float.TryParse(tBoxW.Text.ToString(), out v)
                && float.TryParse(tBoxF.Text.ToString(), out v)
                && float.TryParse(tBoxS.Text.ToString(), out v)
                && float.TryParse(tBoxB.Text.ToString(), out v)
                && float.TryParse(tBoxX.Text.ToString(), out v)
                && float.TryParse(tBoxZ.Text.ToString(), out v)
                && int.TryParse(tBoxToolNumber.Text.ToString(), out i)
                && int.TryParse(tBoxToolDepartureNumber.Text.ToString(), out i);
            if (!valid) return; //выйти из процедуры, если данные введены не корректно

            //Перенос данных в модель, если они правильные
            int index = lBoxTransitions.SelectedIndex;
            if (!editTransition)
            {
                transitions.Add(new Transition());
                index = transitions.Count() - 1;
                transitions[index].Init(TransitionType.Facing);
            }
            if (index < 0) return;
            transitions[index].facing.D = (float)Convert.ToDouble(tBoxD.Text);
            transitions[index].facing.L = (float)Convert.ToDouble(tBoxL.Text);
            transitions[index].facing.Dpiece = (float)Convert.ToDouble(tBoxDpiece.Text);
            transitions[index].facing.Lpiece = (float)Convert.ToDouble(tBoxLpiece.Text);
            transitions[index].facing.h = (float)Convert.ToDouble(tBoxh.Text);
            transitions[index].facing.R = (float)Convert.ToDouble(tBoxR.Text);
            transitions[index].facing.U = (float)Convert.ToDouble(tBoxU.Text);
            transitions[index].facing.W = (float)Convert.ToDouble(tBoxW.Text);
            transitions[index].facing.F = (float)Convert.ToDouble(tBoxF.Text);
            transitions[index].facing.S = (float)Convert.ToDouble(tBoxS.Text);
            transitions[index].facing.B = (float)Convert.ToDouble(tBoxB.Text);
            transitions[index].facing.X = (float)Convert.ToDouble(tBoxX.Text);
            transitions[index].facing.Z = (float)Convert.ToDouble(tBoxZ.Text);
            transitions[index].facing.MachinePause = checkBoxPause.Checked;
            transitions[index].facing.ToolNumber = (int)Convert.ToDouble(tBoxToolNumber.Text);
            transitions[index].facing.ToolDepartureNumber = (int)Convert.ToDouble(tBoxToolDepartureNumber.Text);
            transitions[index].description = String.Format("Торцевать, выдерживая L={0:f3} предварительно",
                transitions[index].facing.L);

            this.Hide();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if (!editTransition)
            {
                TransitionTypeForm1 = new TransitionTypeForm();
                TransitionTypeForm1.StartPosition = FormStartPosition.Manual;
                TransitionTypeForm1.Left = this.Left;
                TransitionTypeForm1.Top = this.Top;
                TransitionTypeForm1.Show();
            }
            this.Hide();
        }

        private void FacingForm_Load(object sender, EventArgs e)
        {
            int index = lBoxTransitions.SelectedIndex;
            if (editTransition && index > -1)
            {
                btBack.Text = "Отмена";
                tBoxD.Text = transitions[index].facing.D.ToString();
                tBoxL.Text = transitions[index].facing.L.ToString();
                tBoxDpiece.Text = transitions[index].facing.Dpiece.ToString();
                tBoxLpiece.Text = transitions[index].facing.Lpiece.ToString();
                tBoxh.Text = transitions[index].facing.h.ToString();
                tBoxR.Text = transitions[index].facing.R.ToString();
                tBoxU.Text = transitions[index].facing.U.ToString();
                tBoxW.Text = transitions[index].facing.W.ToString();
                tBoxF.Text = transitions[index].facing.F.ToString();
                tBoxS.Text = transitions[index].facing.S.ToString();
                tBoxB.Text = transitions[index].facing.B.ToString();
                tBoxX.Text = transitions[index].facing.X.ToString();
                tBoxZ.Text = transitions[index].facing.Z.ToString();
                checkBoxPause.Checked = transitions[index].facing.MachinePause;
                tBoxToolNumber.Text = transitions[index].facing.ToolNumber.ToString();
                tBoxToolDepartureNumber.Text = transitions[index].facing.ToolDepartureNumber.ToString();
            }
        }
    }
}
