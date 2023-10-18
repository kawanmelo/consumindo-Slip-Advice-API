using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

internal class AdviceServices{
  public async Task<AdviceResponse> Integracao(){
    HttpClient httpClient = new HttpClient();
    var response = await httpClient.GetAsync("https://api.adviceslip.com/advice");
    var jsonString = await response.Content.ReadAsStringAsync();
    AdviceResponse jsonObject = JsonSerializer.Deserialize<AdviceResponse>(jsonString);
    if(jsonObject != null){
      return jsonObject;
    }else{
      return new AdviceResponse{};
    }
  }
}