namespace Jogo_Do_Labirinto
{
    partial class InicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.pibPersonagem = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pibPersonagem
            // 
            this.pibPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.pibPersonagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pibPersonagem.ErrorImage = null;
            this.pibPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.Image")));
            this.pibPersonagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.InitialImage")));
            this.pibPersonagem.Location = new System.Drawing.Point(147, 56);
            this.pibPersonagem.Margin = new System.Windows.Forms.Padding(0);
            this.pibPersonagem.Name = "pibPersonagem";
            this.pibPersonagem.Size = new System.Drawing.Size(429, 287);
            this.pibPersonagem.TabIndex = 0;
            this.pibPersonagem.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.LawnGreen;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(285, 339);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(231, 98);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Labirinto Espacial";
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pibPersonagem);
            this.MaximizeBox = false;
            this.Name = "InicioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirinto Espacial";
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibPersonagem;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label1;
    }
}