namespace SvgConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSelecionarArquivos = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtDiretorioSaida = new System.Windows.Forms.TextBox();
            this.lbArquivos = new System.Windows.Forms.ListBox();
            this.btnDiretorioSaida = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbxTipoConvert = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelecionarArquivos
            // 
            this.buttonSelecionarArquivos.Location = new System.Drawing.Point(12, 12);
            this.buttonSelecionarArquivos.Name = "buttonSelecionarArquivos";
            this.buttonSelecionarArquivos.Size = new System.Drawing.Size(241, 29);
            this.buttonSelecionarArquivos.TabIndex = 0;
            this.buttonSelecionarArquivos.Text = "Selecionar Arquivos";
            this.buttonSelecionarArquivos.UseVisualStyleBackColor = true;
            this.buttonSelecionarArquivos.Click += new System.EventHandler(this.btnSelecionarArquivos_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(275, 110);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(132, 29);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtDiretorioSaida
            // 
            this.txtDiretorioSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiretorioSaida.Location = new System.Drawing.Point(12, 215);
            this.txtDiretorioSaida.Name = "txtDiretorioSaida";
            this.txtDiretorioSaida.ReadOnly = true;
            this.txtDiretorioSaida.Size = new System.Drawing.Size(209, 20);
            this.txtDiretorioSaida.TabIndex = 2;
            // 
            // lbArquivos
            // 
            this.lbArquivos.FormattingEnabled = true;
            this.lbArquivos.Location = new System.Drawing.Point(12, 47);
            this.lbArquivos.Name = "lbArquivos";
            this.lbArquivos.Size = new System.Drawing.Size(241, 147);
            this.lbArquivos.TabIndex = 3;
            this.lbArquivos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbArquivos_MouseDown);
            // 
            // btnDiretorioSaida
            // 
            this.btnDiretorioSaida.Location = new System.Drawing.Point(227, 215);
            this.btnDiretorioSaida.Name = "btnDiretorioSaida";
            this.btnDiretorioSaida.Size = new System.Drawing.Size(26, 23);
            this.btnDiretorioSaida.TabIndex = 4;
            this.btnDiretorioSaida.Text = "...";
            this.btnDiretorioSaida.UseVisualStyleBackColor = true;
            this.btnDiretorioSaida.Click += new System.EventHandler(this.btnDiretorioSaida_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 199);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Diretório de Saída";
            // 
            // cbxTipoConvert
            // 
            this.cbxTipoConvert.FormattingEnabled = true;
            this.cbxTipoConvert.Location = new System.Drawing.Point(349, 83);
            this.cbxTipoConvert.Name = "cbxTipoConvert";
            this.cbxTipoConvert.Size = new System.Drawing.Size(71, 21);
            this.cbxTipoConvert.TabIndex = 6;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(263, 86);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(80, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Converter para:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 257);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cbxTipoConvert);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnDiretorioSaida);
            this.Controls.Add(this.lbArquivos);
            this.Controls.Add(this.txtDiretorioSaida);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.buttonSelecionarArquivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SvgConvert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelecionarArquivos;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtDiretorioSaida;
        private System.Windows.Forms.ListBox lbArquivos;
        private System.Windows.Forms.Button btnDiretorioSaida;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbxTipoConvert;
        private System.Windows.Forms.Label lbl2;
    }
}

