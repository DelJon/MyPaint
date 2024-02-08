namespace MyPaint
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
            this.submitDimensions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitDimensions
            // 
            this.submitDimensions.Location = new System.Drawing.Point(58, 56);
            this.submitDimensions.Name = "submitDimensions";
            this.submitDimensions.Size = new System.Drawing.Size(75, 23);
            this.submitDimensions.TabIndex = 0;
            this.submitDimensions.Text = "Create!";
            this.submitDimensions.UseVisualStyleBackColor = true;
            this.submitDimensions.Click += new System.EventHandler(this.submitDimensions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(58, 5);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(100, 20);
            this.heightTB.TabIndex = 3;
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(58, 30);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(100, 20);
            this.widthTB.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 96);
            this.Controls.Add(this.widthTB);
            this.Controls.Add(this.heightTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitDimensions);
            this.Name = "Form2";
            this.Text = "New Canvas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitDimensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.TextBox widthTB;
    }
}