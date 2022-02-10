namespace Calculadora_App
{
    partial class Tela_calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_calculadora));
            this.panel1 = new System.Windows.Forms.Panel();
            this.num0 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_ponto = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btn_apagar);
            this.panel1.Controls.Add(this.btn_ponto);
            this.panel1.Controls.Add(this.btn_igual);
            this.panel1.Controls.Add(this.num0);
            this.panel1.Controls.Add(this.num9);
            this.panel1.Controls.Add(this.num8);
            this.panel1.Controls.Add(this.num7);
            this.panel1.Controls.Add(this.num6);
            this.panel1.Controls.Add(this.num5);
            this.panel1.Controls.Add(this.num4);
            this.panel1.Controls.Add(this.num3);
            this.panel1.Controls.Add(this.num2);
            this.panel1.Controls.Add(this.num1);
            this.panel1.Controls.Add(this.btn_divisao);
            this.panel1.Controls.Add(this.btn_multiplicacao);
            this.panel1.Controls.Add(this.btn_subtracao);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.btn_soma);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.Control;
            this.num0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num0, "num0");
            this.num0.Name = "num0";
            this.num0.Tag = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.Control;
            this.num9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num9, "num9");
            this.num9.Name = "num9";
            this.num9.Tag = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.Control;
            this.num8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num8, "num8");
            this.num8.Name = "num8";
            this.num8.Tag = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.Control;
            this.num7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num7, "num7");
            this.num7.Name = "num7";
            this.num7.Tag = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.Control;
            this.num6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num6, "num6");
            this.num6.Name = "num6";
            this.num6.Tag = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.Control;
            this.num5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num5, "num5");
            this.num5.Name = "num5";
            this.num5.Tag = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.Control;
            this.num4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num4, "num4");
            this.num4.Name = "num4";
            this.num4.Tag = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.Control;
            this.num3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num3, "num3");
            this.num3.Name = "num3";
            this.num3.Tag = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Control;
            this.num2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num2, "num2");
            this.num2.Name = "num2";
            this.num2.Tag = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Control;
            this.num1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.num1, "num1");
            this.num1.Name = "num1";
            this.num1.Tag = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // btn_divisao
            // 
            this.btn_divisao.BackColor = System.Drawing.SystemColors.Control;
            this.btn_divisao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_divisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.btn_divisao, "btn_divisao");
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Tag = "/";
            this.btn_divisao.UseVisualStyleBackColor = false;
            this.btn_divisao.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.BackColor = System.Drawing.SystemColors.Control;
            this.btn_multiplicacao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_multiplicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.btn_multiplicacao, "btn_multiplicacao");
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Tag = "*";
            this.btn_multiplicacao.UseVisualStyleBackColor = false;
            this.btn_multiplicacao.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.BackColor = System.Drawing.SystemColors.Control;
            this.btn_subtracao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_subtracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.btn_subtracao, "btn_subtracao");
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Tag = "-";
            this.btn_subtracao.UseVisualStyleBackColor = false;
            this.btn_subtracao.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // btn_soma
            // 
            this.btn_soma.BackColor = System.Drawing.SystemColors.Control;
            this.btn_soma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_soma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.btn_soma, "btn_soma");
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Tag = "+";
            this.btn_soma.UseVisualStyleBackColor = false;
            this.btn_soma.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.SystemColors.Control;
            this.btn_igual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_igual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.btn_igual, "btn_igual");
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Tag = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.Executa_operacao);
            // 
            // btn_ponto
            // 
            this.btn_ponto.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ponto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ponto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.btn_ponto, "btn_ponto");
            this.btn_ponto.Name = "btn_ponto";
            this.btn_ponto.Tag = ".";
            this.btn_ponto.UseVisualStyleBackColor = false;
            this.btn_ponto.Click += new System.EventHandler(this.Botoes_acionados);
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_apagar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_apagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.btn_apagar, "btn_apagar");
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Tag = "apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.Apagar_tudo);
            // 
            // Tela_calculadora
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tela_calculadora";
            this.Load += new System.EventHandler(this.Tela_calculadora_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_ponto;
        private System.Windows.Forms.Button btn_apagar;
    }
}

