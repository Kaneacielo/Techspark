namespace TECHSPARK
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.ForestGreen;
            panel7.Location = new Point(409, 283);
            panel7.Name = "panel7";
            panel7.Size = new Size(73, 88);
            panel7.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.BackColor = Color.ForestGreen;
            panel6.Location = new Point(293, 282);
            panel6.Name = "panel6";
            panel6.Size = new Size(71, 89);
            panel6.TabIndex = 27;
            // 
            // panel5
            // 
            panel5.BackColor = Color.ForestGreen;
            panel5.Location = new Point(160, 283);
            panel5.Name = "panel5";
            panel5.Size = new Size(74, 88);
            panel5.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Location = new Point(411, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(70, 86);
            panel3.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Location = new Point(291, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(71, 83);
            panel2.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.ForestGreen;
            panel1.Location = new Point(162, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 86);
            panel1.TabIndex = 22;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.out_SDXL_1701595362_d9al9;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(758, 473);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form6";
            Text = "User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
    }
}