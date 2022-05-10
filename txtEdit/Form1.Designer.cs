namespace txtEdit
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
            this.rtbUpis = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnSaveas = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // rtbUpis
            // 
            this.rtbUpis.Location = new System.Drawing.Point(25, 46);
            this.rtbUpis.Name = "rtbUpis";
            this.rtbUpis.Size = new System.Drawing.Size(477, 377);
            this.rtbUpis.TabIndex = 0;
            this.rtbUpis.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(523, 219);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(248, 48);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(523, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(248, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(523, 46);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(51, 41);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(580, 46);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(58, 41);
            this.btnItalic.TabIndex = 4;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(644, 46);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(68, 41);
            this.btnUnderline.TabIndex = 5;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            // 
            // btnSaveas
            // 
            this.btnSaveas.Location = new System.Drawing.Point(523, 361);
            this.btnSaveas.Name = "btnSaveas";
            this.btnSaveas.Size = new System.Drawing.Size(248, 48);
            this.btnSaveas.TabIndex = 6;
            this.btnSaveas.Text = " SAVE AS";
            this.btnSaveas.UseVisualStyleBackColor = true;
            this.btnSaveas.Click += new System.EventHandler(this.btnSaveas_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 433);
            this.Controls.Add(this.btnSaveas);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.rtbUpis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUpis;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnSaveas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

