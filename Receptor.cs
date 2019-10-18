class Receptor{

  public string nome { get; private set; }
  public TiposSanguineos tipoSangue { get; private set; }
  public int prioridade { get; private set; }

  public Receptor(string nome, string tipoSangue, int prioridade){
    this.nome = nome;
    this.prioridade = prioridade;
    this.tipoSangue = new TiposSanguineos(tipoSangue);
  }

  public bool podeReceber(string tipo){
    return tipoSangue.podeReceber(tipoSangue.tipo, tipo);
  }

  public string getTipoSanguineo(){
    return tipoSangue.tipo;
  }

  public string getNome(){
    return nome;
  }

  public string imprimirDados(){
    return $"{nome},{getTipoSanguineo()},{prioridade}";
  }
  
}

