namespace G_Code_Postprocessor
{
    partial class UninstallPieceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btApply = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rBtCircle = new System.Windows.Forms.RadioButton();
            this.tBoxDiameter = new System.Windows.Forms.TextBox();
            this.tBoxLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxEndPopg = new System.Windows.Forms.CheckBox();
            this.checkBoxStop = new System.Windows.Forms.CheckBox();
            this.tBoxZ = new System.Windows.Forms.TextBox();
            this.tBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(222, 319);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(100, 30);
            this.btApply.TabIndex = 0;
            this.btApply.Text = "Применить";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 319);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 30);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tBoxDiameter);
            this.groupBox1.Controls.Add(this.tBoxLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры заготовки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rBtCircle);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сечение";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Прямоугольник";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rBtCircle
            // 
            this.rBtCircle.AutoSize = true;
            this.rBtCircle.Checked = true;
            this.rBtCircle.Location = new System.Drawing.Point(6, 22);
            this.rBtCircle.Name = "rBtCircle";
            this.rBtCircle.Size = new System.Drawing.Size(50, 19);
            this.rBtCircle.TabIndex = 10;
            this.rBtCircle.TabStop = true;
            this.rBtCircle.Text = "Круг";
            this.rBtCircle.UseVisualStyleBackColor = true;
            // 
            // tBoxDiameter
            // 
            this.tBoxDiameter.Location = new System.Drawing.Point(254, 51);
            this.tBoxDiameter.Name = "tBoxDiameter";
            this.tBoxDiameter.Size = new System.Drawing.Size(50, 23);
            this.tBoxDiameter.TabIndex = 3;
            this.tBoxDiameter.Text = "20";
            // 
            // tBoxLength
            // 
            this.tBoxLength.Location = new System.Drawing.Point(254, 22);
            this.tBoxLength.Name = "tBoxLength";
            this.tBoxLength.Size = new System.Drawing.Size(50, 23);
            this.tBoxLength.TabIndex = 2;
            this.tBoxLength.Text = "89";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Диаметр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxEndPopg);
            this.groupBox3.Controls.Add(this.checkBoxStop);
            this.groupBox3.Controls.Add(this.tBoxZ);
            this.groupBox3.Controls.Add(this.tBoxX);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 150);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Положение резца";
            // 
            // checkBoxEndPopg
            // 
            this.checkBoxEndPopg.AutoSize = true;
            this.checkBoxEndPopg.Location = new System.Drawing.Point(156, 119);
            this.checkBoxEndPopg.Name = "checkBoxEndPopg";
            this.checkBoxEndPopg.Size = new System.Drawing.Size(153, 19);
            this.checkBoxEndPopg.TabIndex = 12;
            this.checkBoxEndPopg.Text = "Завершить программу";
            this.checkBoxEndPopg.UseVisualStyleBackColor = true;
            // 
            // checkBoxStop
            // 
            this.checkBoxStop.AutoSize = true;
            this.checkBoxStop.Checked = true;
            this.checkBoxStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStop.Location = new System.Drawing.Point(156, 94);
            this.checkBoxStop.Name = "checkBoxStop";
            this.checkBoxStop.Size = new System.Drawing.Size(150, 19);
            this.checkBoxStop.TabIndex = 11;
            this.checkBoxStop.Text = "Остановить шпиндель";
            this.checkBoxStop.UseVisualStyleBackColor = true;
            // 
            // tBoxZ
            // 
            this.tBoxZ.Location = new System.Drawing.Point(254, 51);
            this.tBoxZ.Name = "tBoxZ";
            this.tBoxZ.Size = new System.Drawing.Size(50, 23);
            this.tBoxZ.TabIndex = 10;
            this.tBoxZ.Text = "20";
            // 
            // tBoxX
            // 
            this.tBoxX.Location = new System.Drawing.Point(254, 22);
            this.tBoxX.Name = "tBoxX";
            this.tBoxX.Size = new System.Drawing.Size(50, 23);
            this.tBoxX.TabIndex = 9;
            this.tBoxX.Text = "56";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Позиция Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Позиция X";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Location = new System.Drawing.Point(6, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 102);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Нуль системы";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(6, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(123, 19);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "На торце патрона";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(6, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "На торце кулачков";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(132, 19);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "На торце заготовки";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // UninstallPieceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btApply);
            this.Name = "UninstallPieceForm";
            this.Text = "Параметры снятия заготовки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btApply;
        private Button btBack;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton rBtCircle;
        private TextBox tBoxDiameter;
        private TextBox tBoxLength;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private CheckBox checkBoxEndPopg;
        private CheckBox checkBoxStop;
        private TextBox tBoxZ;
        private TextBox tBoxX;
        private Label label3;
        private Label label4;
        private GroupBox groupBox4;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
    }
}