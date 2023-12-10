namespace TECHSPARK
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            progressBar1 = new ProgressBar();
            btnUser = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 408);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(585, 10);
            progressBar1.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ButtonShadow;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Location = new Point(104, 245);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(79, 40);
            btnUser.TabIndex = 1;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ButtonShadow;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(382, 245);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(82, 40);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.out_SDXL_1701596738_kzt94;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(578, 417);
            Controls.Add(btnAdmin);
            Controls.Add(btnUser);
            Controls.Add(progressBar1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "TecsPark";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btnUser;
        private Button btnAdmin;
    }
}