using System;
class HelloWorld {
  static void Main() {
    
    int[] numeros = new int[10];
    int maior = 0;

    for(int i = 0; i < 10; i++) {

      Console.WriteLine($"Digite o {i + 1} número:");
      int.TryParse(Console.ReadLine(), out numeros[i]);

      if(i == 0){
        maior = numeros[i];
      }

      if(numeros[i] > maior){
        maior = numeros[i];
      }

    }

    Console.WriteLine($"O maior número digitado foi: {maior}");
  }
}
