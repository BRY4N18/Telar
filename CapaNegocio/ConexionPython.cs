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
            string url = "https://openrouter.ai/api/v1/chat/completions";
            string token = "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";

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
                return jsonRespuesta["choices"][0]["message"]["content"].ToString();
            }
        }

        public async Task<string> RespuestaMatriz(string matriz)
        {
            string prompt = "Tengo un telar representado por una matriz de colores de 13x13, donde cada celda tiene un color. Interprétalo como un patrón andino. Aquí está la matriz: " + matriz + ".\nListo dime ahora el significado del telar que tiene ese patron de colores.";
            return await ObtenerRespuestaDeepSeek(prompt);
        }
    }
}
