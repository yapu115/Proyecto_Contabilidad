﻿namespace frmLibroDiario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(684, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "DEBE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(866, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "HABER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 9);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 9);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Asientos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(800, 0);
            label5.MaximumSize = new Size(2, 100);
            label5.MinimumSize = new Size(0, 730);
            label5.Name = "label5";
            label5.Size = new Size(2, 730);
            label5.TabIndex = 6;
            label5.Text = "!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(600, 0);
            label6.MaximumSize = new Size(2, 100);
            label6.MinimumSize = new Size(0, 730);
            label6.Name = "label6";
            label6.Size = new Size(2, 730);
            label6.TabIndex = 5;
            label6.Text = "!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(50, 0);
            label7.MaximumSize = new Size(2, 100);
            label7.MinimumSize = new Size(0, 730);
            label7.Name = "label7";
            label7.Size = new Size(2, 730);
            label7.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(982, 685);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
