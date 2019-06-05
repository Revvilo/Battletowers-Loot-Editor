namespace BattletowersLootEditor
{
    partial class PromptEdit
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
            this.labelOriginal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxOriginal_ID = new System.Windows.Forms.TextBox();
            this.textBoxOriginal_Meta = new System.Windows.Forms.TextBox();
            this.textBoxOriginal_Chance = new System.Windows.Forms.TextBox();
            this.textBoxOriginal_Min = new System.Windows.Forms.TextBox();
            this.textBoxOriginal_Max = new System.Windows.Forms.TextBox();
            this.textBoxEdit_ID = new System.Windows.Forms.TextBox();
            this.numericUpDown_Meta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Chance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Max = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Chance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Max)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(12, 15);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(42, 13);
            this.labelOriginal.TabIndex = 21;
            this.labelOriginal.Text = "Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Item ID / ChestGenHook";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Meta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Chance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Min Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Max Count";
            // 
            // buttonDone
            // 
            this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDone.Location = new System.Drawing.Point(330, 81);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 28;
            this.buttonDone.Text = "OK";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(411, 81);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginal_ID
            // 
            this.textBoxOriginal_ID.Location = new System.Drawing.Point(60, 12);
            this.textBoxOriginal_ID.Name = "textBoxOriginal_ID";
            this.textBoxOriginal_ID.ReadOnly = true;
            this.textBoxOriginal_ID.Size = new System.Drawing.Size(200, 20);
            this.textBoxOriginal_ID.TabIndex = 6;
            // 
            // textBoxOriginal_Meta
            // 
            this.textBoxOriginal_Meta.Location = new System.Drawing.Point(266, 12);
            this.textBoxOriginal_Meta.Name = "textBoxOriginal_Meta";
            this.textBoxOriginal_Meta.ReadOnly = true;
            this.textBoxOriginal_Meta.Size = new System.Drawing.Size(50, 20);
            this.textBoxOriginal_Meta.TabIndex = 7;
            // 
            // textBoxOriginal_Chance
            // 
            this.textBoxOriginal_Chance.Location = new System.Drawing.Point(322, 12);
            this.textBoxOriginal_Chance.Name = "textBoxOriginal_Chance";
            this.textBoxOriginal_Chance.ReadOnly = true;
            this.textBoxOriginal_Chance.Size = new System.Drawing.Size(50, 20);
            this.textBoxOriginal_Chance.TabIndex = 8;
            // 
            // textBoxOriginal_Min
            // 
            this.textBoxOriginal_Min.Location = new System.Drawing.Point(378, 12);
            this.textBoxOriginal_Min.Name = "textBoxOriginal_Min";
            this.textBoxOriginal_Min.ReadOnly = true;
            this.textBoxOriginal_Min.Size = new System.Drawing.Size(50, 20);
            this.textBoxOriginal_Min.TabIndex = 9;
            // 
            // textBoxOriginal_Max
            // 
            this.textBoxOriginal_Max.Location = new System.Drawing.Point(434, 12);
            this.textBoxOriginal_Max.Name = "textBoxOriginal_Max";
            this.textBoxOriginal_Max.ReadOnly = true;
            this.textBoxOriginal_Max.Size = new System.Drawing.Size(50, 20);
            this.textBoxOriginal_Max.TabIndex = 10;
            // 
            // textBoxEdit_ID
            // 
            this.textBoxEdit_ID.Location = new System.Drawing.Point(60, 52);
            this.textBoxEdit_ID.Name = "textBoxEdit_ID";
            this.textBoxEdit_ID.Size = new System.Drawing.Size(200, 20);
            this.textBoxEdit_ID.TabIndex = 1;
            this.textBoxEdit_ID.TextChanged += new System.EventHandler(this.EditBox_TextChanged);
            // 
            // numericUpDown_Meta
            // 
            this.numericUpDown_Meta.Location = new System.Drawing.Point(266, 52);
            this.numericUpDown_Meta.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_Meta.Name = "numericUpDown_Meta";
            this.numericUpDown_Meta.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Meta.TabIndex = 2;
            this.numericUpDown_Meta.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numericUpDown_Chance
            // 
            this.numericUpDown_Chance.Location = new System.Drawing.Point(322, 52);
            this.numericUpDown_Chance.Name = "numericUpDown_Chance";
            this.numericUpDown_Chance.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Chance.TabIndex = 3;
            this.numericUpDown_Chance.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numericUpDown_Min
            // 
            this.numericUpDown_Min.Location = new System.Drawing.Point(378, 52);
            this.numericUpDown_Min.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_Min.Name = "numericUpDown_Min";
            this.numericUpDown_Min.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Min.TabIndex = 4;
            this.numericUpDown_Min.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numericUpDown_Max
            // 
            this.numericUpDown_Max.Location = new System.Drawing.Point(434, 52);
            this.numericUpDown_Max.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_Max.Name = "numericUpDown_Max";
            this.numericUpDown_Max.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Max.TabIndex = 5;
            this.numericUpDown_Max.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // EditPrompt
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(498, 116);
            this.Controls.Add(this.numericUpDown_Max);
            this.Controls.Add(this.numericUpDown_Min);
            this.Controls.Add(this.numericUpDown_Chance);
            this.Controls.Add(this.numericUpDown_Meta);
            this.Controls.Add(this.textBoxOriginal_Max);
            this.Controls.Add(this.textBoxOriginal_Min);
            this.Controls.Add(this.textBoxOriginal_Chance);
            this.Controls.Add(this.textBoxOriginal_Meta);
            this.Controls.Add(this.textBoxEdit_ID);
            this.Controls.Add(this.textBoxOriginal_ID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Loot Entry";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Chance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxOriginal_ID;
        private System.Windows.Forms.TextBox textBoxOriginal_Meta;
        private System.Windows.Forms.TextBox textBoxOriginal_Chance;
        private System.Windows.Forms.TextBox textBoxOriginal_Min;
        private System.Windows.Forms.TextBox textBoxOriginal_Max;
        private System.Windows.Forms.TextBox textBoxEdit_ID;
        private System.Windows.Forms.NumericUpDown numericUpDown_Meta;
        private System.Windows.Forms.NumericUpDown numericUpDown_Chance;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min;
        private System.Windows.Forms.NumericUpDown numericUpDown_Max;
    }
}