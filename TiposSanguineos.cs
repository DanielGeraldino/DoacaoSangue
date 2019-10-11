using System;

class TiposSanguineos
{                                           //0    1      2     3     4       5     6     7
    public string[] tipos = new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "O-" };

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

        aux = new string[] { "teste" };
        return aux;
    }

    //Retorna verdadeiro se o receptor poder receber o tipo do doador
    public bool podeReceber(string tipoDoador, string tipoRecptor)
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
}


