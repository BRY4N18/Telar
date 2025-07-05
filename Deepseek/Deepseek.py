import requests

def obtener_respuesta_deepseek(prompt):

    url = "https://openrouter.ai/api/v1/chat/completions" #Guarda la URL de la API a la que se hará la solicitud

    headers = { #encabezados HTTP que se deben enviar con la solicitud.
        "Authorization": "Bearer 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", #token de acceso
        "Content-Type": "application/json" #indica que se enviaran datos de formato JSON
    }

    data = { #Cuerpo JSON que enviara en la solicitud
        "model": "deepseek/deepseek-r1:free",
        "messages": [
            {
                "role": "user", #rol del hablante
                "content": prompt + ".Solo dame lo que te pido sin tantas explicaciones, por favor." 
            }
        ]
    } 

    response = requests.post(url, headers=headers, json=data) #Realiza la solicitud con los datos ya definidos
    data = response.json() #Convierte la repsuesta que esta en JSON a un diccionario de Python
    return data["choices"][0]["message"]["content"] #Develve el contenido de la respuesta que devuelve deepseek

consulta = str(input("Escribe lo que deseas saber: "))
print(obtener_respuesta_deepseek(consulta))
