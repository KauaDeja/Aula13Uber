namespace Aula13uber
{
    public class Conta : Motorista
    {
        public string agencia { get; set; }
        private string conta { get; set; }
        public string Cadastrar(){
            return "Conta cadastrada";
        }
        public void Excluir(){
            System.Console.WriteLine("Conta excluída com sucesso");
        }
    }

}