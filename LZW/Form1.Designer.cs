namespace LZW
{
    partial class Form1
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
            this.btnLoadEncode = new System.Windows.Forms.Button();
            this.numberOfBitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dictionaryMethodComboBox = new System.Windows.Forms.ComboBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.fileToEncodePath = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.indicesTextBox = new System.Windows.Forms.TextBox();
            this.btnLoadDecode = new System.Windows.Forms.Button();
            this.fileToDecodePath = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.checkBoxLRU = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBitsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadEncode
            // 
            this.btnLoadEncode.Location = new System.Drawing.Point(104, 65);
            this.btnLoadEncode.Name = "btnLoadEncode";
            this.btnLoadEncode.Size = new System.Drawing.Size(135, 46);
            this.btnLoadEncode.TabIndex = 0;
            this.btnLoadEncode.Text = "Load file to encode";
            this.btnLoadEncode.UseVisualStyleBackColor = true;
            this.btnLoadEncode.Click += new System.EventHandler(this.btnLoadEncode_Click);
            // 
            // numberOfBitsUpDown
            // 
            this.numberOfBitsUpDown.Location = new System.Drawing.Point(104, 258);
            this.numberOfBitsUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numberOfBitsUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numberOfBitsUpDown.Name = "numberOfBitsUpDown";
            this.numberOfBitsUpDown.ReadOnly = true;
            this.numberOfBitsUpDown.Size = new System.Drawing.Size(120, 22);
            this.numberOfBitsUpDown.TabIndex = 1;
            this.numberOfBitsUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(101, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. of bits for index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dictionary method";
            // 
            // dictionaryMethodComboBox
            // 
            this.dictionaryMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dictionaryMethodComboBox.FormattingEnabled = true;
            this.dictionaryMethodComboBox.Location = new System.Drawing.Point(104, 204);
            this.dictionaryMethodComboBox.Name = "dictionaryMethodComboBox";
            this.dictionaryMethodComboBox.Size = new System.Drawing.Size(121, 24);
            this.dictionaryMethodComboBox.TabIndex = 5;
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.Lime;
            this.btnEncode.Location = new System.Drawing.Point(115, 306);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(101, 51);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // fileToEncodePath
            // 
            this.fileToEncodePath.Location = new System.Drawing.Point(78, 117);
            this.fileToEncodePath.Multiline = true;
            this.fileToEncodePath.Name = "fileToEncodePath";
            this.fileToEncodePath.ReadOnly = true;
            this.fileToEncodePath.Size = new System.Drawing.Size(187, 46);
            this.fileToEncodePath.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(352, 322);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Display indexes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // indicesTextBox
            // 
            this.indicesTextBox.Location = new System.Drawing.Point(483, 258);
            this.indicesTextBox.Multiline = true;
            this.indicesTextBox.Name = "indicesTextBox";
            this.indicesTextBox.ReadOnly = true;
            this.indicesTextBox.Size = new System.Drawing.Size(297, 164);
            this.indicesTextBox.TabIndex = 9;
            // 
            // btnLoadDecode
            // 
            this.btnLoadDecode.Location = new System.Drawing.Point(542, 65);
            this.btnLoadDecode.Name = "btnLoadDecode";
            this.btnLoadDecode.Size = new System.Drawing.Size(135, 46);
            this.btnLoadDecode.TabIndex = 10;
            this.btnLoadDecode.Text = "Load file to decode";
            this.btnLoadDecode.UseVisualStyleBackColor = true;
            this.btnLoadDecode.Click += new System.EventHandler(this.btnLoadDecode_Click);
            // 
            // fileToDecodePath
            // 
            this.fileToDecodePath.Location = new System.Drawing.Point(484, 117);
            this.fileToDecodePath.Multiline = true;
            this.fileToDecodePath.Name = "fileToDecodePath";
            this.fileToDecodePath.ReadOnly = true;
            this.fileToDecodePath.Size = new System.Drawing.Size(250, 62);
            this.fileToDecodePath.TabIndex = 11;
            this.fileToDecodePath.Text = "Please select a file with .lzw extension or you will have to choose again";
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.Yellow;
            this.btnDecode.Location = new System.Drawing.Point(529, 185);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(101, 51);
            this.btnDecode.TabIndex = 12;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // checkBoxLRU
            // 
            this.checkBoxLRU.AutoSize = true;
            this.checkBoxLRU.Location = new System.Drawing.Point(231, 259);
            this.checkBoxLRU.Name = "checkBoxLRU";
            this.checkBoxLRU.Size = new System.Drawing.Size(56, 20);
            this.checkBoxLRU.TabIndex = 13;
            this.checkBoxLRU.Text = "LRU";
            this.checkBoxLRU.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxLRU);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.fileToDecodePath);
            this.Controls.Add(this.btnLoadDecode);
            this.Controls.Add(this.indicesTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.fileToEncodePath);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.dictionaryMethodComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfBitsUpDown);
            this.Controls.Add(this.btnLoadEncode);
            this.Name = "Form1";
            this.Text = "LZW";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBitsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadEncode;
        private System.Windows.Forms.NumericUpDown numberOfBitsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dictionaryMethodComboBox;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox fileToEncodePath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox indicesTextBox;
        private System.Windows.Forms.Button btnLoadDecode;
        private System.Windows.Forms.TextBox fileToDecodePath;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.CheckBox checkBoxLRU;
    }
}

