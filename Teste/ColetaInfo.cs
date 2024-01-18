using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Gamma;

public class ColetaInfo
{
    public decimal valorInicial {  get; set; }
    public decimal valorHora { get; set; }

    public void CalculaValor()
    {
        Console.WriteLine("Estaciona Park lhe dá as boas vindas!\n\n");

        Console.WriteLine("Digite o preço inicial da unidade em que você se encontra:");
        valorInicial = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nAgora digite o preço por hora desta unidade:");
        valorHora = decimal.Parse(Console.ReadLine());


    }
}
