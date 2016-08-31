namespace EchoTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pauseMP3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open WAV File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(12, 55);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(260, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause/Play WAV File";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open MP3 File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pauseMP3Button
            // 
            this.pauseMP3Button.Enabled = false;
            this.pauseMP3Button.Location = new System.Drawing.Point(12, 142);
            this.pauseMP3Button.Name = "pauseMP3Button";
            this.pauseMP3Button.Size = new System.Drawing.Size(260, 23);
            this.pauseMP3Button.TabIndex = 3;
            this.pauseMP3Button.Text = "Pause/Play MP3 File";
            this.pauseMP3Button.UseVisualStyleBackColor = true;
            this.pauseMP3Button.Click += new System.EventHandler(this.pauseMP3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.pauseMP3Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Echo Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button pauseMP3Button;
    }
}

