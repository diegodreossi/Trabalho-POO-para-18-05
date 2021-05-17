
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Veiculo
{
    private string marca, modelo, proprietario, cor;
    private int ano, qntmarchas, marchaAtual, nroPortas, chassi;
    private int velMax, velAtual;

    //Falta imprimir os dados
    public void imprimirDados()
    {
        if (MarchaAtual == 0)
        {
            VelAtual = 0;
        }
        System.Diagnostics.Debug.WriteLine("Proprietário: " + Proprietario);
        System.Diagnostics.Debug.WriteLine("Marca: " + Marca);
        System.Diagnostics.Debug.WriteLine("Modelo: " + Modelo);
        System.Diagnostics.Debug.WriteLine("Ano: " + Ano);
        System.Diagnostics.Debug.WriteLine("Chassi:" + Chassi);
        System.Diagnostics.Debug.WriteLine("Numero de portas: " + NroPortas);
        System.Diagnostics.Debug.WriteLine("Cor: " + Cor);
        System.Diagnostics.Debug.WriteLine("Quantidade de marchas: " + Qntmarchas);
        System.Diagnostics.Debug.WriteLine("Marcha Atual: " + MarchaAtual);
        System.Diagnostics.Debug.WriteLine("Velocidade Maxima: " + VelMax);
        System.Diagnostics.Debug.WriteLine("Velocidade atual: " + VelAtual);
    }
    public void acelerar()
    {
        this.velAtual = this.velAtual + 10;
    }

    public void frear()
    {
       VelAtual = 0;
       MarchaAtual = 0;
    }

    public void AlterarMarcha()
    {
        int mt;//marcha temporaria
        do
        {
            Random na4 = new Random();
            
            mt = na4.Next(0,Qntmarchas);

            if(mt > Qntmarchas)
            {
                MessageBox.Show("Marcha invalida!","Marcha"
                ,MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                mt = this.marchaAtual;
            }
           
        } while (mt == this.marchaAtual);

        

        if(mt ==0)
        {
            MessageBox.Show("Marcha 0 selecionada. Iremos frear para poder dar ré", "Marcha"
                , MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            frear();
        }

        this.marchaAtual = mt;

        if (MarchaAtual != 0 && this.velAtual == 0)
        {
            this.velAtual++;
        }

    }

    public Veiculo()
    {
        Random na = new Random();        
        this.chassi = na.Next(1, 1000);

    }

    public int VelMax
    {
        get { return velMax; }
        set { velMax = value; }
    }

    public int VelAtual
    {
        get { return velAtual; }
        set
        {
           
              Random na2 = new Random();
              velAtual = na2.Next(0, value);
             
            
        }
    }
    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    public int NroPortas
    {
        get { return nroPortas; }
        set { nroPortas = value; }
    }

    public int Chassi
    {
        get { return chassi; }
    }
    public int MarchaAtual
    {
        get { return marchaAtual; }
        set
        {
            Random na3 = new Random();

            marchaAtual = na3.Next(0, value);
        }
    }
    public int Qntmarchas
    {
        get { return qntmarchas; }
        set { qntmarchas = value; }
    }


    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public string Proprietario
    {
        get { return proprietario; }
        set { proprietario = value; }
    }

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }

}

