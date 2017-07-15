namespace AccountingManagement
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.PaidByComboBox = new System.Windows.Forms.ComboBox();
            this.TransactionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorisedByComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.VoucherLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NarrationTextBox = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voucher No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paid By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transaction type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Authorised By";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(160, 113);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 6;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // PaidByComboBox
            // 
            this.PaidByComboBox.FormattingEnabled = true;
            this.PaidByComboBox.Location = new System.Drawing.Point(160, 181);
            this.PaidByComboBox.Name = "PaidByComboBox";
            this.PaidByComboBox.Size = new System.Drawing.Size(121, 21);
            this.PaidByComboBox.TabIndex = 7;
            this.PaidByComboBox.SelectedIndexChanged += new System.EventHandler(this.PaidByComboBox_SelectedIndexChanged);
            // 
            // TransactionTypeComboBox
            // 
            this.TransactionTypeComboBox.FormattingEnabled = true;
            this.TransactionTypeComboBox.Location = new System.Drawing.Point(607, 186);
            this.TransactionTypeComboBox.Name = "TransactionTypeComboBox";
            this.TransactionTypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.TransactionTypeComboBox.TabIndex = 8;
            this.TransactionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TransactionTypeComboBox_SelectedIndexChanged);
            // 
            // AuthorisedByComboBox
            // 
            this.AuthorisedByComboBox.FormattingEnabled = true;
            this.AuthorisedByComboBox.Location = new System.Drawing.Point(607, 112);
            this.AuthorisedByComboBox.Name = "AuthorisedByComboBox";
            this.AuthorisedByComboBox.Size = new System.Drawing.Size(204, 21);
            this.AuthorisedByComboBox.TabIndex = 9;
            this.AuthorisedByComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthorisedByComboBox_SelectedIndexChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(690, 242);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(121, 43);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(604, 51);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(80, 16);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "current Date";
            // 
            // VoucherLabel
            // 
            this.VoucherLabel.AutoSize = true;
            this.VoucherLabel.Location = new System.Drawing.Point(157, 54);
            this.VoucherLabel.Name = "VoucherLabel";
            this.VoucherLabel.Size = new System.Drawing.Size(0, 13);
            this.VoucherLabel.TabIndex = 13;
            this.VoucherLabel.Text = "Voucher Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Narration";
            // 
            // NarrationTextBox
            // 
            this.NarrationTextBox.Location = new System.Drawing.Point(160, 242);
            this.NarrationTextBox.Multiline = true;
            this.NarrationTextBox.Name = "NarrationTextBox";
            this.NarrationTextBox.Size = new System.Drawing.Size(312, 75);
            this.NarrationTextBox.TabIndex = 15;
            this.NarrationTextBox.TextChanged += new System.EventHandler(this.NarrationTextBox_TextChanged_1);
            // 
            // listView
            // 
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(41, 356);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(25, 24);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(160, 343);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(651, 145);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 500);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.NarrationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VoucherLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AuthorisedByComboBox);
            this.Controls.Add(this.TransactionTypeComboBox);
            this.Controls.Add(this.PaidByComboBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.ComboBox PaidByComboBox;
        private System.Windows.Forms.ComboBox TransactionTypeComboBox;
        private System.Windows.Forms.ComboBox AuthorisedByComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label VoucherLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NarrationTextBox;
        internal System.Windows.Forms.ListView listView;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

