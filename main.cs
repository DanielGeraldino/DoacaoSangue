using System;

class MainClass {
  public static void Main (string[] args){
    /*

    //bool podeDoar = receptor.podeReceber(doador.tipoSangue.tipo);
    if(receptor.podeReceber(doador.tipoSangue.tipo) && doador.podeDoar()){
      Console.WriteLine($"O doador {doador.nome} tem o sangue do tipo {doador.imprimirTipoSangue()} \ne o recptor {receptor.nome} tem o sangue do tipo {receptor.imprimirTipoSangue()}.\n\n {doador.nome} pode doar para {receptor.nome}: {receptor.podeReceber(doador.imprimirTipoSangue())}");

    }
    */

    Clinica clinica = new Clinica(1, "Clinica para Doação de sangue");

    Receptor receptor = new Receptor("Daniel", "O+", 1);
    Doador doador = new Doador("Joao", "O-", 18, 78.0f);

    clinica.addDoador(doador);
    clinica.addReceptor(receptor);

    clinica.imprimirDoadores();

  }
}