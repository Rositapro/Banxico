namespace Banxico
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
            Label label1;
            btnTable = new Button();
            btnGraph = new Button();
            btnClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTable
            // 
            btnTable.Location = new Point(264, 133);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(112, 36);
            btnTable.TabIndex = 16;
            btnTable.Text = "Table";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 85);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 17;
            label1.Text = "File Dolly";
            // 
            // btnGraph
            // 
            btnGraph.Location = new Point(264, 175);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(112, 36);
            btnGraph.TabIndex = 18;
            btnGraph.Text = "Graph";
            btnGraph.UseVisualStyleBackColor = true;
            btnGraph.Click += btnGraph_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(264, 217);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 36);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(btnClose);
            Controls.Add(btnGraph);
            Controls.Add(label1);
            Controls.Add(btnTable);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTable;
        private Button btnGraph;
        private Button btnClose;
    }
}