namespace Banxico
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            formsPlot4 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(22, 235);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(220, 203);
            formsPlot1.TabIndex = 0;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(248, 235);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(220, 203);
            formsPlot2.TabIndex = 1;
            // 
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(474, 235);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(220, 203);
            formsPlot3.TabIndex = 2;
            // 
            // formsPlot4
            // 
            formsPlot4.DisplayScale = 1F;
            formsPlot4.Location = new Point(474, 26);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(220, 203);
            formsPlot4.TabIndex = 3;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlot4);
            Controls.Add(formsPlot3);
            Controls.Add(formsPlot2);
            Controls.Add(formsPlot1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private ScottPlot.WinForms.FormsPlot formsPlot4;
    }
}