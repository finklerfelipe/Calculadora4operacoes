namespace calculadoraG2
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
            this.boxnumero1 = new System.Windows.Forms.TextBox();
            this.boxnumero2 = new System.Windows.Forms.TextBox();
            this.boxresultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.adicionar = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxnumero1
            // 
            this.boxnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxnumero1.Location = new System.Drawing.Point(42, 133);
            this.boxnumero1.Name = "boxnumero1";
            this.boxnumero1.Size = new System.Drawing.Size(84, 53);
            this.boxnumero1.TabIndex = 0;
            this.boxnumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxnumero1.TextChanged += new System.EventHandler(this.Boxnumero1_TextChanged);
            // 
            // boxnumero2
            // 
            this.boxnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxnumero2.Location = new System.Drawing.Point(349, 133);
            this.boxnumero2.Name = "boxnumero2";
            this.boxnumero2.Size = new System.Drawing.Size(86, 53);
            this.boxnumero2.TabIndex = 1;
            this.boxnumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxresultado
            // 
            this.boxresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxresultado.Location = new System.Drawing.Point(511, 108);
            this.boxresultado.Name = "boxresultado";
            this.boxresultado.Size = new System.Drawing.Size(148, 83);
            this.boxresultado.TabIndex = 2;
            this.boxresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(461, 153);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(25, 25);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "=";
            this.lblresultado.Click += new System.EventHandler(this.Lblresultado_Click);
            // 
            // adicionar
            // 
            this.adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.Location = new System.Drawing.Point(165, 30);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(151, 34);
            this.adicionar.TabIndex = 5;
            this.adicionar.Text = "Adição";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // subtracao
            // 
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(165, 106);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(151, 34);
            this.subtracao.TabIndex = 6;
            this.subtracao.Text = "Subtração";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // divisao
            // 
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(165, 185);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(151, 34);
            this.divisao.TabIndex = 7;
            this.divisao.Text = "Divisão";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.Button2_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(165, 265);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(151, 34);
            this.multiplicacao.TabIndex = 8;
            this.multiplicacao.Text = "Multiplicação";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 326);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.boxresultado);
            this.Controls.Add(this.boxnumero2);
            this.Controls.Add(this.boxnumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxnumero1;
        private System.Windows.Forms.TextBox boxnumero2;
        private System.Windows.Forms.TextBox boxresultado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button multiplicacao;
    }
}

