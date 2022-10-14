namespace ParserOne
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
            this.ListTitle = new System.Windows.Forms.ListBox();
            this.StartPoint = new System.Windows.Forms.Label();
            this.EndPoint = new System.Windows.Forms.Label();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.StartBtn = new System.Windows.Forms.Button();
            this.AbortBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTitle
            // 
            this.ListTitle.FormattingEnabled = true;
            this.ListTitle.ItemHeight = 16;
            this.ListTitle.Location = new System.Drawing.Point(21, 14);
            this.ListTitle.Name = "ListTitle";
            this.ListTitle.Size = new System.Drawing.Size(401, 500);
            this.ListTitle.TabIndex = 0;
            // 
            // StartPoint
            // 
            this.StartPoint.Location = new System.Drawing.Point(614, 14);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(99, 19);
            this.StartPoint.TabIndex = 1;
            this.StartPoint.Text = "Start Point";
            // 
            // EndPoint
            // 
            this.EndPoint.Location = new System.Drawing.Point(621, 97);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(95, 25);
            this.EndPoint.TabIndex = 3;
            this.EndPoint.Text = "End Point";
            // 
            // NumericStart
            // 
            this.NumericStart.Location = new System.Drawing.Point(621, 55);
            this.NumericStart.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(92, 22);
            this.NumericStart.TabIndex = 4;
            this.NumericStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumericEnd
            // 
            this.NumericEnd.Location = new System.Drawing.Point(626, 125);
            this.NumericEnd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(87, 22);
            this.NumericEnd.TabIndex = 5;
            this.NumericEnd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(634, 201);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(83, 24);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // AbortBtn
            // 
            this.AbortBtn.Location = new System.Drawing.Point(634, 242);
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Size = new System.Drawing.Size(82, 24);
            this.AbortBtn.TabIndex = 7;
            this.AbortBtn.Text = "Abort";
            this.AbortBtn.UseVisualStyleBackColor = true;
            this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 531);
            this.Controls.Add(this.AbortBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.NumericEnd);
            this.Controls.Add(this.NumericStart);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.ListTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox ListTitle;
        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label EndPoint;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Button AbortBtn;

        #endregion
    }
}