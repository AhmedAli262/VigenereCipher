namespace Vigenere_cipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputMessage = new System.Windows.Forms.TextBox();
            this.inputKey = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.outputEncryptedMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputKeyLength = new System.Windows.Forms.NumericUpDown();
            this.constantLength = new System.Windows.Forms.CheckBox();
            this.btnDecryptUnknownKey = new System.Windows.Forms.Button();
            this.inputKnownLetters = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputEncryptedMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableMessageKey = new System.Windows.Forms.DataGridView();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputBlankSpaces = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDecryptDictionary = new System.Windows.Forms.Button();
            this.knownLettersDict = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.inputSecretMessage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.inputBlankSpace = new System.Windows.Forms.NumericUpDown();
            this.tableMessageUnknownKey = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputKeyLength)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMessageKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBlankSpaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBlankSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMessageUnknownKey)).BeginInit();
            this.SuspendLayout();
            // 
            // inputMessage
            // 
            this.inputMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMessage.Location = new System.Drawing.Point(6, 35);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(671, 20);
            this.inputMessage.TabIndex = 0;
            // 
            // inputKey
            // 
            this.inputKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputKey.Location = new System.Drawing.Point(6, 93);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(671, 20);
            this.inputKey.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(6, 119);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(77, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.btnEncipher_Click);
            // 
            // outputEncryptedMessage
            // 
            this.outputEncryptedMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputEncryptedMessage.Location = new System.Drawing.Point(6, 182);
            this.outputEncryptedMessage.Name = "outputEncryptedMessage";
            this.outputEncryptedMessage.Size = new System.Drawing.Size(671, 20);
            this.outputEncryptedMessage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encrypted message";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(89, 119);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(77, 23);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(707, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputMessage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputKey);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonEncrypt);
            this.groupBox1.Controls.Add(this.buttonDecrypt);
            this.groupBox1.Controls.Add(this.outputEncryptedMessage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 498);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt or decrypt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 643);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableMessageUnknownKey);
            this.groupBox2.Controls.Add(this.inputBlankSpace);
            this.groupBox2.Controls.Add(this.inputKeyLength);
            this.groupBox2.Controls.Add(this.constantLength);
            this.groupBox2.Controls.Add(this.btnDecryptUnknownKey);
            this.groupBox2.Controls.Add(this.inputKnownLetters);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.inputEncryptedMessage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 611);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decode unknown key";
            // 
            // inputKeyLength
            // 
            this.inputKeyLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputKeyLength.Location = new System.Drawing.Point(9, 90);
            this.inputKeyLength.Name = "inputKeyLength";
            this.inputKeyLength.Size = new System.Drawing.Size(543, 20);
            this.inputKeyLength.TabIndex = 26;
            // 
            // constantLength
            // 
            this.constantLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.constantLength.AutoSize = true;
            this.constantLength.Location = new System.Drawing.Point(573, 91);
            this.constantLength.Name = "constantLength";
            this.constantLength.Size = new System.Drawing.Size(100, 17);
            this.constantLength.TabIndex = 25;
            this.constantLength.Text = "Constant length";
            this.constantLength.UseVisualStyleBackColor = true;
            // 
            // btnDecryptUnknownKey
            // 
            this.btnDecryptUnknownKey.Location = new System.Drawing.Point(10, 233);
            this.btnDecryptUnknownKey.Name = "btnDecryptUnknownKey";
            this.btnDecryptUnknownKey.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptUnknownKey.TabIndex = 21;
            this.btnDecryptUnknownKey.Text = "Decrypt";
            this.btnDecryptUnknownKey.UseVisualStyleBackColor = true;
            this.btnDecryptUnknownKey.Click += new System.EventHandler(this.DecryptUnknownKey_Click);
            // 
            // inputKnownLetters
            // 
            this.inputKnownLetters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputKnownLetters.Location = new System.Drawing.Point(9, 206);
            this.inputKnownLetters.Name = "inputKnownLetters";
            this.inputKnownLetters.Size = new System.Drawing.Size(664, 20);
            this.inputKnownLetters.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Known letter combination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Number of blank spaces";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Max key length";
            // 
            // inputEncryptedMessage
            // 
            this.inputEncryptedMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEncryptedMessage.Location = new System.Drawing.Point(9, 32);
            this.inputEncryptedMessage.Name = "inputEncryptedMessage";
            this.inputEncryptedMessage.Size = new System.Drawing.Size(664, 20);
            this.inputEncryptedMessage.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Secret message";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(694, 617);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableMessageKey);
            this.groupBox3.Controls.Add(this.inputBlankSpaces);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.buttonDecryptDictionary);
            this.groupBox3.Controls.Add(this.knownLettersDict);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.inputSecretMessage);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 614);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decode with dictionary";
            // 
            // tableMessageKey
            // 
            this.tableMessageKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMessageKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableMessageKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMessageKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.message,
            this.key});
            this.tableMessageKey.Location = new System.Drawing.Point(9, 238);
            this.tableMessageKey.Name = "tableMessageKey";
            this.tableMessageKey.Size = new System.Drawing.Size(676, 370);
            this.tableMessageKey.TabIndex = 26;
            // 
            // message
            // 
            this.message.FillWeight = 200F;
            this.message.HeaderText = "Decrypted message";
            this.message.Name = "message";
            // 
            // key
            // 
            this.key.HeaderText = "Key";
            this.key.Name = "key";
            // 
            // inputBlankSpaces
            // 
            this.inputBlankSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBlankSpaces.Location = new System.Drawing.Point(9, 92);
            this.inputBlankSpaces.Name = "inputBlankSpaces";
            this.inputBlankSpaces.Size = new System.Drawing.Size(676, 20);
            this.inputBlankSpaces.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Decrypted word";
            // 
            // buttonDecryptDictionary
            // 
            this.buttonDecryptDictionary.Location = new System.Drawing.Point(9, 178);
            this.buttonDecryptDictionary.Name = "buttonDecryptDictionary";
            this.buttonDecryptDictionary.Size = new System.Drawing.Size(75, 23);
            this.buttonDecryptDictionary.TabIndex = 21;
            this.buttonDecryptDictionary.Text = "Decrypt";
            this.buttonDecryptDictionary.UseVisualStyleBackColor = true;
            this.buttonDecryptDictionary.Click += new System.EventHandler(this.decryptDict_Click);
            // 
            // knownLettersDict
            // 
            this.knownLettersDict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.knownLettersDict.Location = new System.Drawing.Point(9, 152);
            this.knownLettersDict.Name = "knownLettersDict";
            this.knownLettersDict.Size = new System.Drawing.Size(676, 20);
            this.knownLettersDict.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Known letter combination";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Number of black spaces";
            // 
            // inputSecretMessage
            // 
            this.inputSecretMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSecretMessage.Location = new System.Drawing.Point(9, 32);
            this.inputSecretMessage.Name = "inputSecretMessage";
            this.inputSecretMessage.Size = new System.Drawing.Size(676, 20);
            this.inputSecretMessage.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Secret message";
            // 
            // inputBlankSpace
            // 
            this.inputBlankSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBlankSpace.Location = new System.Drawing.Point(9, 145);
            this.inputBlankSpace.Name = "inputBlankSpace";
            this.inputBlankSpace.Size = new System.Drawing.Size(664, 20);
            this.inputBlankSpace.TabIndex = 27;
            // 
            // tableMessageUnknownKey
            // 
            this.tableMessageUnknownKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMessageUnknownKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableMessageUnknownKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMessageUnknownKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableMessageUnknownKey.Location = new System.Drawing.Point(6, 279);
            this.tableMessageUnknownKey.Name = "tableMessageUnknownKey";
            this.tableMessageUnknownKey.Size = new System.Drawing.Size(676, 335);
            this.tableMessageUnknownKey.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Decrypted message";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Key";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 643);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Vigenere chiper ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputKeyLength)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMessageKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBlankSpaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBlankSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMessageUnknownKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputMessage;
        private System.Windows.Forms.TextBox inputKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox outputEncryptedMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDecryptUnknownKey;
        private System.Windows.Forms.TextBox inputKnownLetters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputEncryptedMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDecryptDictionary;
        private System.Windows.Forms.TextBox knownLettersDict;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inputSecretMessage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown inputBlankSpaces;
        private System.Windows.Forms.DataGridView tableMessageKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.CheckBox constantLength;
        private System.Windows.Forms.NumericUpDown inputKeyLength;
        private System.Windows.Forms.NumericUpDown inputBlankSpace;
        private System.Windows.Forms.DataGridView tableMessageUnknownKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

