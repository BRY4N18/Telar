namespace Telar
{
    partial class FmCargando
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCargando));
            this.pctbCargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbCargando
            // 
            this.pctbCargando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbCargando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbCargando.Image = ((System.Drawing.Image)(resources.GetObject("pctbCargando.Image")));
            this.pctbCargando.Location = new System.Drawing.Point(0, 0);
            this.pctbCargando.Name = "pctbCargando";
            this.pctbCargando.Size = new System.Drawing.Size(840, 740);
            this.pctbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctbCargando.TabIndex = 0;
            this.pctbCargando.TabStop = false;
            // 
            // FmCargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 740);
            this.ControlBox = false;
            this.Controls.Add(this.pctbCargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmCargando";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmCargando";
            ((System.ComponentModel.ISupportInitialize)(this.pctbCargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbCargando;
    }
}