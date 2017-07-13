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
            this.EditNarrationTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditAuthorisedByComboBox = new System.Windows.Forms.ComboBox();
            this.EditTransactionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.EditPaidByComboBox = new System.Windows.Forms.ComboBox();
            this.EditAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditNarrationTextBox
            // 
            this.EditNarrationTextBox.Location = new System.Drawing.Point(136, 252);
            this.EditNarrationTextBox.Multiline = true;
            this.EditNarrationTextBox.Name = "EditNarrationTextBox";
            this.EditNarrationTextBox.Size = new System.Drawing.Size(312, 75);
            this.EditNarrationTextBox.TabIndex = 25;
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
            // 
            // EditAuthorisedByComboBox
            // 
            this.EditAuthorisedByComboBox.FormattingEnabled = true;
            this.EditAuthorisedByComboBox.Location = new System.Drawing.Point(583, 122);
            this.EditAuthorisedByComboBox.Name = "EditAuthorisedByComboBox";
            this.EditAuthorisedByComboBox.Size = new System.Drawing.Size(204, 21);
            this.EditAuthorisedByComboBox.TabIndex = 22;
            // 
            // EditTransactionTypeComboBox
            // 
            this.EditTransactionTypeComboBox.FormattingEnabled = true;
            this.EditTransactionTypeComboBox.Location = new System.Drawing.Point(583, 196);
            this.EditTransactionTypeComboBox.Name = "EditTransactionTypeComboBox";
            this.EditTransactionTypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.EditTransactionTypeComboBox.TabIndex = 21;
            // 
            // EditPaidByComboBox
            // 
            this.EditPaidByComboBox.FormattingEnabled = true;
            this.EditPaidByComboBox.Location = new System.Drawing.Point(136, 191);
            this.EditPaidByComboBox.Name = "EditPaidByComboBox";
            this.EditPaidByComboBox.Size = new System.Drawing.Size(121, 21);
            this.EditPaidByComboBox.TabIndex = 20;
            // 
            // EditAmountTextBox
            // 
            this.EditAmountTextBox.Location = new System.Drawing.Point(136, 123);
            this.EditAmountTextBox.Name = "EditAmountTextBox";
            this.EditAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.EditAmountTextBox.TabIndex = 19;
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
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 448);
            this.Controls.Add(this.EditNarrationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.EditAuthorisedByComboBox);
            this.Controls.Add(this.EditTransactionTypeComboBox);
            this.Controls.Add(this.EditPaidByComboBox);
            this.Controls.Add(this.EditAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditForm";
            this.Text = "EditForm";
         //   this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditNarrationTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox EditAuthorisedByComboBox;
        private System.Windows.Forms.ComboBox EditTransactionTypeComboBox;
        private System.Windows.Forms.ComboBox EditPaidByComboBox;
        private System.Windows.Forms.TextBox EditAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}