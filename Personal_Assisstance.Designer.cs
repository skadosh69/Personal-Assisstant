﻿namespace Personal_Assisstance_1._3
{
    partial class Personal_Assisstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal_Assisstance));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Old Antic Outline", 9F, FontStyle.Bold);
            button1.Location = new Point(12, 138);
            button1.Name = "button1";
            button1.Size = new Size(141, 98);
            button1.TabIndex = 0;
            button1.Text = "Open Binary Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old Antic Outline", 14F, FontStyle.Bold);
            label1.Location = new Point(215, 165);
            label1.Name = "label1";
            label1.Size = new Size(314, 39);
            label1.TabIndex = 1;
            label1.Text = "Personal Assisstance";
            // 
            // button2
            // 
            button2.Font = new Font("Old Antic Outline", 9F, FontStyle.Bold);
            button2.Location = new Point(588, 138);
            button2.Name = "button2";
            button2.Size = new Size(141, 98);
            button2.TabIndex = 2;
            button2.Text = "Open ChatGPT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Personal_Assisstance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(739, 387);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Personal_Assisstance";
            Text = "Personal Assisstance";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
    }
}
