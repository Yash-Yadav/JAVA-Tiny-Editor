namespace JAVA_IDE
{
    partial class JAVA_IDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JAVA_IDE));
            this.Compile_Run = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.downloadJDK = new System.Windows.Forms.LinkLabel();
            this.configPath = new System.Windows.Forms.LinkLabel();
            this.StripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveState = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Compile_Run
            // 
            this.Compile_Run.Location = new System.Drawing.Point(611, 29);
            this.Compile_Run.Name = "Compile_Run";
            this.Compile_Run.Size = new System.Drawing.Size(113, 40);
            this.Compile_Run.TabIndex = 0;
            this.Compile_Run.Text = "Compile and Run";
            this.Compile_Run.UseVisualStyleBackColor = true;
            this.Compile_Run.Click += new System.EventHandler(this.Compile_Run_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(611, 75);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(113, 40);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(12, 28);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Code.Size = new System.Drawing.Size(592, 326);
            this.Code.TabIndex = 7;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(12, 374);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(592, 240);
            this.Output.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "OUTPUT";
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(611, 167);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(113, 40);
            this.SaveAs.TabIndex = 3;
            this.SaveAs.Text = "SaveAs";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(611, 121);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(113, 40);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(611, 213);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 89);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // downloadJDK
            // 
            this.downloadJDK.AutoSize = true;
            this.downloadJDK.Location = new System.Drawing.Point(614, 384);
            this.downloadJDK.Name = "downloadJDK";
            this.downloadJDK.Size = new System.Drawing.Size(107, 13);
            this.downloadJDK.TabIndex = 5;
            this.downloadJDK.TabStop = true;
            this.downloadJDK.Text = "Download JAVA JDK";
            this.downloadJDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.downloadJDK_LinkClicked);
            // 
            // configPath
            // 
            this.configPath.AutoSize = true;
            this.configPath.Location = new System.Drawing.Point(618, 410);
            this.configPath.Name = "configPath";
            this.configPath.Size = new System.Drawing.Size(99, 13);
            this.configPath.TabIndex = 6;
            this.configPath.TabStop = true;
            this.configPath.Text = "Configure JDK path";
            this.configPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.configPath_LinkClicked);
            // 
            // StripLabel1
            // 
            this.StripLabel1.Name = "StripLabel1";
            this.StripLabel1.Size = new System.Drawing.Size(45, 17);
            this.StripLabel1.Text = "Status: ";
            // 
            // saveState
            // 
            this.saveState.Name = "saveState";
            this.saveState.Size = new System.Drawing.Size(18, 17);
            this.saveState.Text = " - ";
            // 
            // StripLabel2
            // 
            this.StripLabel2.Name = "StripLabel2";
            this.StripLabel2.Size = new System.Drawing.Size(68, 17);
            this.StripLabel2.Text = "Current File";
            // 
            // CurrentFile
            // 
            this.CurrentFile.Name = "CurrentFile";
            this.CurrentFile.Size = new System.Drawing.Size(18, 17);
            this.CurrentFile.Text = " - ";
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripLabel1,
            this.saveState,
            this.StripLabel2,
            this.CurrentFile});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(726, 22);
            this.statusStrip.TabIndex = 8;
            // 
            // JAVA_IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(726, 618);
            this.Controls.Add(this.configPath);
            this.Controls.Add(this.downloadJDK);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Compile_Run);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JAVA_IDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JAVA Tiny Editor";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Compile_Run;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.LinkLabel downloadJDK;
        private System.Windows.Forms.LinkLabel configPath;
        private System.Windows.Forms.ToolStripStatusLabel StripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel saveState;
        private System.Windows.Forms.ToolStripStatusLabel StripLabel2;
        private System.Windows.Forms.ToolStripStatusLabel CurrentFile;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}

