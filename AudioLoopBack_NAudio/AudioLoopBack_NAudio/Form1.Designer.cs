namespace AudioLoopBack_NAudio
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sourceList = new System.Windows.Forms.ListView();
            this.Devices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Channels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sourceList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(548, 211);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // sourceList
            // 
            this.sourceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Devices,
            this.Channels});
            this.sourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceList.Location = new System.Drawing.Point(0, 0);
            this.sourceList.MultiSelect = false;
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(283, 211);
            this.sourceList.TabIndex = 0;
            this.sourceList.UseCompatibleStateImageBehavior = false;
            this.sourceList.View = System.Windows.Forms.View.Details;
            // 
            // Devices
            // 
            this.Devices.Text = "Devices";
            this.Devices.Width = 160;
            // 
            // Channels
            // 
            this.Channels.Text = "Channels";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh Sources";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "To WAV File";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 211);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Audio LoopBack";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView sourceList;
        private System.Windows.Forms.ColumnHeader Devices;
        private System.Windows.Forms.ColumnHeader Channels;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}

