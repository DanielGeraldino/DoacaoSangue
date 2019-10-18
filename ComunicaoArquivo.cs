using System.IO;
using System;

class ComunicaoArquivo {

  //caminho da pasta de arquivos
  private static string PATH = "./ARQUIVO/";

  //metodo para escreve um texto e em um arquivo
  public static void escreva(string texto, string nomeArq){

    try{

      using(StreamWriter sw = File.AppendText(PATH + nomeArq)){
        sw.WriteLine(DateTime.Now + " " + texto);
      }
    } catch(Exception e){

      Console.WriteLine("Erro: " + e.Message);
    }
  }

  //metodo para leia o um arquivo e imprimir no console
  public static void leia(string nomeArq){

    try{

      using(StreamReader sr = new StreamReader(PATH + nomeArq)){

        string linha = "";

        while((linha = sr.ReadLine()) != null){
          Console.WriteLine(linha);
        }
      }
    } catch (Exception e){

      Console.WriteLine("Erro: " + e);
    }
  }
}