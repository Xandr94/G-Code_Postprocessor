namespace G_Code_Postprocessor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBoxGcode = new System.Windows.Forms.GroupBox();
            this.tBoxGcode = new System.Windows.Forms.RichTextBox();
            this.btGenerateGcode = new System.Windows.Forms.Button();
            this.btSaveGcode = new System.Windows.Forms.Button();
            this.gBoxTransitions = new System.Windows.Forms.GroupBox();
            this.btUpdateTransitions = new System.Windows.Forms.Button();
            this.btAddTransition = new System.Windows.Forms.Button();
            this.btRemoveTransition = new System.Windows.Forms.Button();
            this.lBoxTransitions = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBoxOperationType = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gBoxGcode.SuspendLayout();
            this.gBoxTransitions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxOperationType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxGcode
            // 
            this.gBoxGcode.Controls.Add(this.tBoxGcode);
            this.gBoxGcode.Controls.Add(this.btGenerateGcode);
            this.gBoxGcode.Controls.Add(this.btSaveGcode);
            this.gBoxGcode.Location = new System.Drawing.Point(588, 12);
            this.gBoxGcode.Name = "gBoxGcode";
            this.gBoxGcode.Size = new System.Drawing.Size(200, 426);
            this.gBoxGcode.TabIndex = 0;
            this.gBoxGcode.TabStop = false;
            this.gBoxGcode.Text = "G-Code";
            // 
            // tBoxGcode
            // 
            this.tBoxGcode.Location = new System.Drawing.Point(6, 22);
            this.tBoxGcode.Name = "tBoxGcode";
            this.tBoxGcode.Size = new System.Drawing.Size(188, 364);
            this.tBoxGcode.TabIndex = 7;
            this.tBoxGcode.Text = "";
            this.tBoxGcode.WordWrap = false;
            // 
            // btGenerateGcode
            // 
            this.btGenerateGcode.Location = new System.Drawing.Point(6, 397);
            this.btGenerateGcode.Name = "btGenerateGcode";
            this.btGenerateGcode.Size = new System.Drawing.Size(75, 23);
            this.btGenerateGcode.TabIndex = 3;
            this.btGenerateGcode.Text = "Обновить";
            this.btGenerateGcode.UseVisualStyleBackColor = true;
            this.btGenerateGcode.Click += new System.EventHandler(this.btGenerateGcode_Click);
            // 
            // btSaveGcode
            // 
            this.btSaveGcode.Location = new System.Drawing.Point(119, 397);
            this.btSaveGcode.Name = "btSaveGcode";
            this.btSaveGcode.Size = new System.Drawing.Size(75, 23);
            this.btSaveGcode.TabIndex = 4;
            this.btSaveGcode.Text = "Сохранить";
            this.btSaveGcode.UseVisualStyleBackColor = true;
            this.btSaveGcode.Click += new System.EventHandler(this.btSaveGcode_Click);
            // 
            // gBoxTransitions
            // 
            this.gBoxTransitions.Controls.Add(this.btUpdateTransitions);
            this.gBoxTransitions.Controls.Add(this.btAddTransition);
            this.gBoxTransitions.Controls.Add(this.btRemoveTransition);
            this.gBoxTransitions.Controls.Add(this.lBoxTransitions);
            this.gBoxTransitions.Location = new System.Drawing.Point(218, 12);
            this.gBoxTransitions.Name = "gBoxTransitions";
            this.gBoxTransitions.Size = new System.Drawing.Size(364, 426);
            this.gBoxTransitions.TabIndex = 1;
            this.gBoxTransitions.TabStop = false;
            this.gBoxTransitions.Text = "Переходы операции";
            // 
            // btUpdateTransitions
            // 
            this.btUpdateTransitions.Location = new System.Drawing.Point(283, 397);
            this.btUpdateTransitions.Name = "btUpdateTransitions";
            this.btUpdateTransitions.Size = new System.Drawing.Size(75, 23);
            this.btUpdateTransitions.TabIndex = 2;
            this.btUpdateTransitions.Text = "Обновить";
            this.btUpdateTransitions.UseVisualStyleBackColor = true;
            this.btUpdateTransitions.Click += new System.EventHandler(this.btUpdateTransitions_Click);
            // 
            // btAddTransition
            // 
            this.btAddTransition.Location = new System.Drawing.Point(202, 397);
            this.btAddTransition.Name = "btAddTransition";
            this.btAddTransition.Size = new System.Drawing.Size(75, 23);
            this.btAddTransition.TabIndex = 0;
            this.btAddTransition.Text = "Добавить";
            this.btAddTransition.UseVisualStyleBackColor = true;
            this.btAddTransition.Click += new System.EventHandler(this.btAddTransition_Click);
            // 
            // btRemoveTransition
            // 
            this.btRemoveTransition.Enabled = false;
            this.btRemoveTransition.Location = new System.Drawing.Point(6, 397);
            this.btRemoveTransition.Name = "btRemoveTransition";
            this.btRemoveTransition.Size = new System.Drawing.Size(75, 23);
            this.btRemoveTransition.TabIndex = 5;
            this.btRemoveTransition.Text = "Удалить";
            this.btRemoveTransition.UseVisualStyleBackColor = true;
            this.btRemoveTransition.Click += new System.EventHandler(this.btRemoveTransition_Click);
            // 
            // lBoxTransitions
            // 
            this.lBoxTransitions.FormattingEnabled = true;
            this.lBoxTransitions.HorizontalScrollbar = true;
            this.lBoxTransitions.ItemHeight = 15;
            this.lBoxTransitions.Location = new System.Drawing.Point(6, 22);
            this.lBoxTransitions.Name = "lBoxTransitions";
            this.lBoxTransitions.Size = new System.Drawing.Size(352, 364);
            this.lBoxTransitions.TabIndex = 6;
            this.lBoxTransitions.SelectedIndexChanged += new System.EventHandler(this.lBoxTransitions_SelectedIndexChanged);

            //Для переноса слов
            this.lBoxTransitions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lBoxTransitions.MeasureItem += lst_MeasureItem;
            this.lBoxTransitions.DrawItem += lst_DrawItem;

            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gBoxOperationType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры операции";
            // 
            // gBoxOperationType
            // 
            this.gBoxOperationType.Controls.Add(this.radioButton3);
            this.gBoxOperationType.Controls.Add(this.radioButton2);
            this.gBoxOperationType.Controls.Add(this.radioButton1);
            this.gBoxOperationType.Location = new System.Drawing.Point(6, 22);
            this.gBoxOperationType.Name = "gBoxOperationType";
            this.gBoxOperationType.Size = new System.Drawing.Size(188, 100);
            this.gBoxOperationType.TabIndex = 0;
            this.gBoxOperationType.TabStop = false;
            this.gBoxOperationType.Text = "Тип операции";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Фрезерная 5х";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Фрезерная 3x";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Токарная 3x";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxTransitions);
            this.Controls.Add(this.gBoxGcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-Code Постпроцессор";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gBoxGcode.ResumeLayout(false);
            this.gBoxTransitions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gBoxOperationType.ResumeLayout(false);
            this.gBoxOperationType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gBoxGcode;
        private Button btGenerateGcode;
        private Button btSaveGcode;
        private GroupBox gBoxTransitions;
        private ListBox lBoxTransitions;
        private GroupBox groupBox1;
        private Button btAddTransition;
        private Button btRemoveTransition;
        private GroupBox gBoxOperationType;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RichTextBox tBoxGcode;
        private Button btUpdateTransitions;
    }
}