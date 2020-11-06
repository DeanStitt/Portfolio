namespace Lab6
{
    partial class Lab6Form
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.wpmLbl = new System.Windows.Forms.Label();
            this.wpmTxt = new System.Windows.Forms.TextBox();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.gradeOutputLbl = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(18, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(248, 20);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "The Nimble Fingers Typing School";
            // 
            // wpmLbl
            // 
            this.wpmLbl.AutoSize = true;
            this.wpmLbl.Location = new System.Drawing.Point(42, 58);
            this.wpmLbl.Name = "wpmLbl";
            this.wpmLbl.Size = new System.Drawing.Size(95, 13);
            this.wpmLbl.TabIndex = 1;
            this.wpmLbl.Text = "Words Per Minute:";
            // 
            // wpmTxt
            // 
            this.wpmTxt.Location = new System.Drawing.Point(143, 55);
            this.wpmTxt.Name = "wpmTxt";
            this.wpmTxt.Size = new System.Drawing.Size(100, 20);
            this.wpmTxt.TabIndex = 2;
            // 
            // gradeLbl
            // 
            this.gradeLbl.AutoSize = true;
            this.gradeLbl.Location = new System.Drawing.Point(61, 139);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(76, 13);
            this.gradeLbl.TabIndex = 3;
            this.gradeLbl.Text = "Grade Earned:";
            // 
            // gradeOutputLbl
            // 
            this.gradeOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeOutputLbl.Location = new System.Drawing.Point(143, 98);
            this.gradeOutputLbl.Name = "gradeOutputLbl";
            this.gradeOutputLbl.Size = new System.Drawing.Size(100, 95);
            this.gradeOutputLbl.TabIndex = 4;
            this.gradeOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(89, 207);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(107, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate Grade";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Lab6Form
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.gradeOutputLbl);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.wpmTxt);
            this.Controls.Add(this.wpmLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Lab6Form";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label wpmLbl;
        private System.Windows.Forms.TextBox wpmTxt;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.Label gradeOutputLbl;
        private System.Windows.Forms.Button calcButton;
    }
}

