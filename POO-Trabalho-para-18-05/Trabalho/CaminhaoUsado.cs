using System;
using System.Collections.Generic;
using System.Text;


    class CaminhaoUsado:VeiculoUsado
    {
    private int capacidade;
    private int nroEixos;

    public override void imprimirDepreciacao()
    {
        System.Diagnostics.Debug.WriteLine("Depreciação: " + calcularDepreciacao(Valor));
    }

    public void imprimirDados()
    {
        base.imprimirDados();
        System.Diagnostics.Debug.WriteLine("Capacidade (pessoas): " + Capacidade);
        System.Diagnostics.Debug.WriteLine("Eixos: " + NroEixos);
        imprimirDepreciacao();
    }
    public CaminhaoUsado() { }
    public CaminhaoUsado(string mod, int ano, float val, int cap, int ne) {
        base.Modelo = mod;
        base.AnoFabric = ano;
        base.Valor = val;
        this.capacidade = cap;
        this.nroEixos = ne;
    
    }


    public override float calcularDepreciacao(float val)
    {
        float resultado;
        resultado = val - (val * 0.3f);
        return resultado;
    }
    public int Capacidade
    {
        get { return capacidade; }
        set { capacidade = value; }
    }

    public int NroEixos
    {
        get { return nroEixos; }
        set { nroEixos = value; }
    }

    }

