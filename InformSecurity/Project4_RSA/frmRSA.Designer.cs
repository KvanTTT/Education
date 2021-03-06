﻿namespace Project4_RSA
{
    partial class frmRSA
    {
        /// <summary>
        /// Required RSAigner variable.
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

        #region Windows Form RSAigner generated code

        /// <summary>
        /// Required method for RSAigner support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbDecodeFile = new System.Windows.Forms.TextBox();
            this.tbEncodeFile = new System.Windows.Forms.TextBox();
            this.tbSorceFile = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRandSeed = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbModule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKey2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKey1 = new System.Windows.Forms.TextBox();
            this.ofdKey = new System.Windows.Forms.OpenFileDialog();
            this.sfdKey = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEncodeTime = new System.Windows.Forms.TextBox();
            this.tbDecodeTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.tbDecodeFile);
            this.groupBox1.Controls.Add(this.tbEncodeFile);
            this.groupBox1.Controls.Add(this.tbSorceFile);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCrypt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 213);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифрование файла";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(361, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(361, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbDecodeFile
            // 
            this.tbDecodeFile.Location = new System.Drawing.Point(154, 88);
            this.tbDecodeFile.Name = "tbDecodeFile";
            this.tbDecodeFile.Size = new System.Drawing.Size(207, 20);
            this.tbDecodeFile.TabIndex = 24;
            this.tbDecodeFile.Text = "../../Data/Палиндромы (decode).png";
            // 
            // tbEncodeFile
            // 
            this.tbEncodeFile.Location = new System.Drawing.Point(154, 62);
            this.tbEncodeFile.Name = "tbEncodeFile";
            this.tbEncodeFile.Size = new System.Drawing.Size(207, 20);
            this.tbEncodeFile.TabIndex = 23;
            this.tbEncodeFile.Text = "../../Data/Палиндромы.txt.encode";
            // 
            // tbSorceFile
            // 
            this.tbSorceFile.Location = new System.Drawing.Point(154, 36);
            this.tbSorceFile.Name = "tbSorceFile";
            this.tbSorceFile.Size = new System.Drawing.Size(207, 20);
            this.tbSorceFile.TabIndex = 22;
            this.tbSorceFile.Text = "../../Data/Палиндромы.txt";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.PeachPuff;
            this.button9.ForeColor = System.Drawing.Color.BurlyWood;
            this.button9.Location = new System.Drawing.Point(174, 130);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 18);
            this.button9.TabIndex = 21;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 29);
            this.button4.TabIndex = 20;
            this.button4.Text = "Открыть папку с файлами";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(203, 124);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(149, 29);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Расшифровать файл";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Расшифрованный файл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Зашифрованный файл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходный файл";
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(21, 124);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(149, 29);
            this.btnCrypt.TabIndex = 10;
            this.btnCrypt.Text = "Зашифровать файл";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 33);
            this.button3.TabIndex = 31;
            this.button3.Text = "Загрузить ключ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Сохранить ключ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRandSeed
            // 
            this.btnRandSeed.Location = new System.Drawing.Point(20, 156);
            this.btnRandSeed.Name = "btnRandSeed";
            this.btnRandSeed.Size = new System.Drawing.Size(221, 32);
            this.btnRandSeed.TabIndex = 29;
            this.btnRandSeed.Text = "Сгенерировать ключи";
            this.btnRandSeed.UseVisualStyleBackColor = true;
            this.btnRandSeed.Click += new System.EventHandler(this.btnRandSeed_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbModule);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbKey2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbKey1);
            this.groupBox2.Controls.Add(this.btnRandSeed);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(426, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 276);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Module";
            // 
            // tbModule
            // 
            this.tbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModule.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbModule.Location = new System.Drawing.Point(76, 90);
            this.tbModule.Name = "tbModule";
            this.tbModule.Size = new System.Drawing.Size(165, 21);
            this.tbModule.TabIndex = 36;
            this.tbModule.Text = "8266495969185860038";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Private Key";
            // 
            // tbKey2
            // 
            this.tbKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbKey2.Location = new System.Drawing.Point(76, 63);
            this.tbKey2.Name = "tbKey2";
            this.tbKey2.Size = new System.Drawing.Size(165, 21);
            this.tbKey2.TabIndex = 34;
            this.tbKey2.Text = "8266495969185860038";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Open key";
            // 
            // tbKey1
            // 
            this.tbKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbKey1.Location = new System.Drawing.Point(76, 36);
            this.tbKey1.Name = "tbKey1";
            this.tbKey1.Size = new System.Drawing.Size(165, 21);
            this.tbKey1.TabIndex = 32;
            this.tbKey1.Text = "8266495969185860038";
            this.tbKey1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKey_KeyPress);
            // 
            // ofdKey
            // 
            this.ofdKey.FileName = "openFileDialog2";
            this.ofdKey.Filter = "RSA key (*.key)|*.key|All files (*.*)|*.*";
            this.ofdKey.RestoreDirectory = true;
            this.ofdKey.Title = "Выберите файл ключа";
            // 
            // sfdKey
            // 
            this.sfdKey.Filter = "RSA key (*.key)|*.key|All files (*.*)|*.*";
            this.sfdKey.Title = "Введите имя ключа";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Выберите файл ключа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Время шифрования";
            // 
            // tbEncodeTime
            // 
            this.tbEncodeTime.Location = new System.Drawing.Point(173, 242);
            this.tbEncodeTime.Name = "tbEncodeTime";
            this.tbEncodeTime.ReadOnly = true;
            this.tbEncodeTime.Size = new System.Drawing.Size(143, 20);
            this.tbEncodeTime.TabIndex = 34;
            // 
            // tbDecodeTime
            // 
            this.tbDecodeTime.Location = new System.Drawing.Point(173, 268);
            this.tbDecodeTime.Name = "tbDecodeTime";
            this.tbDecodeTime.ReadOnly = true;
            this.tbDecodeTime.Size = new System.Drawing.Size(143, 20);
            this.tbDecodeTime.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Время расшифрования";
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 306);
            this.Controls.Add(this.tbDecodeTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEncodeTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRSA";
            this.Load += new System.EventHandler(this.frmRSA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRandSeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbKey1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbDecodeFile;
        private System.Windows.Forms.TextBox tbEncodeFile;
        private System.Windows.Forms.TextBox tbSorceFile;
        private System.Windows.Forms.OpenFileDialog ofdKey;
        private System.Windows.Forms.SaveFileDialog sfdKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEncodeTime;
        private System.Windows.Forms.TextBox tbDecodeTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbModule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKey2;
        private System.Windows.Forms.Label label4;
    }
}

