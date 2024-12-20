namespace SmartFactoryBootCamp
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
            this.scissors = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.papper = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scissors
            // 
            this.scissors.Location = new System.Drawing.Point(12, 12);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(75, 23);
            this.scissors.TabIndex = 0;
            this.scissors.Text = "가위";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(147, 12);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(75, 23);
            this.rock.TabIndex = 1;
            this.rock.Text = "바위";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // papper
            // 
            this.papper.Location = new System.Drawing.Point(273, 12);
            this.papper.Name = "papper";
            this.papper.Size = new System.Drawing.Size(75, 23);
            this.papper.TabIndex = 2;
            this.papper.Text = "보";
            this.papper.UseVisualStyleBackColor = true;
            this.papper.Click += new System.EventHandler(this.papper_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 59);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox.Size = new System.Drawing.Size(336, 219);
            this.resultBox.TabIndex = 3;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.papper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.scissors);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button papper;
        private System.Windows.Forms.TextBox resultBox;
    }
}