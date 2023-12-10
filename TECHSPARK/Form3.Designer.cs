namespace TECHSPARK
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(270, 289);
            label1.Name = "label1";
            label1.Size = new Size(113, 29);
            label1.TabIndex = 3;
            label1.Text = "   ENTER   ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Orange;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(218, 166);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 28);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Orange;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(218, 219);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(247, 28);
            textBox2.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 432);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "TECHSPARK - LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}