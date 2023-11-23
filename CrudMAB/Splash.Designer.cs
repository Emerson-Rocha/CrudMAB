namespace CrudMab
{
    partial class Splash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.amanda_linda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CrudMab.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // prb
            // 
            this.prb.Location = new System.Drawing.Point(25, 277);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(240, 23);
            this.prb.Step = 1;
            this.prb.TabIndex = 1;
            this.prb.Value = 1;
            // 
            // tm
            // 
            this.tm.Enabled = true;
            this.tm.Tick += new System.EventHandler(this.Tm_Tick);
            // 
            // amanda_linda
            // 
            this.amanda_linda.AutoSize = true;
            this.amanda_linda.Location = new System.Drawing.Point(124, 316);
            this.amanda_linda.Name = "amanda_linda";
            this.amanda_linda.Size = new System.Drawing.Size(35, 13);
            this.amanda_linda.TabIndex = 2;
            this.amanda_linda.Text = "label1";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 351);
            this.Controls.Add(this.amanda_linda);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Label amanda_linda;
    }
}

