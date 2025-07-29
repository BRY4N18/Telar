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
            string token = "a";

            using (var client = new HttpClient())
            {
                try
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
                    //return jsonRespuesta["choices"][0]["message"]["content"].ToString();
                    if (jsonRespuesta["choices"] != null && jsonRespuesta["choices"][0] != null 
                        && jsonRespuesta["choices"][0]["message"] != null && jsonRespuesta["choices"][0]["message"]["content"] != null)
                    {
                        return jsonRespuesta["choices"][0]["message"]["content"].ToString();
                    }
                    else
                    {
                        return "La respuesta del servidor no contiene información válida. Por favor, intenta nuevamente más tarde.";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }
            }
        }
        public async Task<string> RespuestaMatriz(string matriz)
        {
            string prompt = "Tengo un telar representado por una matriz de colores de 13x13, donde cada celda tiene un color. Interprétalo como un patrón andino. Aquí está la matriz: " + matriz + ".\nListo dime ahora el significado del telar que tiene ese patron de colores.";
            return await ObtenerRespuestaDeepSeek(prompt);
        }
    }
}
