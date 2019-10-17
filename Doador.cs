class Doador {

    public string nome { get; private set; }
    public TiposSanguineos tipoSangue { get; private set; }
    public int idade { get; private set; }
    public float peso { get; private set; }

    public Doador(string nome, string tipoS, int idade, float peso){
        this.nome = nome;
        this.tipoSangue = new TiposSanguineos(tipoS);
        this.idade = idade;
        this.peso = peso;
    }

    public bool podeDoar(){
        if((idade >= 18 && idade < 70) && peso > 50)
        {
            return true;
        }
        return false;
    }

    public string imprimirTipoSangue(){
      return tipoSangue.tipo;
    }

    public string imprimirDados(){
      return $"{nome},{imprimirTipoSangue()},{idade},{peso}";
    }
}

