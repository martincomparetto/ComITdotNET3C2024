string nombre = "Martin";
int edad = 42;
double precio = 10.5;
bool estaNublado = true;
char letra = 'c';
DateTime dateTime = DateTime.Now;
DateOnly fechaSolo;
TimeOnly horaSolo;

const string constanteSaludo = "Buen dia";

string saludo;

if (estaNublado)
{
    string apellido = "Comparetto";
    if (letra == 'c')
    {
        apellido = "Ramirez";
    }
    //saludo = "Hola " + nombre + " " + apellido + "!. Hoy no es un buen dia!";
    saludo = $"Hola {nombre.ToUpper()} {apellido}!. Hoy no es un buen dia!";
}
else
{
    string sobrenombre = "Pipi";
    //saludo = "Hola " + nombre + " mi amigo " + sobrenombre + "!. Que lindo dia es hoy!";
    saludo = $"Hola {nombre.ToLower()} mi amigo {sobrenombre.ToUpper()}!. Que lindo dia es hoy!";
}

//saludo = saludo + apellido;

Console.WriteLine(saludo);

Console.WriteLine($"Hola {nombre}! hoy es {(estaNublado ? "un feo dia" : "un hermoso dia")}");


int numero1 = 10;
int numero2 = 20;

int suma = numero1 + numero2;
Console.WriteLine($"La suma de {numero1} + {numero2} es igual a {numero1 + numero2,10:F3}");

int producto = numero1 * numero2;
Console.WriteLine(producto);

numero1++;
Console.WriteLine(numero1);

numero2--;
Console.WriteLine(numero2);

//numero1 = numero1 + 100;
numero1 += 100;
Console.WriteLine(numero1);

string operador = "exponencial";
int resuldado = 0;

if (operador == "suma")
{
    resuldado = numero1 + numero2;
}
else if (operador == "resta")
{
    resuldado = numero1 - numero2;
}
else if (operador == "multiplicacion")
{
    resuldado = numero1 * numero2;
}
else if (operador == "division")
{
    resuldado = numero1 / numero2;
}
else
{
    resuldado = -1;
}
Console.WriteLine($"El resultado de la {operador} es igual a {resuldado}");
