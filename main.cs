using System;

class MainClass {
  public static void Main (string[] args){

    Clinica clinica = new Clinica(1, "Clinica para Doação de sangue");

    Receptor receptor = new Receptor("Daniel", "A-", 1);
    Doador doador = new Doador("Joao", "O-", 18, 78.0f);

    clinica.addDoador(doador);
    clinica.addReceptor(receptor);

    clinica.imprimirCadastros('d');
    clinica.imprimirCadastros('r');

    Console.WriteLine("Executando a doação");
    clinica.doarSangue(doador, receptor);
    
    clinica.imprimirCadastros('d');

  }
}