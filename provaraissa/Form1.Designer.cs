namespace provaraissa
{
    partial class Form1
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
            this.listaDados = new System.Windows.Forms.ListBox();
            this.btnDados = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaDados
            // 
            this.listaDados.FormattingEnabled = true;
            this.listaDados.ItemHeight = 20;
            this.listaDados.Location = new System.Drawing.Point(787, 50);
            this.listaDados.Name = "listaDados";
            this.listaDados.Size = new System.Drawing.Size(398, 624);
            this.listaDados.TabIndex = 0;
            // 
            // btnDados
            // 
            this.btnDados.Location = new System.Drawing.Point(363, 194);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(192, 87);
            this.btnDados.TabIndex = 1;
            this.btnDados.Text = "Receber dados";
            this.btnDados.UseVisualStyleBackColor = true;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(363, 362);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(192, 68);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 723);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.listaDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaDados;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Button btnLimpar;
    }
}

