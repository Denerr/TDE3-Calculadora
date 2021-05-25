
namespace TDE3_Calculadora
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnMontante = new System.Windows.Forms.Button();
            this.btnCapital = new System.Windows.Forms.Button();
            this.btnTempo = new System.Windows.Forms.Button();
            this.btnTaxa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMontante
            // 
            this.btnMontante.BackColor = System.Drawing.Color.Transparent;
            this.btnMontante.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMontante.FlatAppearance.BorderSize = 3;
            this.btnMontante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMontante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnMontante.ForeColor = System.Drawing.Color.White;
            this.btnMontante.Location = new System.Drawing.Point(77, 169);
            this.btnMontante.Name = "btnMontante";
            this.btnMontante.Size = new System.Drawing.Size(171, 64);
            this.btnMontante.TabIndex = 0;
            this.btnMontante.Text = "Calcular Montante";
            this.btnMontante.UseVisualStyleBackColor = false;
            this.btnMontante.Click += new System.EventHandler(this.btnMontante_Click);
            this.btnMontante.MouseEnter += new System.EventHandler(this.btnMontante_MouseEnter);
            this.btnMontante.MouseLeave += new System.EventHandler(this.btnMontante_MouseLeave);
            // 
            // btnCapital
            // 
            this.btnCapital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapital.BackColor = System.Drawing.Color.Transparent;
            this.btnCapital.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCapital.FlatAppearance.BorderSize = 3;
            this.btnCapital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapital.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnCapital.ForeColor = System.Drawing.Color.White;
            this.btnCapital.Location = new System.Drawing.Point(386, 169);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(171, 64);
            this.btnCapital.TabIndex = 1;
            this.btnCapital.Text = "Calcular Capital";
            this.btnCapital.UseVisualStyleBackColor = false;
            this.btnCapital.Click += new System.EventHandler(this.btnCapital_Click);
            this.btnCapital.MouseEnter += new System.EventHandler(this.btnCapital_MouseEnter);
            this.btnCapital.MouseLeave += new System.EventHandler(this.btnCapital_MouseLeave);
            // 
            // btnTempo
            // 
            this.btnTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTempo.BackColor = System.Drawing.Color.Transparent;
            this.btnTempo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTempo.FlatAppearance.BorderSize = 3;
            this.btnTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnTempo.ForeColor = System.Drawing.Color.White;
            this.btnTempo.Location = new System.Drawing.Point(386, 270);
            this.btnTempo.Name = "btnTempo";
            this.btnTempo.Size = new System.Drawing.Size(171, 64);
            this.btnTempo.TabIndex = 3;
            this.btnTempo.Text = "Calcular Tempo";
            this.btnTempo.UseVisualStyleBackColor = false;
            this.btnTempo.Click += new System.EventHandler(this.btnTempo_Click);
            this.btnTempo.MouseEnter += new System.EventHandler(this.btnTempo_MouseEnter);
            this.btnTempo.MouseLeave += new System.EventHandler(this.btnTempo_MouseLeave);
            // 
            // btnTaxa
            // 
            this.btnTaxa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTaxa.BackColor = System.Drawing.Color.Transparent;
            this.btnTaxa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTaxa.FlatAppearance.BorderSize = 3;
            this.btnTaxa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaxa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnTaxa.ForeColor = System.Drawing.Color.White;
            this.btnTaxa.Location = new System.Drawing.Point(77, 270);
            this.btnTaxa.Name = "btnTaxa";
            this.btnTaxa.Size = new System.Drawing.Size(171, 64);
            this.btnTaxa.TabIndex = 2;
            this.btnTaxa.Text = "Calcular Taxa de Juros";
            this.btnTaxa.UseVisualStyleBackColor = false;
            this.btnTaxa.Click += new System.EventHandler(this.btnTaxa_Click);
            this.btnTaxa.MouseEnter += new System.EventHandler(this.btnTaxa_MouseEnter);
            this.btnTaxa.MouseLeave += new System.EventHandler(this.btnTaxa_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculadora de Juros Compostos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Escolha a Operação";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTempo);
            this.Controls.Add(this.btnTaxa);
            this.Controls.Add(this.btnCapital);
            this.Controls.Add(this.btnMontante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMenu";
            this.Text = "Menu Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMontante;
        private System.Windows.Forms.Button btnCapital;
        private System.Windows.Forms.Button btnTempo;
        private System.Windows.Forms.Button btnTaxa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

