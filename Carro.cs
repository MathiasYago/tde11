public class Carro : veiculo
{
 private  int numDePortas;

 public Carro(string marca,string modelo, int ano, int numDePortas)
 :base(marca, modelo, ano)
 {
    this.numDePortas = numDePortas;
 }
 
 public void AbrirPortaMalas()
 {
    Console.WriteLine("Porta malas está aberto");
 }
 public void ExiberInformacoes()
 {
    Console.WriteLine($"marca: {marca}, modelo:{modelo}, ano:{ano}, numDePortas:{numDePortas}");
 }
}