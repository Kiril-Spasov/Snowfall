namespace Snowfall
{
    partial class FormSnowfall
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtStatistics = new System.Windows.Forms.TextBox();
            this.BtnSortedAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Snowfall Statistics";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(541, 379);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(126, 40);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtStatistics
            // 
            this.TxtStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtStatistics.Location = new System.Drawing.Point(137, 55);
            this.TxtStatistics.Multiline = true;
            this.TxtStatistics.Name = "TxtStatistics";
            this.TxtStatistics.Size = new System.Drawing.Size(544, 289);
            this.TxtStatistics.TabIndex = 3;
            // 
            // BtnSortedAverage
            // 
            this.BtnSortedAverage.Location = new System.Drawing.Point(140, 376);
            this.BtnSortedAverage.Name = "BtnSortedAverage";
            this.BtnSortedAverage.Size = new System.Drawing.Size(142, 42);
            this.BtnSortedAverage.TabIndex = 4;
            this.BtnSortedAverage.Text = "Show Sorted Average";
            this.BtnSortedAverage.UseVisualStyleBackColor = true;
            this.BtnSortedAverage.Click += new System.EventHandler(this.BtnSortedAverage_Click);
            // 
            // FormSnowfall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSortedAverage);
            this.Controls.Add(this.TxtStatistics);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormSnowfall";
            this.Text = "Snowfall Statistics";
            this.Load += new System.EventHandler(this.FormSnowfall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtStatistics;
        private System.Windows.Forms.Button BtnSortedAverage;
    }
}

