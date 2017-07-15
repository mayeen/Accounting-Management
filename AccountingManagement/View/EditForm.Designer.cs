namespace AccountingManagement.View
{
    partial class EditForm
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
            this.NarrationTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.AuthorisedByComboBox = new System.Windows.Forms.ComboBox();
            this.TransactionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PaidByComboBox = new System.Windows.Forms.ComboBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditVoucherLabel = new System.Windows.Forms.Label();
            this.EditDateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NarrationTextBox
            // 
            this.NarrationTextBox.Location = new System.Drawing.Point(136, 252);
            this.NarrationTextBox.Multiline = true;
            this.NarrationTextBox.Name = "NarrationTextBox";
            this.NarrationTextBox.Size = new System.Drawing.Size(312, 75);
            this.NarrationTextBox.TabIndex = 25;
            this.NarrationTextBox.TextChanged += new System.EventHandler(this.EditNarrationTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Narration";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(666, 252);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(121, 43);
            this.EditButton.TabIndex = 23;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AuthorisedByComboBox
            // 
            this.AuthorisedByComboBox.FormattingEnabled = true;
            this.AuthorisedByComboBox.Location = new System.Drawing.Point(583, 122);
            this.AuthorisedByComboBox.Name = "AuthorisedByComboBox";
            this.AuthorisedByComboBox.Size = new System.Drawing.Size(204, 21);
            this.AuthorisedByComboBox.TabIndex = 22;
            this.AuthorisedByComboBox.SelectedIndexChanged += new System.EventHandler(this.EditAuthorisedByComboBox_SelectedIndexChanged);
            // 
            // TransactionTypeComboBox
            // 
            this.TransactionTypeComboBox.FormattingEnabled = true;
            this.TransactionTypeComboBox.Location = new System.Drawing.Point(583, 196);
            this.TransactionTypeComboBox.Name = "TransactionTypeComboBox";
            this.TransactionTypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.TransactionTypeComboBox.TabIndex = 21;
            this.TransactionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.EditTransactionTypeComboBox_SelectedIndexChanged);
            // 
            // PaidByComboBox
            // 
            this.PaidByComboBox.FormattingEnabled = true;
            this.PaidByComboBox.Location = new System.Drawing.Point(136, 191);
            this.PaidByComboBox.Name = "PaidByComboBox";
            this.PaidByComboBox.Size = new System.Drawing.Size(121, 21);
            this.PaidByComboBox.TabIndex = 20;
            this.PaidByComboBox.SelectedIndexChanged += new System.EventHandler(this.EditPaidByComboBox_SelectedIndexChanged);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(136, 123);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 19;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.EditAmountTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Authorised By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paid By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Transaction type";
            // 
            // EditVoucherLabel
            // 
            this.EditVoucherLabel.AutoSize = true;
            this.EditVoucherLabel.Location = new System.Drawing.Point(133, 57);
            this.EditVoucherLabel.Name = "EditVoucherLabel";
            this.EditVoucherLabel.Size = new System.Drawing.Size(28, 13);
            this.EditVoucherLabel.TabIndex = 30;
            this.EditVoucherLabel.Text = "VNo";
            this.EditVoucherLabel.Click += new System.EventHandler(this.EditVoucherLabel_Click);
            // 
            // EditDateLabel
            // 
            this.EditDateLabel.AutoSize = true;
            this.EditDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDateLabel.Location = new System.Drawing.Point(580, 54);
            this.EditDateLabel.Name = "EditDateLabel";
            this.EditDateLabel.Size = new System.Drawing.Size(80, 16);
            this.EditDateLabel.TabIndex = 29;
            this.EditDateLabel.Text = "current Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Voucher No";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 448);
            this.Controls.Add(this.EditVoucherLabel);
            this.Controls.Add(this.EditDateLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NarrationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AuthorisedByComboBox);
            this.Controls.Add(this.TransactionTypeComboBox);
            this.Controls.Add(this.PaidByComboBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NarrationTextBox;
        public System.Windows.Forms.ComboBox AuthorisedByComboBox;
        public System.Windows.Forms.ComboBox TransactionTypeComboBox;
        public System.Windows.Forms.ComboBox PaidByComboBox;
        public System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label EditVoucherLabel;
        public System.Windows.Forms.Label EditDateLabel;
    }
}