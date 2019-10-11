class Doador {
    private string nome;
    private TiposSanguineos tipoSangue;
    private int idade;
    private float peso;

    public Doador(string nome, TiposSanguineos tipoS, int idade, float peso)
    {
        this.nome = nome;
        this.tipoSangue = tipoS;
        this.idade = idade;
        this.peso = peso;
    }

    public bool podeDoar()
    {
        if((idade >= 18 && idade < 70) && peso > 50)
        {
            return true;
        }
        return false;
    }
}

