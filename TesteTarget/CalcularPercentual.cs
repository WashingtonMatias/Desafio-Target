using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TesteTarget
{
    public class CalcularPercentual
    {
        public static StringBuilder Percentual(List<FatDistribuidora> fatDistrib)
        {
            var total = fatDistrib.Sum(x => x.Valor);

            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("UF - Valor    -   Percentual");

            foreach (var item in fatDistrib)
            {
                var percentualSP = (item.Valor / total);
                stringBuilder.AppendLine($"{item.UF} - {item.Valor.ToString("C", CultureInfo.CurrentCulture)} - {percentualSP.ToString("P")}\r\n");
            }
            return stringBuilder;
        }
    }
}
