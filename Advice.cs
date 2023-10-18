using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

internal class Slip{
  public int id{get; set;}
  public string advice{get; set;}
}

internal class AdviceResponse
{
    public Slip slip { get; set; }
}
