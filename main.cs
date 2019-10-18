using System;

class MainClass {
  public static void Main (string[] args){
  
    Clinica clinica = new Clinica(1, "Clinica para Doação de sangue");

    while(true){

      Console.Clear();
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

          clinica.addDoador(new Doador(nome, tipo, idade, altura));
          break;
        
        case '2':

          Console.Clear();
          Console.WriteLine("Cadastrando receptor:");
          Console.WriteLine("----------------------------------");

          Console.Write("Digite o nome: ");
          nome = Console.ReadLine();

          Console.Write("Digite o tipo sanguineo: ");
          tipo = Console.ReadLine();

          clinica.addReceptor(new Receptor(nome, tipo, 1));

          Console.WriteLine("----------------------------------");
          break;
        
        case '3':
          // doar
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
  }
}