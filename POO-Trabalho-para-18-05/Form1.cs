using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Trabalho_para_18_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeiculoUsado carrohondafit = new VeiculoUsado("Carrro - Honda Fit", 2016, 36000f);
            System.Diagnostics.Debug.WriteLine("Veiculo Usado!");
            carrohondafit.imprimirDados();
            carrohondafit.imprimirDepreciacao();
            CaminhaoUsado caminhao = new CaminhaoUsado("Ford F-600", 1971, 50000F, 2, 4);
            System.Diagnostics.Debug.WriteLine("Caminhao Usado!");
            caminhao.imprimirDados();
            caminhao.imprimirDepreciacao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random al = new Random();
            int ale;
            ale = al.Next(1, 3);
            Veiculo v1 = new Veiculo();
            v1.Proprietario = "Diego Dreossi";
            v1.Marca = "Ford";
            v1.NroPortas = 4;
            v1.VelMax = 280;
            v1.VelAtual = v1.VelMax;//Função escolhe numero aleatorio para vel atual
            v1.Cor = "Verde";
            v1.Ano = 2015;
            v1.Modelo = "KA";
            v1.Qntmarchas = 5;
            v1.MarchaAtual = v1.Qntmarchas;//Função escolhe numero aleatorio
            v1.imprimirDados();

            System.Diagnostics.Debug.WriteLine("\n");

            
            if(ale == 1)
            {
                System.Diagnostics.Debug.WriteLine("Acelerando");
                v1.acelerar();
                v1.imprimirDados();
            }else if(ale == 2)
            {
                System.Diagnostics.Debug.WriteLine("Mudando marcha");
                v1.AlterarMarcha();
                v1.imprimirDados();
            }else if(ale == 3)
            {
                System.Diagnostics.Debug.WriteLine("Freando");
                v1.frear();
                v1.imprimirDados();
            }


            

        }
    }
}
