
using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;

public class Ex8
{
    public double vp;
    public double juros;
    public double vf;
    public int periodo;
    private string linha = "|-----------------------------------------|";
    public Ex8(double vp, double juros, int periodo)
    {
        SetValorPresente(vp);
        SetJuros(juros);
        SetPeriodo(periodo);
        vf = vp;
    }
    public Ex8()
    {
        vf = vp;
    }
    public void SetValorPresente(double v)
    {
        if (v <= 0)
        {
            throw new Exception("Saldo não pode ser menor ou igual que 0 ");
        }
        vp = v;
    }

    public double GetValorPresente()
    {
        return vp;
    }
    
    
    public void SetJuros(double j)
    {
        if (j <= 0)
        {
            throw new Exception("Juros não pode ser menor ou igual que 0 ");
        }
        this.juros = j;
    }
    public double GetJuros()
    {
        return juros;
    }
    public void SetPeriodo(int p)
    {
        if (p <= 0)
        {
            throw new Exception("Periodo não pode ser menor ou igual que 0 ");
        }
        this.periodo = p;
    }
    public int GetPeriodo()
    { 
        return periodo;
    }
    public void CalculaJuros()
    {
        int i = 0;
        int mes = 0;
        while (i < periodo)
        {
            vf = vf + (vf * juros);
            i++;
            mes++;
            Console.WriteLine(linha);
            Console.WriteLine($"  Mês {mes} |  R${vf}");
        }
    }
    }



public class Iniciar
{
    static void Main() 
    {
        Ex8 e1 = new();
        Console.WriteLine(">> CALCULADORA DE JUROS ORIENTADA A OBJETOS << \r\n");
        Console.WriteLine("Digite o valor presente\r\n");
        e1.SetValorPresente(double.Parse(Console.ReadLine())); 
        e1.vf = e1.vp;

        Console.WriteLine("Digite a taxa de juros\r\n");
        e1.SetJuros(double.Parse(Console.ReadLine())/100);


        Console.WriteLine("Digite o período em meses\r\n");
        e1.SetPeriodo(Convert.ToInt16(Console.ReadLine()));

        Console.WriteLine($"Seus dados de entrada foram: Valor presente : R${e1.GetValorPresente()} | Taxa de Juros: {e1.GetJuros()}   | Perido em meses : {e1.GetPeriodo()}");
        Console.WriteLine("\r\nDeseja alterar algum dado? s/n");
        string opcao = Console.ReadLine();

        if (opcao == "s")
        {
            Console.WriteLine("Qual das opções?\r\n 1 - Valor Final \r\n 2 - Taxa de Juros \r\n 3 - Periodo");
            
            int entrada = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual será o novo?");
            switch (entrada)
            {
            case 1: e1.SetValorPresente(double.Parse(Console.ReadLine()));
                    e1.vf = e1.vp;
                    break;
            case 2: e1.SetJuros(double.Parse(Console.ReadLine()) / 100);
                    break;
            case 3: e1.SetPeriodo(Convert.ToInt16(Console.ReadLine()));
                    break;
            }

            Console.WriteLine($"Seus dados de entrada foram: Valor presente : R${e1.GetValorPresente()} | Taxa de Juros: {e1.GetJuros()}   | Perido em meses : {e1.GetPeriodo()}\r\n");
        }
        else{
            Console.WriteLine("Certo... Gerando Resultado \r\n");
        }

        e1.CalculaJuros();

        Console.WriteLine("\r\n-----------FIM------------");
    }
}



/*public double getValor()
       {
           return e.getValorPresente();
       }
       public void setValor(double v)
       {
           e.setValorPresente(v);
       }

       public double getJuros()
       {
           return e.getJuros();
       }
       public void setJuros(double j)
       {
           e.setJuros(j);
       }

       public int getPeriodo()
       {
           return e.getPeriodo();
       }

       public void setPeriodo(int p)
       {
           e.setPeriodo(p);
       }*/