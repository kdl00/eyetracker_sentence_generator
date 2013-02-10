namespace eyetracker_sentence_generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseSentences = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseImageMagick = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackgroundGenerate = new System.Windows.Forms.Button();
            this.txtBackgroundColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBackgroundWidth = new System.Windows.Forms.TextBox();
            this.txtBackgroundHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtImageMagickFolder = new System.Windows.Forms.TextBox();
            this.txtSentencesFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTextboxBackgroundColor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFontColor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTextboxHeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTextboxWidth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGenerateSentences = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.cbAdvancedMode = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBinary = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place all sentences in a text file, one sentence per line.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sentences File:";
            // 
            // btnBrowseSentences
            // 
            this.btnBrowseSentences.Location = new System.Drawing.Point(569, 47);
            this.btnBrowseSentences.Name = "btnBrowseSentences";
            this.btnBrowseSentences.Size = new System.Drawing.Size(63, 23);
            this.btnBrowseSentences.TabIndex = 16;
            this.btnBrowseSentences.Text = "Browse";
            this.btnBrowseSentences.UseVisualStyleBackColor = true;
            this.btnBrowseSentences.Click += new System.EventHandler(this.btnBrowseSentences_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ImageMagick Folder:";
            // 
            // btnBrowseImageMagick
            // 
            this.btnBrowseImageMagick.Location = new System.Drawing.Point(572, 4);
            this.btnBrowseImageMagick.Name = "btnBrowseImageMagick";
            this.btnBrowseImageMagick.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImageMagick.TabIndex = 1;
            this.btnBrowseImageMagick.Text = "Browse";
            this.btnBrowseImageMagick.UseVisualStyleBackColor = true;
            this.btnBrowseImageMagick.Click += new System.EventHandler(this.btnBrowseImageMagick_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackgroundGenerate);
            this.groupBox1.Controls.Add(this.txtBackgroundColor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBackgroundWidth);
            this.groupBox1.Controls.Add(this.txtBackgroundHeight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Background";
            // 
            // btnBackgroundGenerate
            // 
            this.btnBackgroundGenerate.Location = new System.Drawing.Point(558, 55);
            this.btnBackgroundGenerate.Name = "btnBackgroundGenerate";
            this.btnBackgroundGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnBackgroundGenerate.TabIndex = 13;
            this.btnBackgroundGenerate.Text = "Generate";
            this.btnBackgroundGenerate.UseVisualStyleBackColor = true;
            this.btnBackgroundGenerate.Click += new System.EventHandler(this.btnBackgroundGenerate_Click);
            // 
            // txtBackgroundColor
            // 
            this.txtBackgroundColor.Location = new System.Drawing.Point(432, 17);
            this.txtBackgroundColor.Name = "txtBackgroundColor";
            this.txtBackgroundColor.Size = new System.Drawing.Size(100, 20);
            this.txtBackgroundColor.TabIndex = 10;
            this.txtBackgroundColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBackgroundColor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Background Color (ex. lightblue):";
            // 
            // txtBackgroundWidth
            // 
            this.txtBackgroundWidth.Location = new System.Drawing.Point(99, 21);
            this.txtBackgroundWidth.Name = "txtBackgroundWidth";
            this.txtBackgroundWidth.Size = new System.Drawing.Size(100, 20);
            this.txtBackgroundWidth.TabIndex = 4;
            this.txtBackgroundWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtBackgroundHeight
            // 
            this.txtBackgroundHeight.Location = new System.Drawing.Point(99, 50);
            this.txtBackgroundHeight.Name = "txtBackgroundHeight";
            this.txtBackgroundHeight.Size = new System.Drawing.Size(100, 20);
            this.txtBackgroundHeight.TabIndex = 7;
            this.txtBackgroundHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Width (in pixels):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Height (in pixels):";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(663, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // txtImageMagickFolder
            // 
            this.txtImageMagickFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eyetracker_sentence_generator.Properties.Settings.Default, "ImageMagickFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtImageMagickFolder.Location = new System.Drawing.Point(124, 6);
            this.txtImageMagickFolder.Name = "txtImageMagickFolder";
            this.txtImageMagickFolder.ReadOnly = true;
            this.txtImageMagickFolder.Size = new System.Drawing.Size(442, 20);
            this.txtImageMagickFolder.TabIndex = 5;
            this.txtImageMagickFolder.TabStop = false;
            this.txtImageMagickFolder.Text = global::eyetracker_sentence_generator.Properties.Settings.Default.ImageMagickFolder;
            // 
            // txtSentencesFile
            // 
            this.txtSentencesFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::eyetracker_sentence_generator.Properties.Settings.Default, "SentencesFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSentencesFile.Location = new System.Drawing.Point(95, 49);
            this.txtSentencesFile.Name = "txtSentencesFile";
            this.txtSentencesFile.ReadOnly = true;
            this.txtSentencesFile.Size = new System.Drawing.Size(468, 20);
            this.txtSentencesFile.TabIndex = 2;
            this.txtSentencesFile.TabStop = false;
            this.txtSentencesFile.Text = global::eyetracker_sentence_generator.Properties.Settings.Default.SentencesFile;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTextboxBackgroundColor);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtFontColor);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTextboxHeight);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTextboxWidth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnGenerateSentences);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFontSize);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbFonts);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSentencesFile);
            this.groupBox2.Controls.Add(this.btnBrowseSentences);
            this.groupBox2.Location = new System.Drawing.Point(13, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 159);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Sentences";
            // 
            // txtTextboxBackgroundColor
            // 
            this.txtTextboxBackgroundColor.Location = new System.Drawing.Point(431, 132);
            this.txtTextboxBackgroundColor.Name = "txtTextboxBackgroundColor";
            this.txtTextboxBackgroundColor.Size = new System.Drawing.Size(100, 20);
            this.txtTextboxBackgroundColor.TabIndex = 30;
            this.txtTextboxBackgroundColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBackgroundColor_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Background Color:";
            // 
            // txtFontColor
            // 
            this.txtFontColor.Location = new System.Drawing.Point(95, 128);
            this.txtFontColor.Name = "txtFontColor";
            this.txtFontColor.Size = new System.Drawing.Size(100, 20);
            this.txtFontColor.TabIndex = 23;
            this.txtFontColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBackgroundColor_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Font color:";
            // 
            // txtTextboxHeight
            // 
            this.txtTextboxHeight.Location = new System.Drawing.Point(431, 105);
            this.txtTextboxHeight.Name = "txtTextboxHeight";
            this.txtTextboxHeight.Size = new System.Drawing.Size(100, 20);
            this.txtTextboxHeight.TabIndex = 29;
            this.txtTextboxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(384, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Height:";
            // 
            // txtTextboxWidth
            // 
            this.txtTextboxWidth.Location = new System.Drawing.Point(431, 75);
            this.txtTextboxWidth.Name = "txtTextboxWidth";
            this.txtTextboxWidth.Size = new System.Drawing.Size(100, 20);
            this.txtTextboxWidth.TabIndex = 26;
            this.txtTextboxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(387, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Width:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Textbox Size:";
            // 
            // btnGenerateSentences
            // 
            this.btnGenerateSentences.Location = new System.Drawing.Point(559, 130);
            this.btnGenerateSentences.Name = "btnGenerateSentences";
            this.btnGenerateSentences.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSentences.TabIndex = 32;
            this.btnGenerateSentences.Text = "Generate";
            this.btnGenerateSentences.UseVisualStyleBackColor = true;
            this.btnGenerateSentences.Click += new System.EventHandler(this.btnGenerateSentences_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Font size:";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(95, 102);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(100, 20);
            this.txtFontSize.TabIndex = 20;
            this.txtFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Font:";
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(95, 75);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(184, 21);
            this.cbFonts.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRun);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCommandLine);
            this.groupBox3.Controls.Add(this.cbAdvancedMode);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbBinary);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 228);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Advanced Mode";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(558, 49);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 45;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Command line options:";
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(9, 101);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(624, 121);
            this.txtCommandLine.TabIndex = 41;
            // 
            // cbAdvancedMode
            // 
            this.cbAdvancedMode.AutoSize = true;
            this.cbAdvancedMode.Location = new System.Drawing.Point(16, 19);
            this.cbAdvancedMode.Name = "cbAdvancedMode";
            this.cbAdvancedMode.Size = new System.Drawing.Size(139, 17);
            this.cbAdvancedMode.TabIndex = 35;
            this.cbAdvancedMode.Text = "Enable advanced mode";
            this.cbAdvancedMode.UseVisualStyleBackColor = true;
            this.cbAdvancedMode.CheckedChanged += new System.EventHandler(this.cbAdvancedMode_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Binary:";
            // 
            // cbBinary
            // 
            this.cbBinary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBinary.FormattingEnabled = true;
            this.cbBinary.Location = new System.Drawing.Point(55, 51);
            this.cbBinary.Name = "cbBinary";
            this.cbBinary.Size = new System.Drawing.Size(198, 21);
            this.cbBinary.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(663, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowseImageMagick);
            this.Controls.Add(this.txtImageMagickFolder);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sentence Image Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSentencesFile;
        private System.Windows.Forms.Button btnBrowseSentences;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImageMagickFolder;
        private System.Windows.Forms.Button btnBrowseImageMagick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBackgroundWidth;
        private System.Windows.Forms.TextBox txtBackgroundHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnBackgroundGenerate;
        private System.Windows.Forms.TextBox txtBackgroundColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.Button btnGenerateSentences;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.CheckBox cbAdvancedMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBinary;
        private System.Windows.Forms.TextBox txtTextboxHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTextboxWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFontColor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTextboxBackgroundColor;
        private System.Windows.Forms.Label label15;
    }
}

