using System;

class HelloWorld {
  static void Main() {

    var opcao = 0;
    var resposta = "";

    do{

      Console.WriteLine("\n===== QUIZ DE INTELIGÊNCIA ARTIFICIAL =====");
      Console.WriteLine("1 - Pergunta 1");
      Console.WriteLine("2 - Pergunta 2");
      Console.WriteLine("3 - Pergunta 3");
      Console.WriteLine("4 - Pergunta 4");
      Console.WriteLine("5 - Pergunta 5");
      Console.WriteLine("6 - Pergunta 6");
      Console.WriteLine("7 - Pergunta 7");
      Console.WriteLine("8 - Pergunta 8");
      Console.WriteLine("9 - Pergunta 9");
      Console.WriteLine("10 - Pergunta 10");
      Console.WriteLine("11 - Sair");
      Console.WriteLine("Escolha uma opção:");

      int.TryParse(Console.ReadLine(), out opcao);

      switch(opcao){

        case 1:

        Console.WriteLine("O que é Inteligência Artificial?");
        Console.WriteLine("A) Um sistema que apenas armazena dados");
        Console.WriteLine("B) Um programa que executa tarefas repetitivas");
        Console.WriteLine("C) Um campo da computação que cria sistemas capazes de simular inteligência humana");
        Console.WriteLine("D) Um tipo de hardware especializado");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "C")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é C");

        break;

        case 2:

        Console.WriteLine("Qual é um exemplo de aplicação de IA?");
        Console.WriteLine("A) Editor de texto");
        Console.WriteLine("B) Calculadora");
        Console.WriteLine("C) Sistema de recomendação da Netflix");
        Console.WriteLine("D) Impressora");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "C")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é C");

        break;

        case 3:

        Console.WriteLine("O que significa Machine Learning?");
        Console.WriteLine("A) Programação manual");
        Console.WriteLine("B) Aprendizado de máquinas a partir de dados");
        Console.WriteLine("C) Armazenamento em nuvem");
        Console.WriteLine("D) Criação de hardware");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "B")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é B");

        break;

        case 4:

        Console.WriteLine("Qual linguagem é muito usada em IA?");
        Console.WriteLine("A) HTML");
        Console.WriteLine("B) Python");
        Console.WriteLine("C) CSS");
        Console.WriteLine("D) Pascal");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "B")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é B");

        break;

        case 5:

        Console.WriteLine("O que é um algoritmo?");
        Console.WriteLine("A) Um tipo de computador");
        Console.WriteLine("B) Uma sequência de instruções para resolver um problema");
        Console.WriteLine("C) Um banco de dados");
        Console.WriteLine("D) Um sistema operacional");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "B")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é B");

        break;

        case 6:

        Console.WriteLine("Qual área permite que computadores entendam linguagem humana?");
        Console.WriteLine("A) Visão Computacional");
        Console.WriteLine("B) Robótica");
        Console.WriteLine("C) Processamento de Linguagem Natural");
        Console.WriteLine("D) Engenharia de Software");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "C")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é C");

        break;

        case 7:

        Console.WriteLine("O que são dados de treinamento?");
        Console.WriteLine("A) Dados usados para desligar o sistema");
        Console.WriteLine("B) Dados usados para ensinar um modelo");
        Console.WriteLine("C) Dados de backup");
        Console.WriteLine("D) Dados criptografados");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "B")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é B");

        break;

        case 8:

        Console.WriteLine("Qual tecnologia está ligada ao reconhecimento de imagens?");
        Console.WriteLine("A) Visão Computacional");
        Console.WriteLine("B) Banco de Dados");
        Console.WriteLine("C) Compiladores");
        Console.WriteLine("D) Redes LAN");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "A")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é A");

        break;

        case 9:

        Console.WriteLine("O que é um chatbot?");
        Console.WriteLine("A) Robô industrial");
        Console.WriteLine("B) Sistema que conversa com usuários");
        Console.WriteLine("C) Antivírus");
        Console.WriteLine("D) Servidor");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "B")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é B");

        break;

        case 10:

        Console.WriteLine("Qual empresa investe fortemente em IA?");
        Console.WriteLine("A) Microsoft");
        Console.WriteLine("B) Coca-Cola");
        Console.WriteLine("C) Ford");
        Console.WriteLine("D) Nike");

        resposta = Console.ReadLine().ToUpper();

        if(resposta == "A")
        Console.WriteLine("Resposta correta!");
        else
        Console.WriteLine("Resposta errada! A correta é A");

        break;

        case 11:
        Console.WriteLine("Programa encerrado.");
        break;

        default:
        Console.WriteLine("Digite uma opção válida.");
        break;
      }

    } while(opcao != 11);

  }
}
