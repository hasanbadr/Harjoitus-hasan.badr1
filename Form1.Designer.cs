namespace _1._Harjoitus_hasan.badr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OtsikkoLB = new Label();
            vaihdaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Location = new Point(57, 44);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(47, 15);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Otsikko";
            OtsikkoLB.Click += label1_Click;
            // 
            // vaihdaBT
            // 
            vaihdaBT.Location = new Point(63, 80);
            vaihdaBT.Name = "vaihdaBT";
            vaihdaBT.Size = new Size(75, 39);
            vaihdaBT.TabIndex = 1;
            vaihdaBT.Text = "vaihda teksti";
            vaihdaBT.UseVisualStyleBackColor = true;
            vaihdaBT.Click += vaihdaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vaihdaBT);
            Controls.Add(OtsikkoLB);
            Name = "Form1";
            Text = "Harjoitus 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Button vaihdaBT;
    }
}