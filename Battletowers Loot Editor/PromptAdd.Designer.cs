namespace BattletowersLootEditor
{
    partial class PromptAdd
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
            this.numericUpDown_Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Chance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Meta = new System.Windows.Forms.NumericUpDown();
            this.textBoxEdit_ID = new System.Windows.Forms.TextBox();
            this.radioButton_Item = new System.Windows.Forms.RadioButton();
            this.radioButton_ChestGenHook = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Chance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meta)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_Max
            // 
            this.numericUpDown_Max.Location = new System.Drawing.Point(386, 25);
            this.numericUpDown_Max.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_Max.Name = "numericUpDown_Max";
            this.numericUpDown_Max.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Max.TabIndex = 10;
            // 
            // numericUpDown_Min
            // 
            this.numericUpDown_Min.Location = new System.Drawing.Point(330, 25);
            this.numericUpDown_Min.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_Min.Name = "numericUpDown_Min";
            this.numericUpDown_Min.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Min.TabIndex = 9;
            // 
            // numericUpDown_Chance
            // 
            this.numericUpDown_Chance.Location = new System.Drawing.Point(274, 25);
            this.numericUpDown_Chance.Name = "numericUpDown_Chance";
            this.numericUpDown_Chance.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Chance.TabIndex = 8;
            // 
            // numericUpDown_Meta
            // 
            this.numericUpDown_Meta.Location = new System.Drawing.Point(218, 25);
            this.numericUpDown_Meta.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_Meta.Name = "numericUpDown_Meta";
            this.numericUpDown_Meta.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Meta.TabIndex = 7;
            // 
            // textBoxEdit_ID
            // 
            this.textBoxEdit_ID.Location = new System.Drawing.Point(12, 25);
            this.textBoxEdit_ID.Name = "textBoxEdit_ID";
            this.textBoxEdit_ID.Size = new System.Drawing.Size(200, 20);
            this.textBoxEdit_ID.TabIndex = 6;
            // 
            // radioButton_Item
            // 
            this.radioButton_Item.AutoSize = true;
            this.radioButton_Item.Checked = true;
            this.radioButton_Item.Location = new System.Drawing.Point(12, 51);
            this.radioButton_Item.Name = "radioButton_Item";
            this.radioButton_Item.Size = new System.Drawing.Size(72, 17);
            this.radioButton_Item.TabIndex = 37;
            this.radioButton_Item.TabStop = true;
            this.radioButton_Item.Text = "Item Entry";
            this.radioButton_Item.UseVisualStyleBackColor = true;
            this.radioButton_Item.Click += new System.EventHandler(this.RadioButton_Clicked);
            // 
            // radioButton_ChestGenHook
            // 
            this.radioButton_ChestGenHook.AutoSize = true;
            this.radioButton_ChestGenHook.Location = new System.Drawing.Point(90, 51);
            this.radioButton_ChestGenHook.Name = "radioButton_ChestGenHook";
            this.radioButton_ChestGenHook.Size = new System.Drawing.Size(98, 17);
            this.radioButton_ChestGenHook.TabIndex = 36;
            this.radioButton_ChestGenHook.Text = "ChestGenHook";
            this.radioButton_ChestGenHook.UseVisualStyleBackColor = true;
            this.radioButton_ChestGenHook.Click += new System.EventHandler(this.RadioButton_Clicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Max Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Min Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Chance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Meta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Item ID / ChestGenHook";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(365, 51);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 43;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // PromptAdd
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 79);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_Item);
            this.Controls.Add(this.radioButton_ChestGenHook);
            this.Controls.Add(this.numericUpDown_Max);
            this.Controls.Add(this.numericUpDown_Min);
            this.Controls.Add(this.numericUpDown_Chance);
            this.Controls.Add(this.numericUpDown_Meta);
            this.Controls.Add(this.textBoxEdit_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PromptAdd";
            this.Text = "Add Entry";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Chance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_Max;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min;
        private System.Windows.Forms.NumericUpDown numericUpDown_Chance;
        private System.Windows.Forms.NumericUpDown numericUpDown_Meta;
        private System.Windows.Forms.TextBox textBoxEdit_ID;
        private System.Windows.Forms.RadioButton radioButton_Item;
        private System.Windows.Forms.RadioButton radioButton_ChestGenHook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDone;
    }
}