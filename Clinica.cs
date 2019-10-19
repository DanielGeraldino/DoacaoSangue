using System;
using System.Collections.Generic;

class Clinica{
  
  public int idClinica{ get; private set; }
  public string nome { get; private set; }
  public List<Receptor> recptores { get; private set; }
  public List<Doador> doadores { get; private set; }

  public Clinica(int id, string nome){
    this.idClinica = id;
    this.nome = nome;
    this.recptores = new List<Receptor>();
    this.doadores = new List<Doador>();
  } 

  //Metodo para adicionar doador na lista de doares
  public void addDoador(Doador doador){
    this.doadores.Add(doador);
  }

  public void addDoador(string nome, string tipoSangue, int idade, float peso){
    Doador doador = new Doador(nome, tipoSangue, idade, peso);
    doadores.Add(doador);
  }
  //Metodo para adicionar doador na lista de doares
  public void addReceptor(Receptor recptor){
    this.recptores.Add(recptor);
  }

  public void addReceptor(string nome, string tipoSangue, int prioridade){
    Receptor recptor = new Receptor(nome, tipoSangue, prioridade);
    recptores.Add(recptor);
  }
  //metodo para imprimir no console doadores ou recptores
  public void imprimirCadastros(char escolha){
    
    Console.WriteLine("codigo, nome, sangue, idade, peso");
    int count = 0;

    if(escolha == 'd'){
      foreach(Doador doador in doadores){
        Console.WriteLine(count + " - " + doador.imprimirDados());
        count++;
      }
    } else if(escolha == 'r'){
      foreach(Receptor recptor in recptores){
        Console.WriteLine(count + " - " + recptor.imprimirDados());
        count++;
      }
    }
  }
  //metodo que registra a doarção de sangue
  //public void doarSangue(Doador doador, Receptor recptor){
  public bool doarSangue(int codDoador, int codRecptor){

    bool deuCerto = false;

    Doador doador = doadores[codDoador];
    Receptor recptor = recptores[codRecptor];

    if(doador.podeDoar() && recptor.podeReceber(doador.getTipoSanguineo())){
      
      string registro = $"Doado sangue de {doador.getNome()} do tipo {doador.getTipoSanguineo()} para {recptor.getNome()} do tipo {recptor.getTipoSanguineo()}";

      ComunicaoArquivo.escreva(registro, "registro_doacoes.txt");

      //doadores.RemoveAt(doadores.IndexOf(doador));
      //recptores.RemoveAt(recptores.IndexOf(recptor));

      doadores.RemoveAt(doadores.IndexOf(doador));
      recptores.RemoveAt(recptores.IndexOf(recptor));

      deuCerto = true;

    } else {

      string registro = $"Rejeicao: Sangue, idade ou peso do {doador.getNome()} não permite doar para {recptor.getNome()}, cujo o tipo sanguineo do {doador.getNome()} é {doador.getTipoSanguineo()}";

      ComunicaoArquivo.escreva(registro, "registro_doacoes.txt");

      deuCerto = false;
    }

    return deuCerto;
  }
}