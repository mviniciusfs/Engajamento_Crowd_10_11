using System;
using System.Collections.Generic;

class MainClass {
  public static void Main () { 
    List <ideia>   Lista_ideia    = new List<ideia>();
    
    List <votacao> Lista_votacaos = new List<votacao>(); 
    
    string cadastrar = "S";
    int quantidadeJogadores = 0;
    while (cadastrar == "S"){
      quantidadeJogadores++;
      votacao vt = new votacao (0);
      usuario anonimo = new usuario("anonimo", 0,"Confirma e-mail", 0);
      ideia   id      = new ideia  ("ideia", "area",0);
      // // // descricao, votostotais, area, ranking

      Console.WriteLine("Deseja cadastrar um novo usuario ? S/N");
      cadastrar = Console.ReadLine();
      
      
      if (cadastrar == "S"){
       
        Console.WriteLine("diga o nome>>");
        string nome = Console.ReadLine();
        
        anonimo.Setnome(nome);
        Console.WriteLine("diga o email>>");

        string email = Console.ReadLine();
        anonimo.Setemail(email);
        Console.WriteLine ("diga o telefone>>");

        int telefone = int.Parse(Console.ReadLine());
        anonimo.Settelefone(telefone);
        anonimo.Setfundos(0);

        Console.WriteLine ("diga sua ideia");
         string descricao= Console.ReadLine();
         id.Setdescricao(descricao);
        
        Console.WriteLine("qual a aréa da sua ideia?");
        string area = Console.ReadLine();
        id.Setarea(area);
        
        Lista_ideia.Add(id);
        vt.like = 0;       
        Lista_votacaos.Add(vt);
        
        
      }
       
    } 

    for(int i = 0; i<Lista_ideia.Count; i++){
      Console.WriteLine("INDICE -- IDEIA -- ÁREA");

      for(int j = 0; j<Lista_ideia.Count; j++){
       Console.WriteLine( $"{j} {Lista_ideia[j].Getdescricao()} -- {Lista_ideia[j].Getarea()}" );
        
      }
      Console.WriteLine("Indice que você vai votar>>");
      
      int indiceVotar = int.Parse(Console.ReadLine());
      Lista_votacaos[indiceVotar].like += 1;
    

    }
      int indiceVencedor = votacao.vencedor(Lista_votacaos);
      double SemCriatividadePraFazerNomeDeVariavelNessaDesgraca = votacao.calculaPrecoVencedor(quantidadeJogadores, indiceVencedor);
      Console.WriteLine($"Vencedor foi {Lista_ideia[indiceVencedor].descricao} com mais votos, vá la pegar seus {SemCriatividadePraFazerNomeDeVariavelNessaDesgraca} reais vadia(NAÕ VOTA ZERO CARAI)");
  }
}