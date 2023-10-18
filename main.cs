using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

class Program {
  public static async Task Main (string[] args) {
    Console.WriteLine("Quer um conselho ? s/n :");
    string resposta = Console.ReadLine();
    if(resposta.Trim().ToUpper() == "S"){
      Console.WriteLine("Então toma: ");
    }else{
      Console.WriteLine("Você quer sim, toma: ");
    }
    AdviceServices adviceServices = new AdviceServices();
    AdviceResponse adviceEncontrado = await adviceServices.Integracao();
      Console.WriteLine(adviceEncontrado.slip.advice);
  }
}
