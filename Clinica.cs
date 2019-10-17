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

  public void addDoador(Doador doador){
    this.doadores.Add(doador);
  }

  public void addDoador(string nome, string tipoSangue, int idade, float peso){
    Doador doador = new Doador(nome, tipoSangue, idade, peso);
    doadores.Add(doador);
  }

  public void addReceptor(Receptor recptor){
    this.recptores.Add(recptor);
  }

  public void addReceptor(string nome, string tipoSangue, int prioridade){
    Receptor recptor = new Receptor(nome, tipoSangue, prioridade);
    recptores.Add(recptor);
  }
}