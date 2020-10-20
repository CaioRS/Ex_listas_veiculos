using System.Collections.Generic;

class concessionaria{
  string nome;
  public List <carros> lista;

  public concessionaria (string n) {
    nome = n;
    lista = new List<carros>();
  }
}