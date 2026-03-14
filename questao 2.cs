using System;
class HelloWorld {
	static void Main() {
		var numeroinicio = 0;
		var numerofim = 0;
		int i = 0;
		int controle = 0;

		Console.WriteLine("Digite o numero inicial:");
		int.TryParse (Console.ReadLine(), out numeroinicio);

		Console.WriteLine("Digite o numero final:");
		int.TryParse (Console.ReadLine(), out numerofim);


		if(numerofim < numeroinicio) {
			Console.WriteLine("Numero final menor que o numero inicial");
		} else {
			for(i = 0; controle < numerofim; i++) {
				Console.Write($" {numeroinicio + i},");
				controle = numeroinicio + i;
			}
		}

	}
}
