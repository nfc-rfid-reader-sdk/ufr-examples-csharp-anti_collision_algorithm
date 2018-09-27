namespace UFR{
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bReaderClose = new System.Windows.Forms.Button();
            this.bReaderReset = new System.Windows.Forms.Button();
            this.bReaderOpen = new System.Windows.Forms.Button();
            this.ReaderTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RBAscii = new System.Windows.Forms.RadioButton();
            this.RBHexadecimal = new System.Windows.Forms.RadioButton();
            this.RBDecimal = new System.Windows.Forms.RadioButton();
            this.Byte6TB = new System.Windows.Forms.TextBox();
            this.Byte5TB = new System.Windows.Forms.TextBox();
            this.Byte4TB = new System.Windows.Forms.TextBox();
            this.Byte3TB = new System.Windows.Forms.TextBox();
            this.Byte2TB = new System.Windows.Forms.TextBox();
            this.Byte1TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonBKey = new System.Windows.Forms.RadioButton();
            this.radioButtonAKey = new System.Windows.Forms.RadioButton();
            this.bReadBlock = new System.Windows.Forms.Button();
            this.BlockDataTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blockAddressTextBox = new System.Windows.Forms.TextBox();
            this.bDeselect = new System.Windows.Forms.Button();
            this.SelectedCardTextBox = new System.Windows.Forms.RichTextBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.CardComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EnumTextBox = new System.Windows.Forms.RichTextBox();
            this.bEnumCards = new System.Windows.Forms.Button();
            this.bDisableAntiColl = new System.Windows.Forms.Button();
            this.bEnableAntiColl = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bReaderClose);
            this.groupBox1.Controls.Add(this.bReaderReset);
            this.groupBox1.Controls.Add(this.bReaderOpen);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader commands";
            // 
            // bReaderClose
            // 
            this.bReaderClose.Location = new System.Drawing.Point(212, 19);
            this.bReaderClose.Name = "bReaderClose";
            this.bReaderClose.Size = new System.Drawing.Size(98, 23);
            this.bReaderClose.TabIndex = 2;
            this.bReaderClose.Text = "Reader Close";
            this.bReaderClose.UseVisualStyleBackColor = true;
            this.bReaderClose.Click += new System.EventHandler(this.bReaderClose_Click);
            // 
            // bReaderReset
            // 
            this.bReaderReset.Location = new System.Drawing.Point(107, 19);
            this.bReaderReset.Name = "bReaderReset";
            this.bReaderReset.Size = new System.Drawing.Size(99, 23);
            this.bReaderReset.TabIndex = 1;
            this.bReaderReset.Text = "Reader Reset";
            this.bReaderReset.UseVisualStyleBackColor = true;
            this.bReaderReset.Click += new System.EventHandler(this.bReaderReset_Click);
            // 
            // bReaderOpen
            // 
            this.bReaderOpen.Location = new System.Drawing.Point(6, 19);
            this.bReaderOpen.Name = "bReaderOpen";
            this.bReaderOpen.Size = new System.Drawing.Size(95, 23);
            this.bReaderOpen.TabIndex = 0;
            this.bReaderOpen.Text = "Reader Open";
            this.bReaderOpen.UseVisualStyleBackColor = true;
            this.bReaderOpen.Click += new System.EventHandler(this.bReaderOpen_Click);
            // 
            // ReaderTextBox
            // 
            this.ReaderTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReaderTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderTextBox.Location = new System.Drawing.Point(3, 384);
            this.ReaderTextBox.Name = "ReaderTextBox";
            this.ReaderTextBox.ReadOnly = true;
            this.ReaderTextBox.Size = new System.Drawing.Size(627, 91);
            this.ReaderTextBox.TabIndex = 1;
            this.ReaderTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.bDisableAntiColl);
            this.groupBox2.Controls.Add(this.bEnableAntiColl);
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 321);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anti collision commands";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.bDeselect);
            this.groupBox4.Controls.Add(this.SelectedCardTextBox);
            this.groupBox4.Controls.Add(this.bSelect);
            this.groupBox4.Controls.Add(this.CardComboBox);
            this.groupBox4.Location = new System.Drawing.Point(233, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 267);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Card  operations";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.Byte6TB);
            this.groupBox5.Controls.Add(this.Byte5TB);
            this.groupBox5.Controls.Add(this.Byte4TB);
            this.groupBox5.Controls.Add(this.Byte3TB);
            this.groupBox5.Controls.Add(this.Byte2TB);
            this.groupBox5.Controls.Add(this.Byte1TB);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.radioButtonBKey);
            this.groupBox5.Controls.Add(this.radioButtonAKey);
            this.groupBox5.Controls.Add(this.bReadBlock);
            this.groupBox5.Controls.Add(this.BlockDataTextBox);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.blockAddressTextBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(376, 168);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Block read";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RBAscii);
            this.groupBox6.Controls.Add(this.RBHexadecimal);
            this.groupBox6.Controls.Add(this.RBDecimal);
            this.groupBox6.Location = new System.Drawing.Point(6, 134);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(364, 28);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // RBAscii
            // 
            this.RBAscii.AutoSize = true;
            this.RBAscii.Location = new System.Drawing.Point(241, 11);
            this.RBAscii.Name = "RBAscii";
            this.RBAscii.Size = new System.Drawing.Size(52, 17);
            this.RBAscii.TabIndex = 16;
            this.RBAscii.TabStop = true;
            this.RBAscii.Text = "ASCII";
            this.RBAscii.UseVisualStyleBackColor = true;
            this.RBAscii.CheckedChanged += new System.EventHandler(this.RBAscii_CheckedChanged);
            // 
            // RBHexadecimal
            // 
            this.RBHexadecimal.AutoSize = true;
            this.RBHexadecimal.Checked = true;
            this.RBHexadecimal.Location = new System.Drawing.Point(33, 11);
            this.RBHexadecimal.Name = "RBHexadecimal";
            this.RBHexadecimal.Size = new System.Drawing.Size(86, 17);
            this.RBHexadecimal.TabIndex = 14;
            this.RBHexadecimal.TabStop = true;
            this.RBHexadecimal.Text = "Hexadecimal";
            this.RBHexadecimal.UseVisualStyleBackColor = true;
            this.RBHexadecimal.CheckedChanged += new System.EventHandler(this.RBHexadecimal_CheckedChanged);
            // 
            // RBDecimal
            // 
            this.RBDecimal.AutoSize = true;
            this.RBDecimal.Location = new System.Drawing.Point(149, 11);
            this.RBDecimal.Name = "RBDecimal";
            this.RBDecimal.Size = new System.Drawing.Size(63, 17);
            this.RBDecimal.TabIndex = 15;
            this.RBDecimal.TabStop = true;
            this.RBDecimal.Text = "Decimal";
            this.RBDecimal.UseVisualStyleBackColor = true;
            this.RBDecimal.CheckedChanged += new System.EventHandler(this.RBDecimal_CheckedChanged);
            // 
            // Byte6TB
            // 
            this.Byte6TB.Location = new System.Drawing.Point(224, 58);
            this.Byte6TB.MaxLength = 2;
            this.Byte6TB.Name = "Byte6TB";
            this.Byte6TB.Size = new System.Drawing.Size(31, 20);
            this.Byte6TB.TabIndex = 13;
            this.Byte6TB.Text = "FF";
            this.Byte6TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte5TB
            // 
            this.Byte5TB.Location = new System.Drawing.Point(187, 58);
            this.Byte5TB.MaxLength = 2;
            this.Byte5TB.Name = "Byte5TB";
            this.Byte5TB.Size = new System.Drawing.Size(31, 20);
            this.Byte5TB.TabIndex = 12;
            this.Byte5TB.Text = "FF";
            this.Byte5TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte4TB
            // 
            this.Byte4TB.Location = new System.Drawing.Point(150, 58);
            this.Byte4TB.MaxLength = 2;
            this.Byte4TB.Name = "Byte4TB";
            this.Byte4TB.Size = new System.Drawing.Size(31, 20);
            this.Byte4TB.TabIndex = 11;
            this.Byte4TB.Text = "FF";
            this.Byte4TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte3TB
            // 
            this.Byte3TB.Location = new System.Drawing.Point(113, 58);
            this.Byte3TB.MaxLength = 2;
            this.Byte3TB.Name = "Byte3TB";
            this.Byte3TB.Size = new System.Drawing.Size(31, 20);
            this.Byte3TB.TabIndex = 10;
            this.Byte3TB.Text = "FF";
            this.Byte3TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte2TB
            // 
            this.Byte2TB.Location = new System.Drawing.Point(76, 58);
            this.Byte2TB.MaxLength = 2;
            this.Byte2TB.Name = "Byte2TB";
            this.Byte2TB.Size = new System.Drawing.Size(31, 20);
            this.Byte2TB.TabIndex = 9;
            this.Byte2TB.Text = "FF";
            this.Byte2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Byte1TB
            // 
            this.Byte1TB.Location = new System.Drawing.Point(39, 58);
            this.Byte1TB.MaxLength = 2;
            this.Byte1TB.Name = "Byte1TB";
            this.Byte1TB.Size = new System.Drawing.Size(31, 20);
            this.Byte1TB.TabIndex = 8;
            this.Byte1TB.Text = "FF";
            this.Byte1TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key : ";
            // 
            // radioButtonBKey
            // 
            this.radioButtonBKey.AutoSize = true;
            this.radioButtonBKey.Location = new System.Drawing.Point(145, 34);
            this.radioButtonBKey.Name = "radioButtonBKey";
            this.radioButtonBKey.Size = new System.Drawing.Size(136, 17);
            this.radioButtonBKey.TabIndex = 6;
            this.radioButtonBKey.TabStop = true;
            this.radioButtonBKey.Text = "MIFARE_AUTHENT1B";
            this.radioButtonBKey.UseVisualStyleBackColor = true;
            // 
            // radioButtonAKey
            // 
            this.radioButtonAKey.AutoSize = true;
            this.radioButtonAKey.Checked = true;
            this.radioButtonAKey.Location = new System.Drawing.Point(145, 15);
            this.radioButtonAKey.Name = "radioButtonAKey";
            this.radioButtonAKey.Size = new System.Drawing.Size(136, 17);
            this.radioButtonAKey.TabIndex = 5;
            this.radioButtonAKey.TabStop = true;
            this.radioButtonAKey.Text = "MIFARE_AUTHENT1A";
            this.radioButtonAKey.UseVisualStyleBackColor = true;
            // 
            // bReadBlock
            // 
            this.bReadBlock.Location = new System.Drawing.Point(285, 56);
            this.bReadBlock.Name = "bReadBlock";
            this.bReadBlock.Size = new System.Drawing.Size(75, 23);
            this.bReadBlock.TabIndex = 4;
            this.bReadBlock.Text = "Read block";
            this.bReadBlock.UseVisualStyleBackColor = true;
            this.bReadBlock.Click += new System.EventHandler(this.bReadBlock_Click);
            // 
            // BlockDataTextBox
            // 
            this.BlockDataTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockDataTextBox.Location = new System.Drawing.Point(6, 103);
            this.BlockDataTextBox.Name = "BlockDataTextBox";
            this.BlockDataTextBox.ReadOnly = true;
            this.BlockDataTextBox.Size = new System.Drawing.Size(364, 25);
            this.BlockDataTextBox.TabIndex = 3;
            this.BlockDataTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Block address :";
            // 
            // blockAddressTextBox
            // 
            this.blockAddressTextBox.Location = new System.Drawing.Point(92, 16);
            this.blockAddressTextBox.Name = "blockAddressTextBox";
            this.blockAddressTextBox.Size = new System.Drawing.Size(47, 20);
            this.blockAddressTextBox.TabIndex = 0;
            this.blockAddressTextBox.Text = "0";
            // 
            // bDeselect
            // 
            this.bDeselect.Location = new System.Drawing.Point(137, 22);
            this.bDeselect.Name = "bDeselect";
            this.bDeselect.Size = new System.Drawing.Size(82, 23);
            this.bDeselect.TabIndex = 3;
            this.bDeselect.Text = "Deselect card";
            this.bDeselect.UseVisualStyleBackColor = true;
            this.bDeselect.Click += new System.EventHandler(this.bDeselect_Click);
            // 
            // SelectedCardTextBox
            // 
            this.SelectedCardTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SelectedCardTextBox.Location = new System.Drawing.Point(6, 49);
            this.SelectedCardTextBox.Name = "SelectedCardTextBox";
            this.SelectedCardTextBox.ReadOnly = true;
            this.SelectedCardTextBox.Size = new System.Drawing.Size(376, 38);
            this.SelectedCardTextBox.TabIndex = 2;
            this.SelectedCardTextBox.Text = "Card not selected";
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(56, 22);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 1;
            this.bSelect.Text = "Select card";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // CardComboBox
            // 
            this.CardComboBox.FormattingEnabled = true;
            this.CardComboBox.Location = new System.Drawing.Point(6, 22);
            this.CardComboBox.Name = "CardComboBox";
            this.CardComboBox.Size = new System.Drawing.Size(44, 21);
            this.CardComboBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EnumTextBox);
            this.groupBox3.Controls.Add(this.bEnumCards);
            this.groupBox3.Location = new System.Drawing.Point(6, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 267);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cards";
            // 
            // EnumTextBox
            // 
            this.EnumTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnumTextBox.Location = new System.Drawing.Point(6, 49);
            this.EnumTextBox.Name = "EnumTextBox";
            this.EnumTextBox.ReadOnly = true;
            this.EnumTextBox.Size = new System.Drawing.Size(209, 212);
            this.EnumTextBox.TabIndex = 3;
            this.EnumTextBox.Text = "";
            // 
            // bEnumCards
            // 
            this.bEnumCards.Location = new System.Drawing.Point(6, 19);
            this.bEnumCards.Name = "bEnumCards";
            this.bEnumCards.Size = new System.Drawing.Size(105, 24);
            this.bEnumCards.TabIndex = 3;
            this.bEnumCards.Text = "Enumerate cards";
            this.bEnumCards.UseVisualStyleBackColor = true;
            this.bEnumCards.Click += new System.EventHandler(this.bEnumCards_Click);
            // 
            // bDisableAntiColl
            // 
            this.bDisableAntiColl.Location = new System.Drawing.Point(123, 19);
            this.bDisableAntiColl.Name = "bDisableAntiColl";
            this.bDisableAntiColl.Size = new System.Drawing.Size(115, 23);
            this.bDisableAntiColl.TabIndex = 1;
            this.bDisableAntiColl.Text = "Disable Anti Collision";
            this.bDisableAntiColl.UseVisualStyleBackColor = true;
            this.bDisableAntiColl.Click += new System.EventHandler(this.bDisableAntiColl_Click);
            // 
            // bEnableAntiColl
            // 
            this.bEnableAntiColl.Location = new System.Drawing.Point(6, 19);
            this.bEnableAntiColl.Name = "bEnableAntiColl";
            this.bEnableAntiColl.Size = new System.Drawing.Size(111, 23);
            this.bEnableAntiColl.TabIndex = 0;
            this.bEnableAntiColl.Text = "Enable Anti Collision";
            this.bEnableAntiColl.UseVisualStyleBackColor = true;
            this.bEnableAntiColl.Click += new System.EventHandler(this.bEnableAntiColl_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(338, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(286, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.d-logic.net/nfc-rfid-reader-sdk/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 478);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ReaderTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "uFR Nano Anti Collision ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bReaderClose;
        private System.Windows.Forms.Button bReaderReset;
        private System.Windows.Forms.Button bReaderOpen;
        private System.Windows.Forms.RichTextBox ReaderTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox EnumTextBox;
        private System.Windows.Forms.Button bEnumCards;
        private System.Windows.Forms.Button bDisableAntiColl;
        private System.Windows.Forms.Button bEnableAntiColl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.ComboBox CardComboBox;
        private System.Windows.Forms.RichTextBox SelectedCardTextBox;
        private System.Windows.Forms.Button bDeselect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bReadBlock;
        private System.Windows.Forms.RichTextBox BlockDataTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blockAddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonBKey;
        private System.Windows.Forms.RadioButton radioButtonAKey;
        private System.Windows.Forms.TextBox Byte6TB;
        private System.Windows.Forms.TextBox Byte5TB;
        private System.Windows.Forms.TextBox Byte4TB;
        private System.Windows.Forms.TextBox Byte3TB;
        private System.Windows.Forms.TextBox Byte2TB;
        private System.Windows.Forms.TextBox Byte1TB;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton RBAscii;
        private System.Windows.Forms.RadioButton RBDecimal;
        private System.Windows.Forms.RadioButton RBHexadecimal;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

