namespace TECHSPARK
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            dataGridViewFeedback = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFeedback
            // 
            dataGridViewFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeedback.Location = new Point(150, 88);
            dataGridViewFeedback.Name = "dataGridViewFeedback";
            dataGridViewFeedback.RowTemplate.Height = 25;
            dataGridViewFeedback.Size = new Size(492, 283);
            dataGridViewFeedback.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(299, 34);
            label1.Name = "label1";
            label1.Size = new Size(210, 33);
            label1.TabIndex = 1;
            label1.Text = "User Feedback";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.out_SDXL_1702010141_il5ap;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewFeedback);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            Text = "FEEDBACK";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFeedback;
        private Label label1;
    }
}