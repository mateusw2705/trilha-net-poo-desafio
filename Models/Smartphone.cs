namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Imei { get; set; }
        private string Modelo { get; set; }
        private int Memoria {  get; set; }

        public Smartphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
            modelo = "iOS"; 
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}