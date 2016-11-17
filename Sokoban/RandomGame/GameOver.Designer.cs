namespace RandomGame
{
    partial class GameOver
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
            this.window = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.window)).BeginInit();
            this.SuspendLayout();
            // 
            // window
            // 
            this.window.Location = new System.Drawing.Point(-1, -2);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(500, 380);
            this.window.TabIndex = 0;
            this.window.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 378);
            this.Controls.Add(this.window);
            this.Name = "GameOver";
            this.Text = "Game Over";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameOver_FormClosed);
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOver_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.window)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox window;
    }
}