namespace DesafioPOO.Models
{
   
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string _modelo, string _imei, int _memoria) : base(numero, _modelo, _imei, _memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no Iphone");
        }
    }
}