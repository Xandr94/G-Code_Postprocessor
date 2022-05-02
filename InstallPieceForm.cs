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
    public partial class InstallPieceForm : TransForm
    {

        public InstallPieceForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
        
        private void btApply_Click(object sender, EventArgs e)
        {
            float v;
            //Проверка правильность введёных данных
            bool valid = float.TryParse(tBoxDiameter.Text.ToString(), out v)
                && float.TryParse(tBoxLength.Text.ToString(), out v);
            if (!valid) return; //выйти из процедуры, если данные введены не корректно

            //Перенос данных в модель, если они правильные
            int index = lBoxTransitions.SelectedIndex;
            if (!editTransition)
            {
                transitions.Add(new Transition());
                index = transitions.Count() - 1;
                transitions[index].Init(TransitionType.Install);
            }
            if (index < 0) return;
            
            transitions[index].install.D = (float)Convert.ToDouble(tBoxDiameter.Text);
            transitions[index].install.L = (float)Convert.ToDouble(tBoxLength.Text);
            transitions[index].description = String.Format("Установить заготовку D={0:f3}, L={1:f3}",
                transitions[index].install.D, transitions[index].install.L);
            
            this.Hide();
        }

        private void InstallPieceForm_Load(object sender, EventArgs e)
        {
            int index = lBoxTransitions.SelectedIndex;
            if (editTransition && index > -1)
            {
                button2.Text = "Отмена";
                tBoxDiameter.Text = transitions[index].install.D.ToString();
                tBoxLength.Text = transitions[index].install.L.ToString();
            }
        }
    }
}
