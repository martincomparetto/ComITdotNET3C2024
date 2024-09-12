// CLASE 1 VS

//string nombre = "Martin";
//int edad = 42;
//double precio = 10.5;
//bool estaNublado = true;
//char letra = 'c';
//DateTime dateTime = DateTime.Now;
//DateOnly fechaSolo;
//TimeOnly horaSolo;

//const string constanteSaludo = "Buen dia";

//string saludo;

//if (estaNublado)
//{
//    string apellido = "Comparetto";
//    if (letra == 'c')
//    {
//        apellido = "Ramirez";
//    }
//    //saludo = "Hola " + nombre + " " + apellido + "!. Hoy no es un buen dia!";
//    saludo = $"Hola {nombre.ToUpper()} {apellido}!. Hoy no es un buen dia!";
//}
//else
//{
//    string sobrenombre = "Pipi";
//    //saludo = "Hola " + nombre + " mi amigo " + sobrenombre + "!. Que lindo dia es hoy!";
//    saludo = $"Hola {nombre.ToLower()} mi amigo {sobrenombre.ToUpper()}!. Que lindo dia es hoy!";
//}

////saludo = saludo + apellido;

//Console.WriteLine(saludo);

//Console.WriteLine($"Hola {nombre}! hoy es {(estaNublado ? "un feo dia" : "un hermoso dia")}");


//int numero1 = 10;
//int numero2 = 20;

//int suma = numero1 + numero2;
//Console.WriteLine($"La suma de {numero1} + {numero2} es igual a {numero1 + numero2,10:F3}");

//int producto = numero1 * numero2;
//Console.WriteLine(producto);

//numero1++;
//Console.WriteLine(numero1);

//numero2--;
//Console.WriteLine(numero2);

////numero1 = numero1 + 100;
//numero1 += 100;
//Console.WriteLine(numero1);

//string operador = "exponencial";
//int resuldado = 0;

//if (operador == "suma")
//{
//    resuldado = numero1 + numero2;
//}
//else if (operador == "resta")
//{
//    resuldado = numero1 - numero2;
//}
//else if (operador == "multiplicacion")
//{
//    resuldado = numero1 * numero2;
//}
//else if (operador == "division")
//{
//    resuldado = numero1 / numero2;
//}
//else
//{
//    resuldado = -1;
//}
//Console.WriteLine($"El resultado de la {operador} es igual a {resuldado}");

// DO - WHILE

Console.WriteLine("WHILE");
int n = 6;
while (n <= 5)
{
    Console.WriteLine(n);
    n++;
}

Console.WriteLine("DO");
int n1 = 6;
do
{
    Console.WriteLine(n1);
    n1++;
} while (n1 <= 5);


Console.WriteLine("ARRAY");

int numero = 6;
int[] numerosArray = new int[5];

numerosArray[0] = 4;
numerosArray[1] = 5;
//numerosArray[2] = 6;
numerosArray[3] = 7;
numerosArray[4] = 8;

Console.WriteLine(numerosArray[0]);
Console.WriteLine(numerosArray[1]);
Console.WriteLine(numerosArray[2]);
Console.WriteLine(numerosArray[3]);
Console.WriteLine(numerosArray[4]);

string[] textos = new string[5] { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
string[] textosSimplificado = ["Uno", "Dos", "Cuatro", "Cinco"];

Array.Resize(ref textosSimplificado, 10);

Console.WriteLine("FOR");
for (int pos = 0; pos < textos.Length; pos++)
{
    Console.WriteLine($"Posición {pos}: {textos[pos]}");
}

Console.WriteLine("FOR de a 3");
for (int pos = 0; pos < textos.Length; pos += 3)
{
    Console.WriteLine($"Posición {pos}: {textos[pos]}");
}

Console.WriteLine("FOR");
for (int pos = 0; pos < numerosArray.Length; pos++)
{
    Console.WriteLine($"Posición {pos}: {numerosArray[pos]}");
}

for (int pos = 0; pos < textosSimplificado.Length; pos++)
{
    Console.WriteLine($"Posición {pos}: {textosSimplificado[pos]}");
}

string? textoNulo = null;
int? enteroNulo = null;

Console.WriteLine(textoNulo);
Console.WriteLine(enteroNulo);

string?[] cadenasConNull = new string?[5] { "Uno", "", null, "Cuatro", "Cinco" };

Console.WriteLine("FOREACH");
foreach (var item in textos)
{
    Console.WriteLine(item);
}

foreach (var item in cadenasConNull)
{
    //if (item == null)
    //{
    //    Console.WriteLine("Sin valor");
    //}
    //else
    //{
    //    Console.WriteLine(item);
    //}
    //Console.WriteLine(item == null ? "Sin valor" : item);
    Console.WriteLine(item ?? "Sin valor");
}





