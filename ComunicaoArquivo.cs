using System.IO;
using System;

class ComunicaoArquivo {

  private static string PATH = "./ARQUIVO/";

  public static void escreva(string texto, string nomeArq){
    using(StreamWriter sw = File.AppendText(PATH + nomeArq)){
      sw.WriteLine(DateTime.Now + " " + texto);
    }
  }
}