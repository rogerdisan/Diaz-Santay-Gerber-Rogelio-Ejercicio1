Console.WriteLine("=== Triaje Medico ===");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatria");
Console.WriteLine("4. Traumatologia");
Console.Write("Elija una opcion: ");

int tipo = int.Parse(Console.ReadLine());

switch (tipo)
{
    case 1: // Emergencia
        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());
        if (edad < 0 || edad > 150)
        {
            Console.WriteLine("Edad no valida");
            break;
        }

        Console.Write("Temperatura: ");
        double temp = double.Parse(Console.ReadLine());
        if (temp < 35 || temp > 42)
        {
            Console.WriteLine("Temperatura no valida");
            break;
        }

        Console.Write("Saturacion: ");
        int ox = int.Parse(Console.ReadLine());
        if (ox < 0 || ox > 100)
        {
            Console.WriteLine("Saturacion no valida");
            break;
        }

        Console.Write("Dolor (0-10): ");
        int dolor = int.Parse(Console.ReadLine());
        if (dolor < 0 || dolor > 10)
        {
            Console.WriteLine("Dolor no valido");
            break;
        }
        if (ox < 90)
        {
            Console.WriteLine("Prioridad 1 - Reanimacion");
        }
        else if (temp >= 39 && dolor >= 8)
        {
            Console.WriteLine("Prioridad 2 - Observacion");
        }
        else
        {
            Console.WriteLine("Prioridad 3 - Consulta normal");
        }
        break;
}

