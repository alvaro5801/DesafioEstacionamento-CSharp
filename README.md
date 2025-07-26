# 🅿️ Sistema de Estacionamento em C# (Abordagem Procedural)

![Status](https://img.shields.io/badge/status-conclu%C3%ADdo-brightgreen)

## 📖 Descrição e Propósito Educacional

Este é um projeto de console em C# que simula as operações básicas de um sistema de estacionamento.

O principal **propósito educacional** deste projeto foi explorar uma abordagem de programação **procedural** para resolver um problema prático. Diferente de uma solução puramente Orientada a Objetos, este código concentra a lógica em métodos `static` e gerencia o estado do sistema através de variáveis locais no método `Main`.

Esta escolha foi feita para solidificar o entendimento de conceitos fundamentais como controle de fluxo (loops e condicionais), manipulação de coleções e entrada/saída de dados no console, servindo como uma base sólida para comparar e entender melhor os benefícios de organização que a Orientação a Objetos oferece.

## ✨ Funcionalidades

- Definir preços (taxa inicial e valor por hora) no início da execução.
- Adicionar veículos ao estacionamento através do registro da placa.
- Listar todos os veículos atualmente estacionados.
- Remover um veículo, solicitando o número de horas estacionado para calcular o valor total a ser pago.
- Menu de usuário interativo para acessar as funcionalidades de forma contínua.
- Validação de entrada para garantir que os dados inseridos pelo usuário sejam válidos.

## 🛠️ Tecnologias e Conceitos Fundamentais Aplicados

- **Linguagem:** C#
- **Plataforma:** .NET 8
- **Paradigma:** Programação Procedural (Estruturada)
- **Conceitos Chave:**
  - **Controle de Fluxo:** Uso de `while` para o loop do menu e `switch` para a seleção de opções.
  - **Entrada e Saída (I/O):** Interação com o usuário via `Console.ReadLine()` e `Console.WriteLine()`.
  - **Manipulação de Coleções:** Uso de `List<string>` para armazenar as placas dos veículos.
  - **Validação de Entrada:** Utilização de `!string.IsNullOrWhiteSpace
