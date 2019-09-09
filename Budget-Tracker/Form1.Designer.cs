namespace Budget_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.expenseButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(93, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(125, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(70, 186);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(184, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(93, 158);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(142, 25);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Enter Amount";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(93, 209);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(114, 25);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Enter Date";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(70, 237);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(184, 20);
            this.datePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Income/Expense Tracker";
            // 
            // expenseButton
            // 
            this.expenseButton.Location = new System.Drawing.Point(70, 263);
            this.expenseButton.Name = "expenseButton";
            this.expenseButton.Size = new System.Drawing.Size(75, 23);
            this.expenseButton.TabIndex = 7;
            this.expenseButton.Text = "Expense";
            this.expenseButton.UseVisualStyleBackColor = true;
            this.expenseButton.Click += new System.EventHandler(this.expenseButton_Click);
            // 
            // incomeButton
            // 
            this.incomeButton.Location = new System.Drawing.Point(179, 263);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(75, 23);
            this.incomeButton.TabIndex = 8;
            this.incomeButton.Text = "Income";
            this.incomeButton.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.AllowUserToAddRows = false;
            this.listBox.AllowUserToDeleteRows = false;
            this.listBox.AllowUserToOrderColumns = true;
            this.listBox.AllowUserToResizeColumns = false;
            this.listBox.AllowUserToResizeRows = false;
            this.listBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBox.Location = new System.Drawing.Point(309, 62);
            this.listBox.MultiSelect = false;
            this.listBox.Name = "listBox";
            this.listBox.ReadOnly = true;
            this.listBox.Size = new System.Drawing.Size(330, 272);
            this.listBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.incomeButton);
            this.Controls.Add(this.expenseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.nameLabel);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button expenseButton;
        private System.Windows.Forms.Button incomeButton;
        private System.Windows.Forms.DataGridView listBox;
    }
}

