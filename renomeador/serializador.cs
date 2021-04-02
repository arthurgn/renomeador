using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renomeador
{
    class serializador
    {
        public static T copiar<T>(T objeto)
        {
            return lerfrase<T>(salvarfrase<T>(objeto, false));
        }
        public static void salvararquivo<T>(T Dados, string NomeArquivo, bool Compactado = false, Formatting Formatting = Formatting.None)
        {
            if (Dados == null) throw new Exception();

            var o = salvarfrase<T>(Dados, Compactado, Formatting);
            using (var FileStream = new FileStream(NomeArquivo, FileMode.Create, FileAccess.Write, FileShare.None, 1024, FileOptions.WriteThrough))
            {
                var UTF8Encoding = new UTF8Encoding(true).GetBytes(o);
                FileStream.Write(UTF8Encoding, 0, UTF8Encoding.Length);
            }
        }
        public static string salvarfrase<T>(T Dados, bool Compactado = false, Formatting Formatting = Formatting.None)
        {
            if (Dados == null) throw new Exception();

            var o = JsonConvert.SerializeObject(Dados, typeof(T),
                new JsonSerializerSettings()
                {
                    Formatting = Formatting
                });

            if (Compactado) return gzip.comprimir(o);
            return o;
        }
        public static T lerarquivo<T>(string NomeArquivo, bool Compactado = false)
        {
            return lerfrase<T>(File.ReadAllText(NomeArquivo), Compactado);
        }
        public static T lerfrase<T>(string Fonte, bool Compactado = false)
        {
            if (Compactado)
                Fonte = gzip.descomprimir(Fonte);
            try
            {
                return JsonConvert.DeserializeObject<T>(Fonte);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
