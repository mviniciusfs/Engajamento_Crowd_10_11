using System;
using System.Collections.Generic;

class Votar {
  //List<Ideia> portfolio;

  public static List<Ideia>portfolio = new List<Ideia>();
  
  public Votar(){
    portfolio = new List<Ideia>();

  }

  public static void AdicionarIdeia(Ideia i)
  {
    portfolio.Add(i);
  }

  /*public static void AdicionarVoto(int i)
  {
    portfolio.Insert(i, new Ideia{tVotos = i++});
  }*/

  //portfolio.Insert(votos, new Ideia {tVoto = 1}); 

  public static List<Ideia> getListaIdeia()
  {
    return portfolio;
  }

  public Ideia Vencedora(){
     //logica de maior ideia 
      Ideia maior_likes = portfolio[0];
      for (int i=0;i<portfolio.Count;i++){
        if (portfolio[i].tVotos > maior_likes.tVotos){
          maior_likes = portfolio[i];
        }
      }
    return maior_likes;
  }

  

}