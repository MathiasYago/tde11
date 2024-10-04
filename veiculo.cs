public class veiculo
{
    protected string marca;
    protected string modelo;

    protected int ano;

    public veiculo(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }
    
    public void Ligar()
    {
        Console.WriteLine("o veiculo esta ligado");
    }
    public void Desligar()
    {
        Console.WriteLine("o carro está desligado");
    }

    }
