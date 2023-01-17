using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TesteTarget
{
    public class ReadJson
    {
        public static List<FaturamentoDia> convertJsonFaturamentoDia (string local)
        {
            var faturamentoModel = new List<FaturamentoDia>();

            using (StreamReader r = new StreamReader(local))
            {
                var json = r.ReadToEnd();
                faturamentoModel = JsonSerializer.Deserialize<List<FaturamentoDia>>(json);

                faturamentoModel = faturamentoModel.Where(x => x.valor > 0).ToList();

                return faturamentoModel;
            }

        }
    }
}
