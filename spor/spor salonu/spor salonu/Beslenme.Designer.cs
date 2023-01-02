
namespace spor_salonu
{
    partial class Beslenme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(304, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "FITNESS CENTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(321, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Beslenme Programı";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 497);
            this.panel1.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button8.ForeColor = System.Drawing.Color.Crimson;
            this.button8.Location = new System.Drawing.Point(46, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 62);
            this.button8.TabIndex = 13;
            this.button8.Text = "Antrenman Sofrası";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.ForeColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(46, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 62);
            this.button6.TabIndex = 12;
            this.button6.Text = "Anrenman Öncesi";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(46, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 62);
            this.button5.TabIndex = 11;
            this.button5.Text = "Supplementler";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(618, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 44);
            this.button4.TabIndex = 25;
            this.button4.Text = "Anasayfa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(788, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(239, 182);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(536, 303);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // Beslenme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 497);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Beslenme";
            this.Text = "Beslenme";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}