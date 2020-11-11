using System;

class MainClass {
  public static void Main (string[] args) {
    //INSTANCIAR CLASSE VOTAR
    Votar campanha = new Votar();
    User pessoa = new User();
    Ideia newid = new Ideia();

    Console.WriteLine("Cadastro de Ideia");
    Console.WriteLine("Deseja cadastrar uma ideia? * S * ou * N *");
    char resp = char.Parse(Console.ReadLine().ToUpper());

    if(resp == 'N')
    {
      Console.WriteLine();
      Console.WriteLine("PROGRAMA FINALIZADO");
    }

    if(resp == 'S')
    {
      while(resp == 'S')
      {
        Console.WriteLine("Insira o seu nome: ");
        pessoa.nome = Console.ReadLine();

        Console.WriteLine("Dono da ideia: ");
        newid.dono = Console.ReadLine();

        Console.WriteLine("Descrição da Ideia: ");
        newid.descricao = Console.ReadLine();

        Console.WriteLine("Área de Aplicação: ");
        newid.areaAplicacao = Console.ReadLine();

      }

    }


    
    //MENU CRIAR USUARIO
      //ATRIBUTOS DO USUARIO - INSTANCIAR
    //MENU CRIAR IDEIA
      //ATT. IDEIA - INSTANCIAR
    //MENU VOTAR
      //VISUALIZAR AS IDEIAS NA LISTA e PERMITIR LIKE
    //MENU DEFINIR VENCEDOR
      //CHAMAR VENCEDORA()

  }
}