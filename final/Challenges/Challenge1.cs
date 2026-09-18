namespace itm.csharp.basic;

public class Challenge1
{
    public void Run()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0) Console.WriteLine("El número es positivo.");
        else if (num < 0) Console.WriteLine("El número es negativo.");
        else Console.WriteLine("El número es Cero.");
    }
}

public class Challenge2
{
    public void Run()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"Suma: {num1 + num2}\nResta: {num1 - num2}\nMultiplicación: {num1 * num2}\nDivisión: {num1 / num2}");
    }
}

public class Challenge3
{
    public void Run()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"El cuadrado de {numero} es: {Math.Pow(numero, 2)}.");
    }
}

public class Challenge4
{
    public void Run()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine()!);
        double area = Math.PI * Math.Pow(radio, 2);
        Console.WriteLine($"El área del círculo con radio {radio} es: {area}. ");
    }
}

public class Challenge5
{
    public void Run()
    {
        Console.Write("Ingrese un número entre 1 y 7: ");
        int dia = int.Parse(Console.ReadLine()!);
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número no válido. Por favor, ingrese un número entre 1 y 7.");
                break;
        }
    }
}

public class Challenge6
{
    public void Run()
    {
        Console.Write("Ingrese su salario mensual: ");
        decimal salario = decimal.Parse(Console.ReadLine()!);
        decimal impuesto = salario > 1000 ? 0.1m * salario : 0;
        Console.WriteLine($"El impuesto a pagar es: {impuesto}.");
    }
}

public class Challenge7
{
    public void Run()
    {
        try
        {
            Console.Write("Ingresa el número a dividir: ");
            double n = double.Parse(Console.ReadLine()!);
            Console.Write("Ingresa el divisor: ");
            double divisor = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Resultado: {n / divisor}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir por cero.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error al realizar la operación.");
        }
    }
}

public class Challenge8
{
    public void Run()
    {
        int suma = 0;
        for (int i = 1; i <= 100; i+=2)
        {
            suma += i;
        }
        Console.WriteLine($"La suma de números impares entre 1 y 100 es: {suma}.");
    }
}

public class Challenge9
{
    public void Run()
    {
        Console.Write("Ingrese el numerador de la primera fracción: ");
        int num1 = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el denominador de la primera fracción: ");
        int den1 = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el numerador de la segunda fracción: ");
        int num2 = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el denominador de la segunda fracción: ");
        int den2 = int.Parse(Console.ReadLine()!);

        try
        {
            Fraccion fraccion1 = new Fraccion(num1, den1);
            Fraccion fraccion2 = new Fraccion(num2, den2);

            Fraccion resultado = fraccion1.Sumar(fraccion2);

            Console.WriteLine($"La suma de {fraccion1} y {fraccion2} es: {resultado}.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: { e.Message }");
        }
    }
}

public class Fraccion
{
    public int Numerador { get; private set; }
    public int Denominador { get; private set; }

    public Fraccion(int numerador, int denominador)
    {
        if (denominador == 0)
        {
            throw new ArgumentException("El denominador no puede ser cero.");
        }

        Numerador = numerador;
        Denominador = denominador;
    }

    public Fraccion Sumar(Fraccion otra)
    {
        int nuevoNumerador = Numerador * otra.Denominador + otra.Numerador * Denominador;
        int nuevoDenominador = Denominador * otra.Denominador;
        return new Fraccion(nuevoNumerador, nuevoDenominador);
    }

    //Puedes agregar más métodos para otras operaciones si es necesario

    public override string ToString() => $"{Numerador}/{Denominador}";    
}

public class Challenge10
{
    public void Run()
    {
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine()!;
        string invertida = new string(palabra.Reverse().ToArray());
        Console.WriteLine($"La palabra invertida es: {invertida}.");
    }
}

public class Challenge11
{
    public void Run()
    {
        Console.Write("Introduce el primer número: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el segundo número: ");
        double num2 = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el tercer número: ");
        double num3 = double.Parse(Console.ReadLine()!);

        double promedio = (num1 + num2 + num3) / 3;
        Console.WriteLine($"El promedio de los tres números es: {promedio}.");
    }
}

public class Challenge12
{
    public void Run()
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros.Add(int.Parse(Console.ReadLine()!));
        }

        Console.WriteLine($"El número mas grande de la lista es: {numeros.Max()}.");
    }
}

public class Challenge13
{
    public void Run()
    {
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine()!;

        if (palabra == new string(palabra.Reverse().ToArray()))
        {
            Console.WriteLine($"La palabra {palabra} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"La palabra {palabra} no es un palíndromo.");
        }
    }
}

public class Challenge14
{
    public void Run()
    {
        Console.Write("Introduce un número: ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar.");
        }
    }
}

public class Challenge15
{
    public void Run()
    {
        Console.Write("Introduce un número: ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero >= 0 && numero <= 10)
        {
            Console.WriteLine($"El número {numero} está en el rango de 0 a 10.");
        }
        else
        {
            Console.WriteLine($"El número {numero} está fuera del rango de 0 a 10.");
        }
    }
}