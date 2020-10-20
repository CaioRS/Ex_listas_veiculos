using System;

class MainClass {
  public static void Main (string[] args) {
    
    string n;
    int menor=0;
    double c;

    concessionaria teste = new concessionaria("teste");
    carros carro = new carros();

    string continuar = "S";

    while (continuar=="S"){
      Console.WriteLine("UM NOVO CARRO SERA CRIADO. DIGITE O NOME >> ");
      n = Console.ReadLine();

      Console.WriteLine("DIGITE KM/L DO CARRO >> ");
      c = double.Parse(Console.ReadLine());

      carro = new carros(n,c);
      teste.lista.Add(carro);

      Console.WriteLine("Deseja continuar? (S ou N) ");
      continuar = Console.ReadLine();
    }
    
    Console.Clear();
    Console.WriteLine("Total de Carros na Concessionaria >> {0}", teste.lista.Count);

    for (int i=0;i<teste.lista.Count;i++){
      Console.WriteLine("Carro {0} - Modelo {1} - KM/L {2} ", i+1, teste.lista[i].GetModelo(), teste.lista[i].GetConsumo());
    } 

    
    // Calculo de menor Consumo
    for (int i=0;i<teste.lista.Count;i++){
      if(teste.lista[menor].GetConsumo() - teste.lista[i].GetConsumo() <= 0) {
        menor = i;
      }
    }
    Console.WriteLine("Carro Mais Economico é : {0}", teste.lista[menor].GetModelo());

    for (int i=0;i<teste.lista.Count;i++){
      Console.WriteLine("Modelo {0} - p/1000KM gasta: {1} Litros - Valor {2} R$  ", teste.lista[i].GetModelo(), 1000/teste.lista[i].GetConsumo(),(1000/teste.lista[i].GetConsumo()) * 4.89 );
    }


   













  }

    


}