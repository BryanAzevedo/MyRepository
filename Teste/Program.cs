using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Gamma;

namespace Teste.Beta
{
    public class Program
    {
        public static void Main()
        {
            List<string> veiculos = new List<string>();

            ColetaInfo coletaInfo = new ColetaInfo();
            coletaInfo.CalculaValor();
            decimal valorH = coletaInfo.valorHora;
            decimal valorI = coletaInfo.valorInicial;

            bool control = true;
            while (control == true)
            {
                bool verificacaoOne = true;

                Console.WriteLine("\nDigite opção desejada:\n1 - Cadastrar um novo veículo\n" +
                    "2 - Remover veículo\n3 - Mostrar veículos cadastrados\n4 - Encerrar programa");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        while (verificacaoOne == true)
                        {
                            Console.WriteLine("\nVamos cadastrar um novo veículo\n");

                            Console.WriteLine("Digite a placa do veículo: ");
                            string placa = Console.ReadLine();

                            Console.WriteLine("\nDigite o fabricante do veículo: ");
                            string fabricante = Console.ReadLine();

                            Console.WriteLine("\nDigite o modelo do veículo: ");
                            string modelo = Console.ReadLine();

                            DateTime data = DateTime.Now;
                            string infoVeiculo = $"Veículo cadastrado em {data.ToString("dd/MM/yyyy")} às {data.ToString("HH:mm")}" +
                                $"\nFabricante: {fabricante} - Modelo: {modelo} - Placa: {placa}";

                            veiculos.Add(infoVeiculo);

                            Console.WriteLine("\nCadastro realizado com sucesso!");

                            string verificacaoTwo = "assistant";
                            do
                            {
                                Console.WriteLine("\nDigite:\n1 - Para continuar cadastrando\n2 - Para retornar ao menu");
                                verificacaoTwo = Console.ReadLine();

                                if (verificacaoTwo == "1")
                                {
                                    Console.WriteLine("\nContinuando o cadastrastro...\n");
                                    break;
                                }
                                else if (verificacaoTwo == "2")
                                {
                                    Console.WriteLine("\nVoltando ao menu...\n");
                                    verificacaoOne = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opção Inválida.");
                                }
                            } while (verificacaoTwo != "1" || verificacaoTwo != "2");
                        }break;
                        
                    case "2":

                        while (verificacaoOne == true)
                        {
                            if (veiculos.Count == 0)
                            {
                                Console.WriteLine("\nNão há veículos cadastrados\n");
                                verificacaoOne = false;
                                break;
                            }

                            Console.WriteLine("\nVeículos Cadastrados:");
                            for (int i = 0; i < veiculos.Count; i++)
                            {
                                Console.WriteLine($"\nCódigo: {i + 1} - {veiculos[i]}");
                            }

                            Console.WriteLine("\nPara remover um veículo, digite o código do mesmo:");
                            int exclusao = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nInsira a quantidade de horas que o veículo permaneceu estacionado:");
                            decimal horasPermanecidas = decimal.Parse(Console.ReadLine());

                            if (veiculos.Count == 1)
                            {
                                Console.WriteLine($"\nO seguinte veículo foi removido:\n\n{veiculos[0]}" +
                                $"\nTotal a pagar = {(horasPermanecidas * valorH) + valorI}");
                                veiculos.Remove(veiculos[0]);
                            }
                            else
                            {
                                Console.WriteLine($"\nO seguinte veículo foi removido:\n\n{veiculos[exclusao - 1]}" +
                                    $"\nTotal a pagar = {(horasPermanecidas * valorH) + valorI}");
                                veiculos.Remove(veiculos[exclusao - 1]);
                            }

                            string verificacaoTwo = "assistant";
                            do
                            {
                                Console.WriteLine("\nDigite:\n1 - Para remover outro veículo\n2 - Para retornar ao menu");
                                verificacaoTwo = Console.ReadLine();

                                if (verificacaoTwo == "1")
                                {
                                    Console.WriteLine("\nRemovendo outro veículo...\n");
                                    break;
                                }
                                else if (verificacaoTwo == "2")
                                {
                                    Console.WriteLine("\nVoltando ao menu...\n");
                                    verificacaoOne = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opção Inválida.");
                                }
                            } while (verificacaoTwo != "1" || verificacaoTwo != "2");
                        }break;

                    case "3":

                        while(verificacaoOne == true)
                        {
                            if (veiculos.Count == 0)
                            {
                                Console.WriteLine("\nNão há veículos cadastrados\n");
                                verificacaoOne = false;
                                break;
                            }

                            Console.WriteLine("Veículos Cadastrados:\n");
                            for (int i = 0; i < veiculos.Count; i++)
                            {
                                Console.WriteLine($"Código: {i + 1} -> {veiculos[i]}");
                            }

                            string verificacaoTwo;
                            do
                            {
                                Console.WriteLine("\nDigite a tecla ENTER para retornar ao menu");
                                verificacaoTwo = Console.ReadLine();

                                if (verificacaoTwo == null)
                                {
                                    Console.WriteLine("\nVoltando ao menu...\n");
                                    verificacaoOne = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opção Inválida.");
                                }
                            } while (verificacaoTwo != null);
                        }break;
    
                    case "4":

                        control = false;
                        break;

                    default:

                        Console.WriteLine("\nOpção Inválida");
                        break;
                }
            }

            Console.WriteLine("\nPrograma Encerrado\n");
        }
    }
}
