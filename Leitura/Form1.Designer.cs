
namespace Leitura
{
    partial class frmPrincipal
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
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.bntAbrir = new System.Windows.Forms.Button();
            this.bntGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(136, 86);
            this.txtArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(132, 23);
            this.txtArquivo.TabIndex = 0;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(136, 160);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(132, 23);
            this.txtRegistro.TabIndex = 1;
            // 
            // bntAbrir
            // 
            this.bntAbrir.Location = new System.Drawing.Point(344, 85);
            this.bntAbrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntAbrir.Name = "bntAbrir";
            this.bntAbrir.Size = new System.Drawing.Size(100, 26);
            this.bntAbrir.TabIndex = 2;
            this.bntAbrir.Text = "Abrir";
            this.bntAbrir.UseVisualStyleBackColor = true;
            this.bntAbrir.Click += new System.EventHandler(this.bntAbrir_Click);
            // 
            // bntGravar
            // 
            this.bntGravar.Location = new System.Drawing.Point(344, 159);
            this.bntGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntGravar.Name = "bntGravar";
            this.bntGravar.Size = new System.Drawing.Size(100, 26);
            this.bntGravar.TabIndex = 3;
            this.bntGravar.Text = "Gravar";
            this.bntGravar.UseVisualStyleBackColor = true;
            this.bntGravar.Click += new System.EventHandler(this.bntGravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desafio BONOR: Ler TXT e escrever no B.D.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(16, 250);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 17);
            this.lblMensagem.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(465, 302);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntGravar);
            this.Controls.Add(this.bntAbrir);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.txtArquivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Desafio BONOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button bntAbrir;
        private System.Windows.Forms.Button bntGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMensagem;
    }
}

