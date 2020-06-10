namespace Aula13uber
{
    public class Motorista : Usuario
    {
       public string carro { get; set; }

       public string placa { get; set; }
       

       public string aceitarPassageiro(){
           return "Aceitando passageiro";
       }
       public bool receberPagamento(string statusCorrida){
           if(statusCorrida == "finalizada"){
               return true;
           }
           return false;
       }
    }
}