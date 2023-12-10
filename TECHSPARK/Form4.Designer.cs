namespace TECHSPARK
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            menuStrip1 = new MenuStrip();
            historyToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            feedbackToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { historyToolStripMenuItem, logoutToolStripMenuItem, feedbackToolStripMenuItem });
            menuStrip1.Location = new Point(531, -1);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(329, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(59, 21);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(62, 21);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // feedbackToolStripMenuItem
            // 
            feedbackToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            feedbackToolStripMenuItem.Size = new Size(80, 21);
            feedbackToolStripMenuItem.Text = "Feedback";
            feedbackToolStripMenuItem.Click += feedbackToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(160, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(63, 82);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Location = new Point(284, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 82);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Location = new Point(401, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(62, 82);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Location = new Point(157, 307);
            panel4.Name = "panel4";
            panel4.Size = new Size(62, 85);
            panel4.TabIndex = 19;
            // 
            // panel5
            // 
            panel5.BackColor = Color.ForestGreen;
            panel5.Location = new Point(286, 307);
            panel5.Name = "panel5";
            panel5.Size = new Size(68, 85);
            panel5.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.BackColor = Color.ForestGreen;
            panel6.Location = new Point(400, 307);
            panel6.Name = "panel6";
            panel6.Size = new Size(66, 85);
            panel6.TabIndex = 20;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.out_SDXL_1701595362_d9al9;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 499);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form4";
            Text = "Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private ToolStripMenuItem feedbackToolStripMenuItem;
    }
}