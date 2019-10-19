using System;

class MainClass {
  
  private static Clinica clinica = new Clinica(1, "Clinica para Doação de sangue");

  public static void Main (string[] args){
  
    Loop();
  }

  public static void Loop(){

    try{

      while(true){

        Console.Clear();
        Console.WriteLine(clinica.getNome());
        Console.WriteLine("----------------------------------");
        Console.WriteLine("1 - Cadastrar doador");
        Console.WriteLine("2 - Cadastrar receptor");
        Console.WriteLine("3 - Realiza doação");
        Console.WriteLine("4 - Imprimir recptores na fila");
        Console.WriteLine("5 - Imprimir doadores na fila");
        Console.WriteLine("6 - Imprimir registros de doações");
        Console.WriteLine("7 - Deseja sair\n");
        Console.WriteLine("----------------------------------");

        Console.Write("Escolha: ");
        char escolha = char.Parse(Console.ReadLine());

        
        string nome = "";
        string tipo = "";
        int idade = 0;
        float altura = 0.0f;
        int codigoDoador = -999;
        int codigoRecptor = -999;
        
        switch(escolha){

          case '1':
            Console.Clear();
            Console.WriteLine("Cadastrando doador:");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o tipo sanguineo: ");
            tipo = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite digite a peso: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");

            clinica.addDoador(new Doador(nome, tipo.ToUpper(), idade, altura));
            break;
          
          case '2':

            Console.Clear();
            Console.WriteLine("Cadastrando receptor:");
            Console.WriteLine("----------------------------------");

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o tipo sanguineo: ");
            tipo = Console.ReadLine();

            clinica.addReceptor(new Receptor(nome, tipo.ToUpper(), 1));

            Console.WriteLine("----------------------------------");
            break;
          
          case '3':
            Console.Clear();
            Console.WriteLine("Para realiaza uma doação é necessario\ndigitar o codigo do recptor e doador\nde acordo com a fila.");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite o codigo doador: ");
            codigoDoador = int.Parse(Console.ReadLine());
            Console.Write("Digite o codigo recptor: ");
            codigoRecptor = int.Parse(Console.ReadLine());

            Console.WriteLine("Doação realizada: " + clinica.doarSangue(codigoDoador, codigoRecptor));

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Utilize a função 6 para analisar os registros.");
            Console.Write("Digite entre para voltar.");
            Console.ReadLine();
            break;
          case '4':
            Console.Clear();
            Console.WriteLine("----------------------------------");
            clinica.imprimirCadastros('r');
            Console.WriteLine("----------------------------------");
            Console.Write("Digite entre para voltar.");
            Console.ReadLine();
            break;
          case '5':
            Console.Clear();
            Console.WriteLine("----------------------------------");
            clinica.imprimirCadastros('d');
            Console.WriteLine("----------------------------------");
            Console.Write("Digite entre para voltar.");
            Console.ReadLine();
            break;
          case '6':
            Console.Clear();
            Console.WriteLine("----------------------------------");
            ComunicaoArquivo.leia("registro_doacoes.txt");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite entre para voltar.");
            Console.ReadLine();
            break;
          case '7':
            Console.Clear();
            Environment.Exit(1);
            break;
          default:
            Console.WriteLine("\n Realize uma escolha.");
            break;
        } 
      }
    } catch (Exception e){

      Console.WriteLine("\nErro inesperado: " + e.Message);

      Console.WriteLine("\nClique 'entre' para renicia o sistema.");
      Console.ReadLine();
      Loop();
    }
  }
}