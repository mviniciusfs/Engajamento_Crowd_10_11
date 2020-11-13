using System.Collections.Generic;
class votacao
{
  public int like;
  
  

  public votacao(int l)
  {
   like = l;
  }

  public static int vencedor(List<votacao> quantidadeVotos)
  {
    int maior = quantidadeVotos[0].like;
    int vencedor = 0;
    for (int i=0; i<quantidadeVotos.Count; i++) 
    {
      if(quantidadeVotos[i].like>maior)
      {
        maior = quantidadeVotos[i].like;
        vencedor = i;
      }
    }
    return vencedor;
    
  }

  public static double calculaPrecoVencedor( int votosRecebicos, int Votostotal ) 
  {
    double ResultadoFinal = ((votosRecebicos/Votostotal)*(votosRecebicos/Votostotal))*30000;
    return ResultadoFinal;
  }

}
