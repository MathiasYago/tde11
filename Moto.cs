public class Moto: veiculo
{
    private bool TemBagageiro;


 public Moto (string marca, string modelo, int ano, bool TemBagageiro) :base(marca, modelo, ano)
{
    this.TemBagageiro = TemBagageiro;
}
public void DarGrau()
{
    Console.WriteLine("onomatopeia");
}
public void ExiberInformacoes()
{
 Console.WriteLine($"marca: {marca}, modelo: {modelo}, ano {ano}");
}
}