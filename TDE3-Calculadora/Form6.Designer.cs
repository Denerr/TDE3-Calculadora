
namespace TDE3_Calculadora
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lblMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.btnTaxa = new System.Windows.Forms.Button();
            this.btnNominal = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(186, 96);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(170, 18);
            this.lblMenu.TabIndex = 11;
            this.lblMenu.Text = "Escolha a Operação";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculadora de Descontos Racionais";
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.btnPeriodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPeriodo.FlatAppearance.BorderSize = 3;
            this.btnPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPeriodo.ForeColor = System.Drawing.Color.White;
            this.btnPeriodo.Location = new System.Drawing.Point(392, 276);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(171, 64);
            this.btnPeriodo.TabIndex = 9;
            this.btnPeriodo.Text = "Calcular Periodo  de Antecipação";
            this.btnPeriodo.UseVisualStyleBackColor = false;
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
            this.btnTaxa.Location = new System.Drawing.Point(26, 276);
            this.btnTaxa.Name = "btnTaxa";
            this.btnTaxa.Size = new System.Drawing.Size(171, 64);
            this.btnTaxa.TabIndex = 8;
            this.btnTaxa.Text = "Calcular Taxa de Juros";
            this.btnTaxa.UseVisualStyleBackColor = false;
            // 
            // btnNominal
            // 
            this.btnNominal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNominal.BackColor = System.Drawing.Color.Transparent;
            this.btnNominal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNominal.FlatAppearance.BorderSize = 3;
            this.btnNominal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNominal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnNominal.ForeColor = System.Drawing.Color.White;
            this.btnNominal.Location = new System.Drawing.Point(392, 175);
            this.btnNominal.Name = "btnNominal";
            this.btnNominal.Size = new System.Drawing.Size(171, 64);
            this.btnNominal.TabIndex = 7;
            this.btnNominal.Text = "Calcular Valor Nominal";
            this.btnNominal.UseVisualStyleBackColor = false;
            // 
            // btnDesconto
            // 
            this.btnDesconto.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDesconto.FlatAppearance.BorderSize = 3;
            this.btnDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDesconto.ForeColor = System.Drawing.Color.White;
            this.btnDesconto.Location = new System.Drawing.Point(26, 175);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(171, 64);
            this.btnDesconto.TabIndex = 6;
            this.btnDesconto.Text = "Calcular Desconto";
            this.btnDesconto.UseVisualStyleBackColor = false;
            this.btnDesconto.Click += new System.EventHandler(this.btnMontante_Click);
            this.btnDesconto.MouseEnter += new System.EventHandler(this.btnMontante_MouseEnter);
            this.btnDesconto.MouseLeave += new System.EventHandler(this.btnMontante_MouseLeave);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 388);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeriodo);
            this.Controls.Add(this.btnTaxa);
            this.Controls.Add(this.btnNominal);
            this.Controls.Add(this.btnDesconto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form6";
            this.Text = "Calculadora de Descontos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.Button btnTaxa;
        private System.Windows.Forms.Button btnNominal;
        private System.Windows.Forms.Button btnDesconto;
    }
}