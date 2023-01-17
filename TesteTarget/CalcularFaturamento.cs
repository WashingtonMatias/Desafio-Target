using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTarget
{
    public class CalcularFaturamento
    {
        public static StringBuilder Faturamento(string local)
        {
            var listFaturamentoModel = ReadJson.convertJsonFaturamentoDia(local);

            var menorValor = listFaturamentoModel.OrderBy(y => y.valor).FirstOrDefault();

            var maiorValor = listFaturamentoModel.OrderByDescending(x => x.valor).FirstOrDefault();

            var mediaValor = listFaturamentoModel.Average(x => x.valor);

            var valorSupMedia = listFaturamentoModel.Where(x => x.valor > mediaValor);

            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine($"O menor valor faturado ocorrido no mês foi no dia {menorValor.dia} e tevo o fatuamento de {menorValor.valor}\r\n");

            stringBuilder.AppendLine($"O maior valor faturado ocorrido no mês foi no dia {maiorValor.dia} e tevo o fatuamento de {maiorValor.valor}\r\n");

            stringBuilder.AppendLine($"Média de faturamento é {mediaValor}, abaixo relacao de dias do mês que o valor de faturamento doi superior á média mensal.\r\n");

            stringBuilder.AppendLine("Dia - Valor");

            foreach (var fat in valorSupMedia)
            {
                stringBuilder.AppendLine($"{fat.dia}   -   {fat.valor}");
            }

            return stringBuilder;
        }
    }
}
