namespace Plugable3900Tester
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
            if (disposing && (components != null)) {
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.countdownTimerText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVLC = new System.Windows.Forms.TextBox();
            this.textBoxChrome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYoutube = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(38, 151);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start Test";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // countdownTimerText
            // 
            this.countdownTimerText.AutoSize = true;
            this.countdownTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownTimerText.Location = new System.Drawing.Point(72, 197);
            this.countdownTimerText.Name = "countdownTimerText";
            this.countdownTimerText.Size = new System.Drawing.Size(96, 25);
            this.countdownTimerText.TabIndex = 3;
            this.countdownTimerText.Text = "10:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VLC:";
            // 
            // textBoxVLC
            // 
            this.textBoxVLC.Location = new System.Drawing.Point(66, 13);
            this.textBoxVLC.Name = "textBoxVLC";
            this.textBoxVLC.Size = new System.Drawing.Size(206, 20);
            this.textBoxVLC.TabIndex = 5;
            // 
            // textBoxChrome
            // 
            this.textBoxChrome.Location = new System.Drawing.Point(66, 40);
            this.textBoxChrome.Name = "textBoxChrome";
            this.textBoxChrome.Size = new System.Drawing.Size(206, 20);
            this.textBoxChrome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chrome:";
            // 
            // textBoxYoutube
            // 
            this.textBoxYoutube.Location = new System.Drawing.Point(66, 69);
            this.textBoxYoutube.Name = "textBoxYoutube";
            this.textBoxYoutube.Size = new System.Drawing.Size(206, 20);
            this.textBoxYoutube.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Youtube:";
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(66, 98);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(206, 20);
            this.textBoxVideo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Video:";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(120, 151);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 12;
            this.buttonStop.Text = "Stop Test";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.textBoxVideo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxYoutube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxChrome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVLC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countdownTimerText);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Plugable 3900 Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label countdownTimerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVLC;
        private System.Windows.Forms.TextBox textBoxChrome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYoutube;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVideo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStop;
    }
}

