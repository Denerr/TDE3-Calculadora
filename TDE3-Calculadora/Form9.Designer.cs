﻿
namespace TDE3_Calculadora
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.btnPorcento = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPorcento
            // 
            this.btnPorcento.BackColor = System.Drawing.Color.Transparent;
            this.btnPorcento.FlatAppearance.BorderSize = 3;
            this.btnPorcento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPorcento.ForeColor = System.Drawing.Color.White;
            this.btnPorcento.Location = new System.Drawing.Point(386, 283);
            this.btnPorcento.Name = "btnPorcento";
            this.btnPorcento.Size = new System.Drawing.Size(95, 37);
            this.btnPorcento.TabIndex = 33;
            this.btnPorcento.Text = "%";
            this.btnPorcento.UseVisualStyleBackColor = false;
            this.btnPorcento.Click += new System.EventHandler(this.btnPorcento_Click);
            this.btnPorcento.MouseEnter += new System.EventHandler(this.btnPorcento_MouseEnter);
            this.btnPorcento.MouseLeave += new System.EventHandler(this.btnPorcento_MouseLeave);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtResultado.Location = new System.Drawing.Point(351, 126);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(179, 26);
            this.txtResultado.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(363, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Resultado";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtPeriodo.Location = new System.Drawing.Point(35, 200);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(179, 26);
            this.txtPeriodo.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Periodo";
            // 
            // txtNominal
            // 
            this.txtNominal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtNominal.Location = new System.Drawing.Point(35, 126);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(179, 26);
            this.txtNominal.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Valor Nominal";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtDesconto.Location = new System.Drawing.Point(35, 57);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(179, 26);
            this.txtDesconto.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Desconto";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderSize = 3;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(450, 240);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 37);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseEnter += new System.EventHandler(this.btnLimpar_MouseEnter);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.btnLimpar_MouseLeave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatAppearance.BorderSize = 3;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(334, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 37);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.MouseEnter += new System.EventHandler(this.btnCalcular_MouseEnter);
            this.btnCalcular.MouseLeave += new System.EventHandler(this.btnCalcular_MouseLeave);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 359);
            this.Controls.Add(this.btnPorcento);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form9";
            this.Text = "Calculo de Taxa de Juros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPorcento;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}