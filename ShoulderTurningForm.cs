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
    public partial class ShoulderTurningForm : Form
    {
        public ListBox lBoxTransitions;
        public ShoulderTurningForm()
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
                && float.TryParse(tBoxh.Text.ToString(), out v)
                && float.TryParse(tBoxR.Text.ToString(), out v)
                && float.TryParse(tBoxU.Text.ToString(), out v)
                && float.TryParse(tBoxF.Text.ToString(), out v)
                && float.TryParse(tBoxS.Text.ToString(), out v)
                && float.TryParse(tBoxB.Text.ToString(), out v)
                && float.TryParse(tBoxX.Text.ToString(), out v)
                && float.TryParse(tBoxZ.Text.ToString(), out v)
                && int.TryParse(tBoxToolNumber.Text.ToString(), out i)
                && int.TryParse(tBoxToolDepartureNumber.Text.ToString(), out i);
            if (!valid) return; //выйти из процедуры, если данные введены не корректно

            //Перенос данных в модель, если они правильные
            transitions.Add(new Transition());
            int index = transitions.Count() - 1;
            transitions[index].Init(TransitionType.ShoulderTurning);
            transitions[index].shoulderTurning.D = (float)Convert.ToDouble(tBoxD.Text);
            transitions[index].shoulderTurning.L = (float)Convert.ToDouble(tBoxL.Text);
            transitions[index].shoulderTurning.Dpiece = (float)Convert.ToDouble(tBoxDpiece.Text);
            transitions[index].shoulderTurning.h = (float)Convert.ToDouble(tBoxh.Text);
            transitions[index].shoulderTurning.R = (float)Convert.ToDouble(tBoxR.Text);
            transitions[index].shoulderTurning.U = (float)Convert.ToDouble(tBoxU.Text);
            transitions[index].shoulderTurning.F = (float)Convert.ToDouble(tBoxF.Text);
            transitions[index].shoulderTurning.S = (float)Convert.ToDouble(tBoxS.Text);
            transitions[index].shoulderTurning.B = (float)Convert.ToDouble(tBoxB.Text);
            transitions[index].shoulderTurning.X = (float)Convert.ToDouble(tBoxX.Text);
            transitions[index].shoulderTurning.Z = (float)Convert.ToDouble(tBoxZ.Text);
            transitions[index].shoulderTurning.MachinePause = checkBoxPause.Checked;
            transitions[index].shoulderTurning.ToolNumber = (int)Convert.ToDouble(tBoxToolNumber.Text);
            transitions[index].shoulderTurning.ToolDepartureNumber = (int)Convert.ToDouble(tBoxToolDepartureNumber.Text);
            transitions[index].description = String.Format("Точить цилиндр, выдерживая D={0:f3} на L={1:f3} предварительно",
                transitions[index].shoulderTurning.D,
                transitions[index].shoulderTurning.L);

            this.Hide();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            TransitionTypeForm1 = new TransitionTypeForm();
            TransitionTypeForm1.StartPosition = FormStartPosition.Manual;
            TransitionTypeForm1.Left = this.Left;
            TransitionTypeForm1.Top = this.Top;
            TransitionTypeForm1.Show();
            this.Hide();
        }
    }
}
