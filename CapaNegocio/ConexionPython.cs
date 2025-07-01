using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ConexionPython
    {
        private readonly HttpClient httpClient = new HttpClient();
        public async Task<string> PromptAPython(string[,] matriz)
        {
            string prompt = "Tengo un telar representado por una matriz de colores de 5x5, donde cada celda tiene un color. Interprétalo como un patrón andino. Aquí está la matriz:\n" + matriz ;
            string salida ="";
            var texto = prompt;
            var json = JsonConvert.SerializeObject(new { texto = texto });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync("http://localhost:5000/api/ia", content);
                var responseString = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<dynamic>(responseString);
                salida = resultado.respuesta;
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            return salida;
        }
    }
}
