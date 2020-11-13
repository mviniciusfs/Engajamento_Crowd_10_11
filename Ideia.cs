class ideia
{
  public string descricao; 
  
  public string area;

  private int ranking;

  public string Getdescricao() 
  {
    return descricao;
  }
 
  public string Getarea() 
  {
    return area;
  }

  public int Getranking() 
  {
    return ranking;
  }

  public void Setdescricao(string dc)
  {
    descricao = dc;
  }
  
  
  public void Setarea(string a)
  {
    area = a;
  }
  public void Setranking(int r)
  {
    ranking = r;
  }

  public ideia(string d, string a, int rnk)
  {
   descricao = d;   
   area = a;
   ranking = rnk;
  }
  

}