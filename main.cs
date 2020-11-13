using System;
using System.Collections.Generic;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    //INSTANCIAR CLASSE VOTAR
    Votar campanha = new Votar();
    //User pessoa = new User();
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
      //while(resp == 'S')
      do
      {
        Console.WriteLine("Insira o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Dono da ideia: ");
        string dono = Console.ReadLine();

        Console.WriteLine("Descrição da Ideia: ");
        string descricao = Console.ReadLine();

        Console.WriteLine("Área de Aplicação: ");
        string areaAplicacao = Console.ReadLine();

        int votos = 0;
        int id = 0;

        Votar.AdicionarIdeia(new Ideia(dono, descricao, areaAplicacao, votos, id));
        List <Ideia> portfolio = Votar.getListaIdeia();
      
        
        Console.WriteLine("Deseja cadastrar uma nova ideia? * S * ou * N *");
        resp = char.Parse(Console.ReadLine().ToUpper());

        if(resp == 'N')
        {
          Console.WriteLine("Gostaria de consultar o portfolio de ideias? * S * ou * N *");
          char consport = char.Parse(Console.ReadLine().ToUpper());

          if(consport == 'S')
          {
            int i = 0;
            foreach(Ideia x in portfolio)
            {
              Console.WriteLine("Ideia N°{0} Descrição: {1}",i++, x.descricao);
            }

            while(consport == 'S')
            {
              Console.WriteLine();
              Console.Write("Vote na ideia que mais gostou!!! É só digitar o N° e pressionar 'ENTER': ");
              votos = int.Parse(Console.ReadLine());

              portfolio.Add(new Ideia (dono, descricao, areaAplicacao, votos+=1, id));              

                   
            


              Console.WriteLine("Deseja votar novamente? * S * ou * N *");
              consport = char.Parse(Console.ReadLine().ToUpper());
            }

            int ia = 0;
            foreach(Ideia x in portfolio)
            {
              Console.WriteLine("Ideia N°{0} Descrição: {1}",ia++, x.descricao);
            }
            
            Console.WriteLine(campanha.Vencedora());
          }

          

        }


      }
      while(resp =='S');

  

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