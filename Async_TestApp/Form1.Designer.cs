namespace Async_TestApp
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
            this.btnCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCount2 = new System.Windows.Forms.Button();
            this.btnCount3 = new System.Windows.Forms.Button();
            this.btnCount4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(24, 86);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(86, 39);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // btnCount2
            // 
            this.btnCount2.Location = new System.Drawing.Point(128, 86);
            this.btnCount2.Name = "btnCount2";
            this.btnCount2.Size = new System.Drawing.Size(75, 23);
            this.btnCount2.TabIndex = 3;
            this.btnCount2.Text = "Count2";
            this.btnCount2.UseVisualStyleBackColor = true;
            this.btnCount2.Click += new System.EventHandler(this.btnCount2_Click);
            // 
            // btnCount3
            // 
            this.btnCount3.Location = new System.Drawing.Point(229, 86);
            this.btnCount3.Name = "btnCount3";
            this.btnCount3.Size = new System.Drawing.Size(75, 23);
            this.btnCount3.TabIndex = 4;
            this.btnCount3.Text = "Count3";
            this.btnCount3.UseVisualStyleBackColor = true;
            this.btnCount3.Click += new System.EventHandler(this.btnCount3_Click);
            // 
            // btnCount4
            // 
            this.btnCount4.Location = new System.Drawing.Point(320, 86);
            this.btnCount4.Name = "btnCount4";
            this.btnCount4.Size = new System.Drawing.Size(75, 23);
            this.btnCount4.TabIndex = 5;
            this.btnCount4.Text = "Count4";
            this.btnCount4.UseVisualStyleBackColor = true;
            this.btnCount4.Click += new System.EventHandler(this.btnCount4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.btnCount4);
            this.Controls.Add(this.btnCount3);
            this.Controls.Add(this.btnCount2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCount);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCount2;
        private System.Windows.Forms.Button btnCount3;
        private System.Windows.Forms.Button btnCount4;
    }
}

