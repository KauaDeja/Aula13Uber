using System;

namespace Aula13uber
{
    class Program
    {
        static void Main(string[] args)
        {
           Passageiro kaua = new Passageiro();

            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            kaua.Login(login, senha);

            if( kaua.TokenLogin != "" && kaua.TokenLogin != null ){
                
                System.Console.WriteLine("Login autorizado!");
                System.Console.WriteLine(kaua.TokenLogin);

            }else{
                System.Console.WriteLine("Não é possível utilizar o app");
            }

            Motorista lucca = new Motorista();
            lucca.carro = "Um Logan 2020";
            lucca.placa = "Sua placa é:\nEPJ1845";
            

            System.Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            System.Console.WriteLine(lucca.aceitarPassageiro() );

            System.Console.WriteLine("Infomrações do veículo:");
            System.Console.WriteLine(lucca.carro);
            System.Console.WriteLine(lucca.placa);

           
        
        }

    }
}
