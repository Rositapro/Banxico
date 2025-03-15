namespace Banxico
{
    partial class Form4
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
            btnClose = new Button();
            btnEnter = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(117, 124);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 36);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(217, 124);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 36);
            btnEnter.TabIndex = 13;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 12;
            label2.Text = "End date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 11;
            label1.Text = "Start date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(92, 86);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(92, 38);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 9;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(336, 29);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(553, 440);
            formsPlot1.TabIndex = 15;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 506);
            Controls.Add(formsPlot1);
            Controls.Add(btnClose);
            Controls.Add(btnEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnEnter;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}