namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}