using System;
using System.Collections.Generic;

public class EjemploLista
{
    public static void Main(string[] args)
    {
        // Crear una lista de enteros
        List<int> numeros = new List<int>();

        // Añadir elementos a la lista
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        Console.WriteLine("Elementos en la lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
public class EjemploDiccionario
{
    public static void Main(string[] args)
    {
        // Crear un diccionario de nombres y edades
        Dictionary<string, int> edades = new Dictionary<string, int>();
        edades.Add("Alice", 30);
        edades.Add("Bob", 24);
        edades.Add("Charlie", 35);

        // Buscar la edad de Bob
        if (edades.TryGetValue("Bob", out int edadBob))
        {
            Console.WriteLine($"La edad de Bob es: {edadBob}");
        }
        else
        {
            Console.WriteLine("Bob no se encontró en el diccionario.");
        }

        // Intentar buscar a David (no existe)
        if (edades.TryGetValue("David", out int edadDavid))
        {
            Console.WriteLine($"La edad de David es: {edadDavid}");
        }
        else
        {
            Console.WriteLine("David no se encontró en el diccionario.");
        }
    }
}

public class EjemploPila
{
    public static void Main(string[] args)
    {
        // Crear una pila de enteros
        Stack<int> libros = new Stack<int>();

        // Añadir elementos a la pila
        libros.Push(101); // Libro 101
        libros.Push(102); // Libro 102
        libros.Push(103); // Libro 103

        Console.WriteLine("Libros en la pila (de arriba a abajo):");
        foreach (int libro in libros)
        {
            Console.WriteLine(libro);
        }

        // Sacar el último libro añadido
        int ultimoLibro = libros.Pop();
        Console.WriteLine($"\nSe ha sacado el libro: {ultimoLibro}");

        Console.WriteLine("Libros restantes en la pila:");
        foreach (int libro in libros)
        {
            Console.WriteLine(libro);
        }
    }
}
public class EjemploConjunto
{
    public static void Main(string[] args)
    {
        HashSet<string> frutas = new HashSet<string>();

        frutas.Add("Manzana");
        frutas.Add("Pera");
        frutas.Add("Banana");
        frutas.Add("Manzana"); // No se duplicará

        Console.WriteLine("Frutas en el conjunto:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}
public class EjemploCola
{
    public static void Main(string[] args)
    {
        // Crear una cola de cadenas
        Queue<string> pedidos = new Queue<string>();

        // Añadir elementos a la cola
        pedidos.Enqueue("Pizza");
        pedidos.Enqueue("Hamburguesa");
        pedidos.Enqueue("Ensalada");

        Console.WriteLine("Pedidos actuales:");
        foreach (string pedido in pedidos)
        {
            Console.WriteLine(pedido);
        }

        // Atender el primer pedido (eliminar de la cola)
        string primerPedido = pedidos.Dequeue();
        Console.WriteLine($"\nAtendiendo: {primerPedido}");

        Console.WriteLine("Pedidos restantes:");
        foreach (string pedido in pedidos)
        {
            Console.WriteLine(pedido);
        }
    }
}
