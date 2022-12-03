using System.Text.Json;
using Sistema_Eleitoral___Executivo.Eleicao;
using System.IO;
using System.Text.Json;

namespace Sistema_Eleitoral___Executivo.Serializer
{
    internal static class Deserializer
    {
        private static string _Path = Directory.GetCurrentDirectory() + @"\Eleicoes";

        public static object RecuperarEleicao(string tipo, string ano)
        {
            string txt = File.ReadAllText($"{_Path}\\{tipo}-{ano}").ToString();
            Eleicao.Eleicao eleicao = JsonSerializer.Deserialize<Eleicao.Eleicao>(txt);
            return eleicao;
        }

    }
}