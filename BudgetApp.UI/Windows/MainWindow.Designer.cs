namespace BudgetApp.UI.Windows
{
    partial class MainWindow
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
            this.buttonCreateIncomeRecord = new System.Windows.Forms.Button();
            this.buttonCreateExpenseRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateIncomeRecord
            // 
            this.buttonCreateIncomeRecord.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateIncomeRecord.Location = new System.Drawing.Point(12, 720);
            this.buttonCreateIncomeRecord.Name = "buttonCreateIncomeRecord";
            this.buttonCreateIncomeRecord.Size = new System.Drawing.Size(181, 36);
            this.buttonCreateIncomeRecord.TabIndex = 0;
            this.buttonCreateIncomeRecord.Text = "Bevétel hozzáadása";
            this.buttonCreateIncomeRecord.UseVisualStyleBackColor = true;
            this.buttonCreateIncomeRecord.Click += new System.EventHandler(this.ButtonCreateIncomeRecord_Click);
            // 
            // buttonCreateExpenseRecord
            // 
            this.buttonCreateExpenseRecord.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateExpenseRecord.Location = new System.Drawing.Point(831, 720);
            this.buttonCreateExpenseRecord.Name = "buttonCreateExpenseRecord";
            this.buttonCreateExpenseRecord.Size = new System.Drawing.Size(181, 36);
            this.buttonCreateExpenseRecord.TabIndex = 1;
            this.buttonCreateExpenseRecord.Text = "Kiadás hozzáadása";
            this.buttonCreateExpenseRecord.UseVisualStyleBackColor = true;
            this.buttonCreateExpenseRecord.Click += new System.EventHandler(this.ButtonCreateExpenseRecord_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.buttonCreateExpenseRecord);
            this.Controls.Add(this.buttonCreateIncomeRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCreateIncomeRecord;
        private Button buttonCreateExpenseRecord;
    }
}