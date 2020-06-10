namespace Aula13uber
{
    public class Cartao : Passageiro
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        protected string cvv{ get; set; }

        public string Cadastrar(){
            return "conta cadastrada";
        }

        public void Excluir(){
            System.Console.WriteLine("Cartão excluído com sucesso");
        }
    }
}