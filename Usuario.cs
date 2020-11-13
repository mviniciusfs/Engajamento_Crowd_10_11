class usuario {
  private string nome;
  private int telefone;
  private string email;
  private double fundos;
  
  
  public void Setnome(string name){
    nome = name;
  }
  public void Settelefone(int tel){
    telefone = tel;
  }
 public void Setemail(string em){
    email = em;
  }
 public void Setfundos(double fs){ 
    fundos = fs;
  }
  
  public string Getnome(){
    return nome;
  }
  public int Gettelefone(){
    return telefone;
  }
  public string Getemail(){
    return email;
  }
  public double Getfundos(){
    return fundos;
  }




  public usuario (){
    nome= "Anonimo";
    telefone = 0;
    email = "Confirma e-mail";
    fundos = 0;
  }
 
 public usuario(string n, int t, string e, double f){
   nome = n;
   telefone = t;
   email = e;
   fundos = f;
  }

}