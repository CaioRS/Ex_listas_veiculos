class carros {

  private string modelo;
  private double consumo;

  public carros(string m , double c){
    modelo = m;
    consumo = c;
  }

  public carros(){
  }

  public string GetModelo(){
    return modelo;
  }

  public double GetConsumo(){
    return consumo;
  }

}