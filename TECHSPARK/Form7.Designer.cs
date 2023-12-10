namespace TECHSPARK
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            richTextBoxFeedback = new RichTextBox();
            btnSubmitFeedback = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBoxFeedback
            // 
            richTextBoxFeedback.BackColor = SystemColors.InactiveCaption;
            richTextBoxFeedback.BorderStyle = BorderStyle.None;
            richTextBoxFeedback.Location = new Point(76, 238);
            richTextBoxFeedback.Name = "richTextBoxFeedback";
            richTextBoxFeedback.Size = new Size(254, 113);
            richTextBoxFeedback.TabIndex = 0;
            richTextBoxFeedback.Text = "";
            // 
            // btnSubmitFeedback
            // 
            btnSubmitFeedback.BackColor = Color.Transparent;
            btnSubmitFeedback.FlatStyle = FlatStyle.Flat;
            btnSubmitFeedback.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmitFeedback.Location = new Point(161, 357);
            btnSubmitFeedback.Name = "btnSubmitFeedback";
            btnSubmitFeedback.Size = new Size(75, 27);
            btnSubmitFeedback.TabIndex = 1;
            btnSubmitFeedback.Text = "Submit";
            btnSubmitFeedback.UseVisualStyleBackColor = false;
            btnSubmitFeedback.Click += btnSubmitFeedback_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(59, 102);
            label1.Name = "label1";
            label1.Size = new Size(283, 33);
            label1.TabIndex = 2;
            label1.Text = "How's your experience?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(85, 146);
            label2.Name = "label2";
            label2.Size = new Size(231, 24);
            label2.TabIndex = 3;
            label2.Text = "Leave us a comment!";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.out_SDXL_1701790267_sczn2__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(388, 411);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmitFeedback);
            Controls.Add(richTextBoxFeedback);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "Feedback";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxFeedback;
        private Button btnSubmitFeedback;
        private Label label1;
        private Label label2;
    }
}