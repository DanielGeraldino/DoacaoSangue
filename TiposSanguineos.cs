using System;

class TiposSanguineos
{                                           //0    1      2     3     4       5     6     7
    private string[] tipos = new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
    public string tipo { get; private set; }

    public TiposSanguineos(string tipo){
      if(validarTipoSanguineo(tipo)){
        this.tipo = tipo;
      } else {
        throw new System.ArgumentException("", "Tipo sanguineo invalidado!");
      }
    }

    // recebe um tipo sanguineo e retorna uma lista de tipos sanguineos que podem receber dos doadores.
    public string[] listarQuemPodeReceber(string tipoRecepto)
    {
        string[] aux;

        if (tipoRecepto == tipos[0])
        {
            aux = new string[] {tipos[0], tipos[1], tipos[6], tipos[7] };
            return aux;
        }
        if (tipoRecepto == tipos[1])
        {
            aux = new string[] { tipos[1], tipos[7] };
            return aux;
        }
        if (tipoRecepto == tipos[2])
        {
            aux = new string[] { tipos[2], tipos[3], tipos[6], tipos[7] };
            return aux;
        }
        if (tipoRecepto == tipos[3])
        {
            aux = new string[] { tipos[3], tipos[7] };
            return aux;
        }
        if (tipoRecepto == tipos[4])
        {
            aux = new string[] { tipos[0], tipos[1], tipos[2], tipos[3], tipos[4], tipos[5], tipos[6], tipos[7] };
            return aux;
        }

        if (tipoRecepto == tipos[5])
        {
            aux = new string[] { tipos[1], tipos[3], tipos[5], tipos[7] };
            return aux;
        }

        if (tipoRecepto == tipos[6])
        {
            aux = new string[] { tipos[6], tipos[7] };
            return aux;
        }

        if (tipoRecepto == tipos[7])
        {
            aux = new string[] { tipos[7] };
            return aux;
        }
        // retorna uma lista vazia se for falsa para todas expressões anteriores 
        aux = new string[0];
        return aux;
    }

    //Retorna verdadeiro se o receptor poder receber o tipo sangue do doador
    public bool podeReceber(string tipoRecptor, string tipoDoador)
    {
        string[] listaPossiveisTiposSanguineos = listarQuemPodeReceber(tipoRecptor);

        for(int i = 0; i < listaPossiveisTiposSanguineos.Length; i++)
        {
            if(listaPossiveisTiposSanguineos[i] == tipoDoador)
            {
                return true;
            }
        }
        return false;
    }

    private bool validarTipoSanguineo(string tipo){
      for(int i = 0; i < tipos.Length; i++){
        if(tipos[i] == tipo){
          return true;
        }
      }
      return false;
    }

}


