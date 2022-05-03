namespace G_Code_Postprocessor
{
    partial class FacingForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxPause = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxToolDepartureNumber = new System.Windows.Forms.TextBox();
            this.tBoxToolNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tBoxW = new System.Windows.Forms.TextBox();
            this.tBoxZ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxF = new System.Windows.Forms.TextBox();
            this.tBoxU = new System.Windows.Forms.TextBox();
            this.tBoxR = new System.Windows.Forms.TextBox();
            this.tBoxh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tBoxLpiece = new System.Windows.Forms.TextBox();
            this.tBoxB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBoxDpiece = new System.Windows.Forms.TextBox();
            this.tBoxL = new System.Windows.Forms.TextBox();
            this.tBoxD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::G_Code_Postprocessor.Properties.Resources.Facing;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 408);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 30);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(688, 408);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(100, 30);
            this.btApply.TabIndex = 4;
            this.btApply.Text = "Применить";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxPause);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tBoxToolDepartureNumber);
            this.groupBox3.Controls.Add(this.tBoxToolNumber);
            this.groupBox3.Location = new System.Drawing.Point(342, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 122);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Инструмент";
            // 
            // checkBoxPause
            // 
            this.checkBoxPause.AutoSize = true;
            this.checkBoxPause.Location = new System.Drawing.Point(36, 80);
            this.checkBoxPause.Name = "checkBoxPause";
            this.checkBoxPause.Size = new System.Drawing.Size(152, 34);
            this.checkBoxPause.TabIndex = 6;
            this.checkBoxPause.Text = "Остановить станок для\r\nсмены инстумента";
            this.checkBoxPause.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Номер величины вылета";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Номер инструмента";
            // 
            // tBoxToolDepartureNumber
            // 
            this.tBoxToolDepartureNumber.Location = new System.Drawing.Point(154, 51);
            this.tBoxToolDepartureNumber.Name = "tBoxToolDepartureNumber";
            this.tBoxToolDepartureNumber.Size = new System.Drawing.Size(60, 23);
            this.tBoxToolDepartureNumber.TabIndex = 3;
            this.tBoxToolDepartureNumber.Text = "1";
            // 
            // tBoxToolNumber
            // 
            this.tBoxToolNumber.Location = new System.Drawing.Point(154, 22);
            this.tBoxToolNumber.Name = "tBoxToolNumber";
            this.tBoxToolNumber.Size = new System.Drawing.Size(60, 23);
            this.tBoxToolNumber.TabIndex = 2;
            this.tBoxToolNumber.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tBoxW);
            this.groupBox2.Controls.Add(this.tBoxZ);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tBoxX);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tBoxS);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tBoxF);
            this.groupBox2.Controls.Add(this.tBoxU);
            this.groupBox2.Controls.Add(this.tBoxR);
            this.groupBox2.Controls.Add(this.tBoxh);
            this.groupBox2.Location = new System.Drawing.Point(568, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 320);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры резания";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 30);
            this.label15.TabIndex = 16;
            this.label15.Text = "Припуск на чистовую\r\nобработку по Z (W)";
            // 
            // tBoxW
            // 
            this.tBoxW.Location = new System.Drawing.Point(154, 130);
            this.tBoxW.Name = "tBoxW";
            this.tBoxW.Size = new System.Drawing.Size(60, 23);
            this.tBoxW.TabIndex = 15;
            this.tBoxW.Text = "0.0";
            // 
            // tBoxZ
            // 
            this.tBoxZ.Location = new System.Drawing.Point(154, 280);
            this.tBoxZ.Name = "tBoxZ";
            this.tBoxZ.Size = new System.Drawing.Size(60, 23);
            this.tBoxZ.TabIndex = 14;
            this.tBoxZ.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 30);
            this.label12.TabIndex = 13;
            this.label12.Text = "Подвод инструмента\r\nк заготовке (Z)";
            // 
            // tBoxX
            // 
            this.tBoxX.Location = new System.Drawing.Point(154, 241);
            this.tBoxX.Name = "tBoxX";
            this.tBoxX.Size = new System.Drawing.Size(60, 23);
            this.tBoxX.TabIndex = 12;
            this.tBoxX.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 30);
            this.label11.TabIndex = 11;
            this.label11.Text = "Высота инструмента\r\nнад заготовкой (X)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 30);
            this.label10.TabIndex = 10;
            this.label10.Text = "Скорость вращения\r\nшпинделя (S)";
            // 
            // tBoxS
            // 
            this.tBoxS.Location = new System.Drawing.Point(154, 203);
            this.tBoxS.Name = "tBoxS";
            this.tBoxS.Size = new System.Drawing.Size(60, 23);
            this.tBoxS.TabIndex = 9;
            this.tBoxS.Text = "1500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Скорость подачи (F)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Величина возврата (R)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Глубина резания (h)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Припуск на чистовую\r\nобработку по X (U)";
            // 
            // tBoxF
            // 
            this.tBoxF.Location = new System.Drawing.Point(154, 164);
            this.tBoxF.Name = "tBoxF";
            this.tBoxF.Size = new System.Drawing.Size(60, 23);
            this.tBoxF.TabIndex = 4;
            this.tBoxF.Text = "200";
            // 
            // tBoxU
            // 
            this.tBoxU.Location = new System.Drawing.Point(154, 90);
            this.tBoxU.Name = "tBoxU";
            this.tBoxU.Size = new System.Drawing.Size(60, 23);
            this.tBoxU.TabIndex = 3;
            this.tBoxU.Text = "0.0";
            // 
            // tBoxR
            // 
            this.tBoxR.Location = new System.Drawing.Point(154, 51);
            this.tBoxR.Name = "tBoxR";
            this.tBoxR.Size = new System.Drawing.Size(60, 23);
            this.tBoxR.TabIndex = 2;
            this.tBoxR.Text = "0.2";
            // 
            // tBoxh
            // 
            this.tBoxh.Location = new System.Drawing.Point(154, 22);
            this.tBoxh.Name = "tBoxh";
            this.tBoxh.Size = new System.Drawing.Size(60, 23);
            this.tBoxh.TabIndex = 1;
            this.tBoxh.Text = "0.3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tBoxLpiece);
            this.groupBox1.Controls.Add(this.tBoxB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tBoxDpiece);
            this.groupBox1.Controls.Add(this.tBoxL);
            this.groupBox1.Controls.Add(this.tBoxD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(342, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Длина заготовки (Lзаг)";
            // 
            // tBoxLpiece
            // 
            this.tBoxLpiece.Location = new System.Drawing.Point(154, 109);
            this.tBoxLpiece.Name = "tBoxLpiece";
            this.tBoxLpiece.Size = new System.Drawing.Size(60, 23);
            this.tBoxLpiece.TabIndex = 10;
            this.tBoxLpiece.Text = "90";
            // 
            // tBoxB
            // 
            this.tBoxB.Location = new System.Drawing.Point(154, 148);
            this.tBoxB.Name = "tBoxB";
            this.tBoxB.Size = new System.Drawing.Size(60, 23);
            this.tBoxB.TabIndex = 9;
            this.tBoxB.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 30);
            this.label13.TabIndex = 8;
            this.label13.Text = "Отступ от торца \r\nисходной заготовки (B)";
            // 
            // tBoxDpiece
            // 
            this.tBoxDpiece.Location = new System.Drawing.Point(154, 80);
            this.tBoxDpiece.Name = "tBoxDpiece";
            this.tBoxDpiece.Size = new System.Drawing.Size(60, 23);
            this.tBoxDpiece.TabIndex = 7;
            this.tBoxDpiece.Text = "20";
            // 
            // tBoxL
            // 
            this.tBoxL.Location = new System.Drawing.Point(154, 51);
            this.tBoxL.Name = "tBoxL";
            this.tBoxL.Size = new System.Drawing.Size(60, 23);
            this.tBoxL.TabIndex = 6;
            this.tBoxL.Text = "88";
            // 
            // tBoxD
            // 
            this.tBoxD.Location = new System.Drawing.Point(154, 22);
            this.tBoxD.Name = "tBoxD";
            this.tBoxD.Size = new System.Drawing.Size(60, 23);
            this.tBoxD.TabIndex = 2;
            this.tBoxD.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Получаемая длина (L)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Получаемый диаметр (D)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Диаметр заготовки (Dзаг)";
            // 
            // FacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FacingForm";
            this.Text = "FacingForm";
            this.Load += new System.EventHandler(this.FacingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btBack;
        private Button btApply;
        private GroupBox groupBox3;
        private CheckBox checkBoxPause;
        private Label label9;
        private Label label8;
        private TextBox tBoxToolDepartureNumber;
        private TextBox tBoxToolNumber;
        private GroupBox groupBox2;
        private TextBox tBoxZ;
        private Label label12;
        private TextBox tBoxX;
        private Label label11;
        private Label label10;
        private TextBox tBoxS;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tBoxF;
        private TextBox tBoxU;
        private TextBox tBoxR;
        private TextBox tBoxh;
        private GroupBox groupBox1;
        private TextBox tBoxB;
        private Label label13;
        private TextBox tBoxDpiece;
        private TextBox tBoxL;
        private TextBox tBoxD;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label14;
        private TextBox tBoxLpiece;
        private Label label15;
        private TextBox tBoxW;
    }
}