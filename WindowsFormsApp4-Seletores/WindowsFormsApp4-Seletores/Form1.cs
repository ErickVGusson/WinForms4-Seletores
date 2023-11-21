using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_Seletores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double numero = double.Parse(txbNumero1.Text);
            bool comDesc = ckbDesc.Checked;
            bool comAlerta = ckbAlerta.Checked;
            string desc = "", mensagem = "";

            if (radioCelFah.Checked)
            {

                double Fahrenheit = 0;

                Fahrenheit = (numero * 1.8) + 32;

                if (comDesc)
                {

                    desc = " Fahrenheit";

                }

                mensagem = Fahrenheit.ToString() + desc;

                if (comAlerta)
                {

                    MessageBox.Show(mensagem);

                }

                labelResultado.Text = mensagem;

            }

            if (radioCelKel.Checked)
            {

                double kelvin = 0;

                kelvin = numero + 273;

                if (comDesc)
                {

                    desc = " kelvin";

                }

                mensagem = kelvin.ToString() + desc;

                if (comAlerta)
                {

                    MessageBox.Show(mensagem);

                }

                labelResultado.Text = mensagem;


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnContinente_Click(object sender, EventArgs e)
        {

            string continente = "";

            continente = comboBox1.SelectedItem.ToString();

            MessageBox.Show(continente);

        }

        private void btnCheckListBox_Click(object sender, EventArgs e)
        {

            int contador = 0;

            foreach (string elemento in checkedListBox1.CheckedItems)
            {

                MessageBox.Show(elemento);

                contador++;

            }

            MessageBox.Show("A total foram selecionados " +  contador + " items do cheacklistbox");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
