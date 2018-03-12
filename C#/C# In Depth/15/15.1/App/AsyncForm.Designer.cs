namespace App
{
    partial class AsyncForm
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
            this.GetLengthButton = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetLengthButton
            // 
            this.GetLengthButton.Location = new System.Drawing.Point(139, 36);
            this.GetLengthButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GetLengthButton.Name = "GetLengthButton";
            this.GetLengthButton.Size = new System.Drawing.Size(194, 48);
            this.GetLengthButton.TabIndex = 0;
            this.GetLengthButton.Text = "Get Website Length";
            this.GetLengthButton.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(134, 90);
            this.lblSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 26);
            this.lblSize.TabIndex = 1;
            // 
            // AsyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 307);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.GetLengthButton);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AsyncForm";
            this.Text = "Async Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetLengthButton;
        private System.Windows.Forms.Label lblSize;
    }
}

