namespace Asignment8
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
            this.LBLNum = new System.Windows.Forms.Label();
            this.TXTNum = new System.Windows.Forms.TextBox();
            this.BTNClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNum
            // 
            this.LBLNum.AutoSize = true;
            this.LBLNum.Location = new System.Drawing.Point(6, 9);
            this.LBLNum.Name = "LBLNum";
            this.LBLNum.Size = new System.Drawing.Size(56, 13);
            this.LBLNum.TabIndex = 0;
            this.LBLNum.Text = "اكتب ال&رقم";
            this.LBLNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTNum
            // 
            this.TXTNum.Location = new System.Drawing.Point(68, 6);
            this.TXTNum.Name = "TXTNum";
            this.TXTNum.Size = new System.Drawing.Size(100, 20);
            this.TXTNum.TabIndex = 1;
            // 
            // BTNClick
            // 
            this.BTNClick.AutoSize = true;
            this.BTNClick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNClick.Location = new System.Drawing.Point(174, 12);
            this.BTNClick.Name = "BTNClick";
            this.BTNClick.Size = new System.Drawing.Size(61, 23);
            this.BTNClick.TabIndex = 2;
            this.BTNClick.Text = "اضغط &هنا";
            this.BTNClick.UseVisualStyleBackColor = true;
            this.BTNClick.Click += new System.EventHandler(this.BTNClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNClick);
            this.Controls.Add(this.TXTNum);
            this.Controls.Add(this.LBLNum);
            this.Name = "Form1";
            this.Text = "الواجب الثامن مقارنة الرقم";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNum;
        private System.Windows.Forms.TextBox TXTNum;
        private System.Windows.Forms.Button BTNClick;
    }
}

