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
    public partial class InstallPieceForm : Form
    {
        public ListBox lBoxTransitions;

        public InstallPieceForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransitionTypeForm1 = new TransitionTypeForm();
            TransitionTypeForm1.StartPosition = FormStartPosition.Manual;
            TransitionTypeForm1.Left = this.Left;
            TransitionTypeForm1.Top = this.Top;
            TransitionTypeForm1.Show();
            this.Hide();
        }
        public bool collectData()
        {
            //Проверка правильность введёных данных
            bool valid = float.TryParse(tBoxDiameter.Text.ToString(), out circlePiece.d)
                && float.TryParse(tBoxLength.Text.ToString(), out circlePiece.l)
                && float.TryParse(textBox1.Text.ToString(), out circlePiece.z);
            if (!valid) return false;
            //Перенос данных в модель, если они правильные
            circlePiece.d = (float)Convert.ToDouble(tBoxDiameter.Text);
            circlePiece.l = (float)Convert.ToDouble(tBoxLength.Text);
            circlePiece.z = (float)Convert.ToDouble(textBox1.Text);
            return true;
        }
        private void btApply_Click(object sender, EventArgs e)
        {
            bool valid = collectData(); //Сбор данных с формы
            if (!valid) return; //выйти из процедуры, если данные введены не корректно

            if (!editTransition)
            {
                lBoxTransitions.Items.Add("");
                lBoxTransitions.SelectedIndex = lBoxTransitions.Items.Count - 1;
            }

            int index = lBoxTransitions.SelectedIndex;
            transitions[index].InitInstall(circlePiece);
            transitions[index].text = "Установить заготовку D=" + circlePiece.d + ", L=" + circlePiece.l;

            lBoxTransitions.Items[index] = transitions[index].text;
            this.Hide();
        }
    }
}
