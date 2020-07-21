namespace RS232
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Speaker = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PowerSwitch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sowWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Speaker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Subwoofer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Preamplifier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Mixer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Fan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Extra = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Subwoofer = new System.Windows.Forms.Button();
            this.btn_Mixer = new System.Windows.Forms.Button();
            this.btn_Preamplifier = new System.Windows.Forms.Button();
            this.btn_Fan = new System.Windows.Forms.Button();
            this.btn_Extra = new System.Windows.Forms.Button();
            this.btn_Resend = new System.Windows.Forms.Button();
            this.PowerSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Speaker
            // 
            this.btn_Speaker.Enabled = false;
            this.btn_Speaker.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Speaker.Location = new System.Drawing.Point(16, 40);
            this.btn_Speaker.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Speaker.Name = "btn_Speaker";
            this.btn_Speaker.Size = new System.Drawing.Size(105, 62);
            this.btn_Speaker.TabIndex = 0;
            this.btn_Speaker.Tag = "Speaker";
            this.btn_Speaker.Text = "Speaker";
            this.btn_Speaker.UseVisualStyleBackColor = true;
            this.btn_Speaker.Click += new System.EventHandler(this.btn_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.Status.Location = new System.Drawing.Point(19, 9);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(123, 23);
            this.Status.TabIndex = 1;
            this.Status.Text = "RS232 Status : ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.PowerSwitch;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PowerSwitch";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // PowerSwitch
            // 
            this.PowerSwitch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sowWindowToolStripMenuItem,
            this.tsm_Speaker,
            this.tsm_Subwoofer,
            this.tsm_Preamplifier,
            this.tsm_Mixer,
            this.tsm_Fan,
            this.tsm_Extra,
            this.exitToolStripMenuItem});
            this.PowerSwitch.Name = "PowerSwitch";
            this.PowerSwitch.Size = new System.Drawing.Size(156, 180);
            // 
            // sowWindowToolStripMenuItem
            // 
            this.sowWindowToolStripMenuItem.Name = "sowWindowToolStripMenuItem";
            this.sowWindowToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sowWindowToolStripMenuItem.Text = "Show Window";
            this.sowWindowToolStripMenuItem.Click += new System.EventHandler(this.sowWindowToolStripMenuItem_Click);
            // 
            // tsm_Speaker
            // 
            this.tsm_Speaker.Enabled = false;
            this.tsm_Speaker.Name = "tsm_Speaker";
            this.tsm_Speaker.Size = new System.Drawing.Size(155, 22);
            this.tsm_Speaker.Tag = "Speaker";
            this.tsm_Speaker.Text = "Speaker";
            this.tsm_Speaker.Click += new System.EventHandler(this.btn_Click);
            // 
            // tsm_Subwoofer
            // 
            this.tsm_Subwoofer.Enabled = false;
            this.tsm_Subwoofer.Name = "tsm_Subwoofer";
            this.tsm_Subwoofer.Size = new System.Drawing.Size(155, 22);
            this.tsm_Subwoofer.Tag = "Subwoofer";
            this.tsm_Subwoofer.Text = "Subwoofer";
            this.tsm_Subwoofer.Click += new System.EventHandler(this.btn_Click);
            // 
            // tsm_Preamplifier
            // 
            this.tsm_Preamplifier.Enabled = false;
            this.tsm_Preamplifier.Name = "tsm_Preamplifier";
            this.tsm_Preamplifier.Size = new System.Drawing.Size(155, 22);
            this.tsm_Preamplifier.Tag = "Preamplifier";
            this.tsm_Preamplifier.Text = "Preamplifier";
            this.tsm_Preamplifier.Click += new System.EventHandler(this.btn_Click);
            // 
            // tsm_Mixer
            // 
            this.tsm_Mixer.Enabled = false;
            this.tsm_Mixer.Name = "tsm_Mixer";
            this.tsm_Mixer.Size = new System.Drawing.Size(155, 22);
            this.tsm_Mixer.Tag = "Mixer";
            this.tsm_Mixer.Text = "Mixer";
            this.tsm_Mixer.Click += new System.EventHandler(this.btn_Click);
            // 
            // tsm_Fan
            // 
            this.tsm_Fan.Enabled = false;
            this.tsm_Fan.Name = "tsm_Fan";
            this.tsm_Fan.Size = new System.Drawing.Size(155, 22);
            this.tsm_Fan.Text = "Fan";
            // 
            // tsm_Extra
            // 
            this.tsm_Extra.Enabled = false;
            this.tsm_Extra.Name = "tsm_Extra";
            this.tsm_Extra.Size = new System.Drawing.Size(155, 22);
            this.tsm_Extra.Text = "Extra";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_Subwoofer
            // 
            this.btn_Subwoofer.Enabled = false;
            this.btn_Subwoofer.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Subwoofer.Location = new System.Drawing.Point(135, 40);
            this.btn_Subwoofer.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Subwoofer.Name = "btn_Subwoofer";
            this.btn_Subwoofer.Size = new System.Drawing.Size(105, 62);
            this.btn_Subwoofer.TabIndex = 0;
            this.btn_Subwoofer.Tag = "Subwoofer";
            this.btn_Subwoofer.Text = "Subwoofer";
            this.btn_Subwoofer.UseVisualStyleBackColor = true;
            this.btn_Subwoofer.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Mixer
            // 
            this.btn_Mixer.Enabled = false;
            this.btn_Mixer.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Mixer.Location = new System.Drawing.Point(135, 124);
            this.btn_Mixer.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Mixer.Name = "btn_Mixer";
            this.btn_Mixer.Size = new System.Drawing.Size(105, 62);
            this.btn_Mixer.TabIndex = 0;
            this.btn_Mixer.Tag = "Mixer";
            this.btn_Mixer.Text = "Mixer";
            this.btn_Mixer.UseVisualStyleBackColor = true;
            this.btn_Mixer.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Preamplifier
            // 
            this.btn_Preamplifier.Enabled = false;
            this.btn_Preamplifier.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Preamplifier.Location = new System.Drawing.Point(14, 124);
            this.btn_Preamplifier.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Preamplifier.Name = "btn_Preamplifier";
            this.btn_Preamplifier.Size = new System.Drawing.Size(105, 62);
            this.btn_Preamplifier.TabIndex = 0;
            this.btn_Preamplifier.Tag = "Preamplifier";
            this.btn_Preamplifier.Text = "Preamplifier";
            this.btn_Preamplifier.UseVisualStyleBackColor = true;
            this.btn_Preamplifier.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Fan
            // 
            this.btn_Fan.Enabled = false;
            this.btn_Fan.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Fan.Location = new System.Drawing.Point(254, 40);
            this.btn_Fan.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Fan.Name = "btn_Fan";
            this.btn_Fan.Size = new System.Drawing.Size(105, 62);
            this.btn_Fan.TabIndex = 0;
            this.btn_Fan.Tag = "Fan";
            this.btn_Fan.Text = "Fan";
            this.btn_Fan.UseVisualStyleBackColor = true;
            this.btn_Fan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Extra
            // 
            this.btn_Extra.Enabled = false;
            this.btn_Extra.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Extra.Location = new System.Drawing.Point(254, 124);
            this.btn_Extra.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Extra.Name = "btn_Extra";
            this.btn_Extra.Size = new System.Drawing.Size(105, 62);
            this.btn_Extra.TabIndex = 0;
            this.btn_Extra.Tag = "Extra";
            this.btn_Extra.Text = "Extra";
            this.btn_Extra.UseVisualStyleBackColor = true;
            this.btn_Extra.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Resend
            // 
            this.btn_Resend.Enabled = false;
            this.btn_Resend.Location = new System.Drawing.Point(254, 9);
            this.btn_Resend.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Resend.Name = "btn_Resend";
            this.btn_Resend.Size = new System.Drawing.Size(105, 22);
            this.btn_Resend.TabIndex = 0;
            this.btn_Resend.Tag = "Resend";
            this.btn_Resend.Text = "Resend";
            this.btn_Resend.UseVisualStyleBackColor = true;
            this.btn_Resend.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(374, 201);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.btn_Extra);
            this.Controls.Add(this.btn_Mixer);
            this.Controls.Add(this.btn_Fan);
            this.Controls.Add(this.btn_Subwoofer);
            this.Controls.Add(this.btn_Preamplifier);
            this.Controls.Add(this.btn_Resend);
            this.Controls.Add(this.btn_Speaker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(390, 240);
            this.MinimumSize = new System.Drawing.Size(390, 240);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RS232 Power Switch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PowerSwitch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Speaker;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip PowerSwitch;
        private System.Windows.Forms.ToolStripMenuItem tsm_Speaker;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sowWindowToolStripMenuItem;
        private System.Windows.Forms.Button btn_Subwoofer;
        private System.Windows.Forms.Button btn_Mixer;
        private System.Windows.Forms.Button btn_Preamplifier;
        private System.Windows.Forms.ToolStripMenuItem tsm_Mixer;
        private System.Windows.Forms.ToolStripMenuItem tsm_Subwoofer;
        private System.Windows.Forms.ToolStripMenuItem tsm_Preamplifier;
        private System.Windows.Forms.Button btn_Fan;
        private System.Windows.Forms.Button btn_Extra;
        private System.Windows.Forms.ToolStripMenuItem tsm_Extra;
        private System.Windows.Forms.ToolStripMenuItem tsm_Fan;
        private System.Windows.Forms.Button btn_Resend;
    }
}

