using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_App
{
    public partial class Tela_calculadora : Form
    {
        public Tela_calculadora()
        {
            InitializeComponent();
        }
        private void Tela_calculadora_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush degrade = new LinearGradientBrush(
                new Point(0, 0),
                new Point(panel1.Height, panel1.Width),
                Color.FromArgb(220, 66, 66),
                Color.FromArgb(203, 110, 58)
            );
            Graphics cor = e.Graphics;
            cor.FillRectangle(degrade, panel1.ClientRectangle);
        }

        private void Botoes_acionados(object sender, EventArgs e)
        {
            Button valores_botoes = sender as Button;
            richTextBox1.Text += Convert.ToString(valores_botoes.Tag);
        }

        private void Executa_operacao(object sender, EventArgs e)
        {
            double res = 0.00d;
            char[] possiveis_operacoes = { '+', '-', '*', '/' };
            string[] res_operacao = richTextBox1.Text.Split(possiveis_operacoes);

            if (richTextBox1.Text.Contains('+'))
            {
                try
                {
                    res = Convert.ToDouble(res_operacao[0]) + Convert.ToDouble(res_operacao[1]);
                }
                catch
                {
                    MessageBox.Show("Houve um Erro Desligando o programa...");
                    Application.Exit();
                }
            }
            else if (richTextBox1.Text.Contains('-'))
            {
                try
                {
                    res = Convert.ToDouble(res_operacao[0]) - Convert.ToDouble(res_operacao[1]);
                }
                catch
                {
                    MessageBox.Show("Houve um Erro Desligando o programa...");
                    Application.Exit();
                }
            }
            else if (richTextBox1.Text.Contains('*'))
            {
                try
                {
                    res = Convert.ToDouble(res_operacao[0]) * Convert.ToDouble(res_operacao[1]);
                }
                catch
                {
                    MessageBox.Show("Houve um Erro Desligando o programa...");
                    Application.Exit();
                }
            }
            else if (richTextBox1.Text.Contains('/'))
            {
                try
                {
                    res = Convert.ToDouble(res_operacao[0]) / Convert.ToDouble(res_operacao[1]);
                }
                catch
                {
                    MessageBox.Show("Houve um Erro Desligando o programa...");
                    Application.Exit();
                }
            }
            richTextBox1.Text = Convert.ToString(res);
        }

        private void Apagar_tudo(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}