using System;
class HelloWorld {
  static void Main() {
    
    var opcao = 0;
    var resultado = 0;
    
    do{
        
    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1 - Somar dois números:");
    Console.WriteLine("2 - Subtrair dois números:");
    Console.WriteLine("3 - Multiplicar dois números:");
    Console.WriteLine("4 - Dividir dois números:");
    Console.WriteLine("5 - Sair:");
    Console.WriteLine("Escolha uma opção:");
    
    int.TryParse (Console.ReadLine(), out opcao);
    
    switch(opcao){
    
    case 1:
    
    var soma = 0;
    var soma2 = 0;
    
    Console.WriteLine("Digite o primeiro numero:");
    int.TryParse (Console.ReadLine(), out soma);
    
    Console.WriteLine("Digite o segundo numero:");
    int.TryParse (Console.ReadLine(), out soma2);
    
    resultado = soma + soma2;
    
    Console.WriteLine($"Resultado de {soma} + {soma2} : {resultado} ");
    break;
    
    case 2:
    var minuendo = 0;
    var subtraendo = 0;
    
    Console.WriteLine("Digite o minuendo:");
    int.TryParse (Console.ReadLine(), out minuendo);
    
    Console.WriteLine("Digite o subtraendo:");
    int.TryParse (Console.ReadLine(), out subtraendo);
    
    resultado = minuendo - subtraendo;
    
    Console.WriteLine($"Resultado de {minuendo} - {subtraendo} : {resultado} ");
    break;
    
    case 3:
    var fator1 = 0;
    var fator2 = 0;
    
    Console.WriteLine("Digite o primeiro fator:");
    int.TryParse (Console.ReadLine(), out fator1);
    
    Console.WriteLine("Digite o segundo fator:");
    int.TryParse (Console.ReadLine(), out fator2);
    
    resultado = fator1 * fator2;
    
    Console.WriteLine($"Resultado de {fator1} * {fator2} : {resultado} ");
    break;
    
    case 4:
    var dividendo = 0;
    var divisor = 0;
    
    Console.WriteLine("Digite o divedendo:");
    int.TryParse (Console.ReadLine(), out dividendo);
    
    Console.WriteLine("Digite o divisor:");
    int.TryParse (Console.ReadLine(), out divisor);
    
    resultado = dividendo / divisor;
    
    Console.WriteLine($"Resultado de {dividendo} / {divisor} : {resultado} ");
    break;
    
    case 5:
    Console.WriteLine("O programa será encerrado");
    break;
    
    default:
    Console.WriteLine("Digite uma opção valida");
    break;
    }
    
    
  
  } while (opcao != 5);
 }
}
