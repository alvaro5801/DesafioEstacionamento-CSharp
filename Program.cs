using System;
using System.Collections.Generic;

namespace EstacionamentoApp
{
  public class Programa
  {
    public static void Main()
    {
      decimal precoInicial = 0;
      decimal precoPorHora = 0;

      Console.WriteLine("Bem-vindo ao sistema de estacionamento!\n" +
                        "Digite o preço inicial:");
      // Tratamento de exceção para garantir que o valor digitado é um número válido
      while (!decimal.TryParse(Console.ReadLine(), out precoInicial))
      {
        Console.WriteLine("Valor inválido. Por favor, digite um número para o preço inicial:");
      }

      Console.WriteLine("Agora digite o preço por hora:");
      while (!decimal.TryParse(Console.ReadLine(), out precoPorHora))
      {
        Console.WriteLine("Valor inválido. Por favor, digite um número para o preço por hora:");
      }

      List<string> veiculos = new List<string>();

      bool exibirMenu = true;

      while (exibirMenu)
      {
        Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");

        switch (Console.ReadLine())
        {
          case "1":
            AdicionarVeiculo(veiculos);
            break;

          case "2":
            RemoverVeiculo(veiculos, precoInicial, precoPorHora);
            break;

          case "3":
            ListarVeiculos(veiculos);
            break;

          case "4":
            exibirMenu = false;
            break;

          default:
            Console.WriteLine("Opção inválida");
            break;
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
      }

      Console.WriteLine("O programa se encerrou");
    }

    public static void AdicionarVeiculo(List<string> listaDeVeiculos)
    {
      Console.WriteLine("Digite a placa do veículo para estacionar:");

      string? placa = Console.ReadLine();

      if (!string.IsNullOrWhiteSpace(placa))
      {
        listaDeVeiculos.Add(placa.ToUpper()); // Salva a placa em maiúsculas para facilitar a busca
        Console.WriteLine($"O veículo {placa.ToUpper()} foi estacionado com sucesso!");
      }
      else
      {
        Console.WriteLine("Placa inválida. Tente novamente.");
      }
    }

    // ***** MÉTODO FINALIZADO *****
    public static void RemoverVeiculo(List<string> listaDeVeiculos, decimal pInicial, decimal pPorHora)
    {
      Console.WriteLine("Digite a placa do veículo para remover:");
      string? placa = Console.ReadLine();

      // Verifica se a placa digitada não é nula/vazia e se o veículo existe na lista
      if (!string.IsNullOrWhiteSpace(placa) && listaDeVeiculos.Contains(placa.ToUpper()))
      {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

        // Tenta converter o texto digitado para um número inteiro
        if (int.TryParse(Console.ReadLine(), out int horas))
        {
          // Se a conversão deu certo, calcula o valor
          decimal valorTotal = pInicial + (pPorHora * horas);

          // Remove o veículo da lista
          listaDeVeiculos.Remove(placa.ToUpper());

          // Exibe a mensagem final
          Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: {valorTotal:C}");
        }
        else
        {
          Console.WriteLine("Valor de horas inválido. Tente novamente.");
        }
      }
      else
      {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
      }
    }

    public static void ListarVeiculos(List<string> listaDeVeiculos)
    {
      if (listaDeVeiculos.Count > 0)
      {
        Console.WriteLine("Os veículos estacionados são:");
        foreach (string veiculo in listaDeVeiculos)
        {
          Console.WriteLine(veiculo);
        }
      }
      else
      {
        Console.WriteLine("Não há veículos estacionados.");
      }
    }
  }
}