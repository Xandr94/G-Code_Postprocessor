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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gBoxGcode = new System.Windows.Forms.GroupBox();
            this.tBoxGcode = new System.Windows.Forms.RichTextBox();
            this.btGenerateGcode = new System.Windows.Forms.Button();
            this.btSaveGcode = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.gBoxTransitions = new System.Windows.Forms.GroupBox();
            this.lBoxTransitions = new System.Windows.Forms.ListBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdateTransitions = new System.Windows.Forms.Button();
            this.btAddTransition = new System.Windows.Forms.Button();
            this.btRemoveTransition = new System.Windows.Forms.Button();
            this.pbSafetyScreen = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gBoxGcode.SuspendLayout();
            this.gBoxTransitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSafetyScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxGcode
            // 
            this.gBoxGcode.Controls.Add(this.tBoxGcode);
            this.gBoxGcode.Controls.Add(this.btGenerateGcode);
            this.gBoxGcode.Controls.Add(this.btSaveGcode);
            this.gBoxGcode.Location = new System.Drawing.Point(568, 12);
            this.gBoxGcode.Name = "gBoxGcode";
            this.gBoxGcode.Size = new System.Drawing.Size(220, 426);
            this.gBoxGcode.TabIndex = 0;
            this.gBoxGcode.TabStop = false;
            this.gBoxGcode.Text = "G-Code";
            // 
            // tBoxGcode
            // 
            this.tBoxGcode.Location = new System.Drawing.Point(6, 22);
            this.tBoxGcode.Name = "tBoxGcode";
            this.tBoxGcode.ReadOnly = true;
            this.tBoxGcode.Size = new System.Drawing.Size(208, 364);
            this.tBoxGcode.TabIndex = 7;
            this.tBoxGcode.Text = "";
            this.tBoxGcode.WordWrap = false;
            // 
            // btGenerateGcode
            // 
            this.btGenerateGcode.Location = new System.Drawing.Point(6, 397);
            this.btGenerateGcode.Name = "btGenerateGcode";
            this.btGenerateGcode.Size = new System.Drawing.Size(107, 23);
            this.btGenerateGcode.TabIndex = 3;
            this.btGenerateGcode.Text = "Копировать всё";
            this.btGenerateGcode.UseVisualStyleBackColor = true;
            this.btGenerateGcode.Click += new System.EventHandler(this.btGenerateGcode_Click);
            // 
            // btSaveGcode
            // 
            this.btSaveGcode.Location = new System.Drawing.Point(139, 397);
            this.btSaveGcode.Name = "btSaveGcode";
            this.btSaveGcode.Size = new System.Drawing.Size(75, 23);
            this.btSaveGcode.TabIndex = 4;
            this.btSaveGcode.Text = "Сохранить";
            this.btSaveGcode.UseVisualStyleBackColor = true;
            this.btSaveGcode.Click += new System.EventHandler(this.btSaveGcode_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(628, 409);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(160, 35);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Всё в порядке";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // gBoxTransitions
            // 
            this.gBoxTransitions.Controls.Add(this.lBoxTransitions);
            this.gBoxTransitions.Controls.Add(this.btEdit);
            this.gBoxTransitions.Controls.Add(this.btClear);
            this.gBoxTransitions.Controls.Add(this.btUpdateTransitions);
            this.gBoxTransitions.Controls.Add(this.btAddTransition);
            this.gBoxTransitions.Controls.Add(this.btRemoveTransition);
            this.gBoxTransitions.Location = new System.Drawing.Point(12, 12);
            this.gBoxTransitions.Name = "gBoxTransitions";
            this.gBoxTransitions.Size = new System.Drawing.Size(550, 426);
            this.gBoxTransitions.TabIndex = 1;
            this.gBoxTransitions.TabStop = false;
            this.gBoxTransitions.Text = "Переходы операции";
            // 
            // lBoxTransitions
            // 
            this.lBoxTransitions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lBoxTransitions.FormattingEnabled = true;
            this.lBoxTransitions.ItemHeight = 15;
            this.lBoxTransitions.Location = new System.Drawing.Point(6, 22);
            this.lBoxTransitions.Name = "lBoxTransitions";
            this.lBoxTransitions.Size = new System.Drawing.Size(538, 364);
            this.lBoxTransitions.TabIndex = 9;
            this.lBoxTransitions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_DrawItem);
            this.lBoxTransitions.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lst_MeasureItem);
            this.lBoxTransitions.SelectedIndexChanged += new System.EventHandler(this.lBoxTransitions_SelectedIndexChanged);
            this.lBoxTransitions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxTransitions_MouseDoubleClick);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(273, 397);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(99, 23);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "Редактировать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(92, 397);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(80, 23);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btUpdateTransitions
            // 
            this.btUpdateTransitions.Location = new System.Drawing.Point(464, 397);
            this.btUpdateTransitions.Name = "btUpdateTransitions";
            this.btUpdateTransitions.Size = new System.Drawing.Size(80, 23);
            this.btUpdateTransitions.TabIndex = 2;
            this.btUpdateTransitions.Text = "Обновить";
            this.btUpdateTransitions.UseVisualStyleBackColor = true;
            this.btUpdateTransitions.Click += new System.EventHandler(this.btUpdateTransitions_Click);
            // 
            // btAddTransition
            // 
            this.btAddTransition.Location = new System.Drawing.Point(378, 397);
            this.btAddTransition.Name = "btAddTransition";
            this.btAddTransition.Size = new System.Drawing.Size(80, 23);
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
            this.btRemoveTransition.Size = new System.Drawing.Size(80, 23);
            this.btRemoveTransition.TabIndex = 5;
            this.btRemoveTransition.Text = "Удалить";
            this.btRemoveTransition.UseVisualStyleBackColor = true;
            this.btRemoveTransition.Click += new System.EventHandler(this.btRemoveTransition_Click);
            // 
            // pbSafetyScreen
            // 
            this.pbSafetyScreen.Image = global::G_Code_Postprocessor.Properties.Resources.Экран_безопасности;
            this.pbSafetyScreen.Location = new System.Drawing.Point(487, 0);
            this.pbSafetyScreen.Name = "pbSafetyScreen";
            this.pbSafetyScreen.Size = new System.Drawing.Size(247, 172);
            this.pbSafetyScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSafetyScreen.TabIndex = 2;
            this.pbSafetyScreen.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Токарная"});
            this.comboBox1.Location = new System.Drawing.Point(140, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.pbSafetyScreen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gBoxTransitions);
            this.Controls.Add(this.gBoxGcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жикодер 0.2.0";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gBoxGcode.ResumeLayout(false);
            this.gBoxTransitions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSafetyScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /*
            // Для переноса по словам добавить в блок листбокса в регионе сверху
            this.lBoxTransitions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lBoxTransitions.MeasureItem += lst_MeasureItem;
            this.lBoxTransitions.DrawItem += lst_DrawItem;
        */

        private GroupBox gBoxGcode;
        private Button btGenerateGcode;
        private Button btSaveGcode;
        private GroupBox gBoxTransitions;
        private Button btAddTransition;
        private Button btRemoveTransition;
        private RichTextBox tBoxGcode;
        private Button btUpdateTransitions;
        private Button btClear;
        private Button btEdit;
        private ListBox lBoxTransitions;
        private PictureBox pbSafetyScreen;
        private Button btOk;
        private ComboBox comboBox1;
    }
}