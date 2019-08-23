using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaração de variaveis globais
        String op, n1, n2, res;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //radiobutton 'simples'
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;

            //musa a posição do radiobutton
            this.radioButton1.Location = new Point(261, 12);
            this.radioButton2.Location = new Point(261, 40);

            //muda o tamanho do form1
            this.Size = new Size(360, 326);
        }

        //radiobutton 'completa'
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;

            //muda a posição do radiobutton
            this.radioButton1.Location = new Point(339, 12);
            this.radioButton2.Location = new Point(339, 40);

            //muda o tamanho do form1
            this.Size = new Size(450, 326);
    
         }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        //button +
        private void button13_Click(object sender, EventArgs e)
        {
            //leitura do conteúdo ditado na texbox1
            //E atribuição á variavel n1

            n1 = textBox1.Text;

            //atribuição de operação soma à variavel OP

            op = "+";

            //limpar a tela
            textBox1.Text = "";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //leitura do conteúdo ditado na texbox1
            //E atribuição á variavel n1

            n1 = textBox1.Text;

            //atribuição de operação soma à variavel OP

            op = "-";

            //limpar a tela
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //leitura do conteúdo ditado na texbox1
            //E atribuição á variavel n1

            n1 = textBox1.Text;

            //atribuição de operação soma à variavel OP

            op = "X";

            //limpar a tela
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //leitura do conteúdo ditado na texbox1
            //E atribuição á variavel n1

            n1 = textBox1.Text;

            //atribuição de operação soma à variavel OP

            op = "/";

            //limpar a tela
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //leitura do conteúdo ditado na texbox1
            //E atribuição á variavel n2

            n2 = textBox1.Text;

            //Testa se o button + foi usado
            if (op == "+")
                res = Convert.ToString(
                    Convert.ToDouble(n1)
                    +
                    Convert.ToDouble(n2)
                    );

            //Testa se o button - foi usado
            if (op == "-")
                res = Convert.ToString(
                    Convert.ToDouble(n1)
                    -
                    Convert.ToDouble(n2)
                    );
            
            //Testa se o button X foi usado
            if (op == "x")
                res = Convert.ToString(
                    Convert.ToDouble(n1)
                    *
                    Convert.ToDouble(n2)
                    );

            //Testa se o button / foi usado
            if (op == "/")
                res = Convert.ToString(
                    Convert.ToDouble(n1)
                    /
                    Convert.ToDouble(n2)
                    );
            textBox1.Text = res; 
        }


        //button M - Salva o valor da Tela em um arquivo de texto
        private void button18_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"M.txt", textBox1.Text);
            label1.Text = "M";
        }

        //Button RM - Mostra o conteúdo do arquivo de texto na 
        //textbox1.
        private void button19_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"M.txt") == true)
                if (System.IO.File.ReadAllText(@"M.txt") != "")
                    textBox1.Text = System.IO.File.ReadAllText(@"M.txt");
        }


        //button CM - Apaga o conteúdo do arquivo de texto e
        //'esconde' a label1
        private void button20_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(@"M.txt");
            label1.Text = "";
        }

        //button C - Limpa a tela
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //button Desligar
        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
    }
}
