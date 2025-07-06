using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ConexionPython
    {
        static async Task<string> ObtenerRespuestaDeepSeek(string prompt)
        {
            var url = "https://openrouter.ai/api/v1/chat/completions";
            var token = "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";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var contenido = new
                {
                    model = "deepseek/deepseek-r1:free",
                    messages = new[]
                    {
                    new {
                        role = "user",
                        content = prompt + ".Solo dame lo que te pido sin tantas explicaciones, por favor."
                    }
                }
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(contenido);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                var respuesta = await client.PostAsync(url, httpContent);
                var respuestaContenido = await respuesta.Content.ReadAsStringAsync();

                var jsonRespuesta = JObject.Parse(respuestaContenido);
                return jsonRespuesta["choices"][0]["message"]["content"]?.ToString();
            }
        }

        public async Task RespuestaMatriz(string[,] matriz)
        {
            string prompt = "\"Tengo un telar representado por una matriz de colores de 5x5, donde cada celda tiene un color. Interprétalo como un patrón andino. Aquí está la matriz: " + matriz;
            string respuesta = await ObtenerRespuestaDeepSeek(prompt);
            Console.WriteLine(respuesta);
        }
    }
}
