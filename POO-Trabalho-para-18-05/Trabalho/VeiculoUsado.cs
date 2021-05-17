using System;
using System.Collections.Generic;
using System.Text;


    class VeiculoUsado
    {
    private string modelo;
    private int anoFabric;
    private float valor;
    private float depreciacao;

    public virtual float calcularDepreciacao(float val)
    {
        float resultado;
        resultado = val - (val * 0.1f);
        return resultado;
    }
    public VeiculoUsado() { }

    public VeiculoUsado(string mod, int ano, float val)
    {
        this.modelo = mod;
        this.anoFabric = ano;
        this.valor = val;
        this.depreciacao = calcularDepreciacao(val);
    }

    

    public void imprimirDados()
    {
        System.Diagnostics.Debug.WriteLine("Modelo: " + Modelo);
        System.Diagnostics.Debug.WriteLine("Ano de fabricação: " + AnoFabric);
        System.Diagnostics.Debug.WriteLine("Valor do veiculo: " + Valor);
    }

    public virtual void imprimirDepreciacao()
    {
        System.Diagnostics.Debug.WriteLine("Depreciação: " + calcularDepreciacao(Valor));
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public float Depreciacao { get { return depreciacao = calcularDepreciacao(this.valor); } }

    public int AnoFabric
    {
        get { return anoFabric; }
        set { anoFabric = value; }
    }

    public float Valor
    {
        get { return valor; }
        set { valor = value;
              //depreciacao = calcularDepreciacao(value);
        }

    }
    }

