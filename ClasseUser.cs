using System;
using System.Collections.Generic;

class User {
  //ATRIBUTOS DO USUARIO
  string nome;
  double balanço;

  public User(){
    nome = "anonimo";
    balanço = 0;
  }

  public User(string n){
    nome = n;
    balanço = 0;
  }

}