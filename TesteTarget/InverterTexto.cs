using System.Text;

namespace TesteTarget
{
    public class InverterTexto
    {
        public static string Inverter(string texto)
        {
            StringBuilder stringBuilder = new();

            for (var i = texto.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(texto[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
