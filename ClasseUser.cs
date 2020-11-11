using System;
using System.Collections.Generic;

class User {
  //ATRIBUTOS DO USUARIO
  public string nome;
  public double balanço;

  public User(){
    nome = "anonimo";
    balanço = 0;
  }

  public User(string n){
    nome = n;
    balanço = 0;
  }

}