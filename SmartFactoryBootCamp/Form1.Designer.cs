﻿namespace SmartFactoryBootCamp
{
    partial class Form1
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.botton_input = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(13, 12);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(175, 21);
            this.textBox_input.TabIndex = 0;
            // 
            // botton_input
            // 
            this.botton_input.Location = new System.Drawing.Point(209, 10);
            this.botton_input.Name = "botton_input";
            this.botton_input.Size = new System.Drawing.Size(104, 23);
            this.botton_input.TabIndex = 1;
            this.botton_input.Text = "input";
            this.botton_input.UseVisualStyleBackColor = true;
            this.botton_input.Click += new System.EventHandler(this.botton_input_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_result.Location = new System.Drawing.Point(12, 39);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(301, 222);
            this.textBox_result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 279);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.botton_input);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button botton_input;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

