﻿using System;
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
    public partial class UninstallPieceForm : Form
    {
        public ListBox lBoxTransitions;
        public UninstallPieceForm()
        {
            InitializeComponent();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            float v; bool b;
            //Проверка правильность введёных данных
            bool valid = float.TryParse(tBoxDiameter.Text.ToString(), out v)
                && float.TryParse(tBoxLength.Text.ToString(), out v)
                && float.TryParse(tBoxX.Text.ToString(), out v)
                && float.TryParse(tBoxZ.Text.ToString(), out v);
            if (!valid) return; //выйти из процедуры, если данные введены не корректно

            //Перенос данных в модель, если они правильные
            transitions.Add(new Transition());

            int index = transitions.Count() - 1;
            transitions[index].Init(TransitionType.Uninstall);
            transitions[index].uninstall.D = (float)Convert.ToDouble(tBoxDiameter.Text);
            transitions[index].uninstall.L = (float)Convert.ToDouble(tBoxLength.Text);
            transitions[index].uninstall.X = (float)Convert.ToDouble(tBoxX.Text);
            transitions[index].uninstall.Z = (float)Convert.ToDouble(tBoxZ.Text);
            transitions[index].uninstall.Stop = checkBoxStop.Checked;
            transitions[index].uninstall.End = checkBoxEndPopg.Checked;
            transitions[index].description = String.Format("Снять заготовку");

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
