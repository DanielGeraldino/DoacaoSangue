using System;

class MainClass {
  public static void Main (string[] args){

    TiposSanguineos tipos = new TiposSanguineos();
              
    Console.WriteLine(tipos.podeReceber("B-", "A+"));
  }
}