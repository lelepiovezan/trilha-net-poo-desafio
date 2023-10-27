namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string _modelo, string _imei, int _memoria) : base(numero, _modelo, _imei, _memoria)
        {
        }

       
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no Nokia");
        }
    }
}