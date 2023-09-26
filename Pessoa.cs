using System;
class Pessoa
{
  //atributos
  private string? nome;


//get set, sempre public e tipado com o mesmo tipo do atributo
  public string Nome
  {
    get{
      return nome;}
    set{
      nome = value;
    }
  }

}