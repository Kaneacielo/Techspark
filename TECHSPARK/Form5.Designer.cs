namespace TECHSPARK
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label3 = new Label();
            dataGridViewHistory = new DataGridView();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtPlateNumber = new TextBox();
            txtSlotNumber = new TextBox();
            label4 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            txtDate = new TextBox();
            txtCheckoutTime = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnRetrieve = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 0;
            label1.Text = "History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(55, 81);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Plate Number";
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.BackgroundColor = Color.LightSkyBlue;
            dataGridViewHistory.BorderStyle = BorderStyle.None;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(241, 38);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowTemplate.Height = 25;
            dataGridViewHistory.Size = new Size(469, 261);
            dataGridViewHistory.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Orange;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Location = new Point(285, 359);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Orange;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(402, 359);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(512, 359);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(135, 77);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(100, 23);
            txtPlateNumber.TabIndex = 11;
            // 
            // txtSlotNumber
            // 
            txtSlotNumber.Location = new Point(135, 117);
            txtSlotNumber.Name = "txtSlotNumber";
            txtSlotNumber.Size = new Size(100, 23);
            txtSlotNumber.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(59, 121);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 13;
            label4.Text = "Slot Number";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(135, 196);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(100, 23);
            txtDate.TabIndex = 15;
            // 
            // txtCheckoutTime
            // 
            txtCheckoutTime.Location = new Point(135, 156);
            txtCheckoutTime.Name = "txtCheckoutTime";
            txtCheckoutTime.Size = new Size(100, 23);
            txtCheckoutTime.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(72, 159);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 17;
            label6.Text = "Check Out";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(103, 199);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 18;
            label7.Text = "Date";
            // 
            // btnRetrieve
            // 
            btnRetrieve.BackColor = Color.Orange;
            btnRetrieve.FlatStyle = FlatStyle.Flat;
            btnRetrieve.Location = new Point(622, 359);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(75, 23);
            btnRetrieve.TabIndex = 19;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = false;
            btnRetrieve.Click += btnRetrieve_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(241, 305);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 20;
            button1.Text = "Retrieve All";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(113, 42);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 21;
            label2.Text = "ID";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.history;
            ClientSize = new Size(750, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnRetrieve);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCheckoutTime);
            Controls.Add(txtDate);
            Controls.Add(label4);
            Controls.Add(txtSlotNumber);
            Controls.Add(txtPlateNumber);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(dataGridViewHistory);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DataGridView dataGridViewHistory;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtPlateNumber;
        private TextBox txtSlotNumber;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private TextBox txtDate;
        private TextBox txtCheckoutTime;
        private Label label6;
        private Label label7;
        private Button btnRetrieve;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
    }
}