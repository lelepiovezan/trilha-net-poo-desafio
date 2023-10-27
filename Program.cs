using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia n1 = new Nokia("1234-5678","Nokia","234323432423424",256);
n1.Ligar();
n1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone i1 = new Iphone("3454-3455","Iphone","2343243243223",512);
i1.ReceberLigacao();
i1.InstalarAplicativo("Telgran");