## ¿String es un tipo por valor o un tipo por referencia?
- En C#, string es un tipo por referencia. Aunque string se comporta de manera similar a los tipos por valor debido a su inmutabilidad (una vez que se crea un string, no se puede modificar), sigue siendo un tipo por referencia. Esto significa que las variables de tipo string almacenan referencias a los datos en lugar de los datos en sí.

## ¿Qué secuencias de escape tiene el tipo string?
En C#, las secuencias de escape se utilizan para representar caracteres especiales dentro de las cadenas de texto. Aquí están algunas de las más comunes:
- \n - Nueva línea
- \r - Retorno de carro
- \t - Tabulación horizontal
- \\ - Barra invertida
- \" - Comillas dobles
- \' - Comillas simples
- \0 - Carácter nulo
- \b - Retroceso
- \f - Avance de página
- \v - Tabulación vertical

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

- El carácter @
El carácter @ se usa para crear cadenas textuales literales (verbos), donde las secuencias de escape no se procesan. También permite el uso de comillas dobles dentro de la cadena sin necesidad de escapar de ellas.

- El carácter $
El carácter $ se usa para crear cadenas interpoladas, donde puedes insertar expresiones dentro de la cadena usando llaves {}. Esto permite una manera más conveniente de combinar texto y valores de variables.

- Combinación de @ y $
Puedes combinar @ y $ para crear cadenas interpoladas literales. Esto permite tanto la interpolación de variables como la inclusión de texto literal sin necesidad de secuencias de escape.