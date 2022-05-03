namespace G_Code_Postprocessor
{
    partial class TransitionTypeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btUninstall = new System.Windows.Forms.Button();
            this.btInstallPiece = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btShoulderTurning = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btFacing = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btUninstall);
            this.groupBox1.Controls.Add(this.btInstallPiece);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подготовительные работы";
            // 
            // btUninstall
            // 
            this.btUninstall.Location = new System.Drawing.Point(6, 58);
            this.btUninstall.Name = "btUninstall";
            this.btUninstall.Size = new System.Drawing.Size(188, 30);
            this.btUninstall.TabIndex = 1;
            this.btUninstall.Text = "Снять заготовку";
            this.btUninstall.UseVisualStyleBackColor = true;
            this.btUninstall.Click += new System.EventHandler(this.btUninstall_Click);
            // 
            // btInstallPiece
            // 
            this.btInstallPiece.Location = new System.Drawing.Point(6, 22);
            this.btInstallPiece.Name = "btInstallPiece";
            this.btInstallPiece.Size = new System.Drawing.Size(188, 30);
            this.btInstallPiece.TabIndex = 0;
            this.btInstallPiece.Text = "Установить заготовку";
            this.btInstallPiece.UseVisualStyleBackColor = true;
            this.btInstallPiece.Click += new System.EventHandler(this.btInstallPiece_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btShoulderTurning);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цилиндр";
            // 
            // btShoulderTurning
            // 
            this.btShoulderTurning.Location = new System.Drawing.Point(6, 22);
            this.btShoulderTurning.Name = "btShoulderTurning";
            this.btShoulderTurning.Size = new System.Drawing.Size(188, 30);
            this.btShoulderTurning.TabIndex = 1;
            this.btShoulderTurning.Text = "Точить цилиндр";
            this.btShoulderTurning.UseVisualStyleBackColor = true;
            this.btShoulderTurning.Click += new System.EventHandler(this.btShoulderTurning_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btFacing);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Торец";
            // 
            // btFacing
            // 
            this.btFacing.Location = new System.Drawing.Point(6, 22);
            this.btFacing.Name = "btFacing";
            this.btFacing.Size = new System.Drawing.Size(188, 30);
            this.btFacing.TabIndex = 2;
            this.btFacing.Text = "Подрезать торец";
            this.btFacing.UseVisualStyleBackColor = true;
            this.btFacing.Click += new System.EventHandler(this.btFacing_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(218, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Отверстие";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скоро";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(424, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Резьба";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 69);
            this.label3.TabIndex = 1;
            this.label3.Text = "Скоро";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(12, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Конус";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скоро";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 319);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 30);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // TransitionTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TransitionTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите переход";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btInstallPiece;
        private GroupBox groupBox2;
        private Button btShoulderTurning;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button btUninstall;
        private Button btFacing;
        private Label label2;
        private Label label3;
        private GroupBox groupBox6;
        private Label label1;
        private Button btBack;
    }
}