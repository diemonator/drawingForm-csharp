namespace FormPaint
{
    partial class DrawingForm
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.cordinatesLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(133, 396);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // cordinatesLb
            // 
            this.cordinatesLb.AutoSize = true;
            this.cordinatesLb.Location = new System.Drawing.Point(257, 401);
            this.cordinatesLb.Name = "cordinatesLb";
            this.cordinatesLb.Size = new System.Drawing.Size(60, 13);
            this.cordinatesLb.TabIndex = 2;
            this.cordinatesLb.Text = "Cordinates:";
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cordinatesLb);
            this.Controls.Add(this.BtnClear);
            this.Name = "DrawingForm";
            this.Text = "Drawing Form";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseClick);
            this.Resize += new System.EventHandler(this.DrawingForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label cordinatesLb;
    }
}

