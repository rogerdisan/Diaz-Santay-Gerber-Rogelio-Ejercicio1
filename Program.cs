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

 case 2: // Consulta
    Console.Write("Temperatura: ");
    double temp2 = double.Parse(Console.ReadLine());
    if (temp2 < 35 || temp2 > 42)
    {
        Console.WriteLine("Temperatura no valida");
        break;
    }

    Console.Write("Dolor (0-10): ");
    int dolor2 = int.Parse(Console.ReadLine());
    if (dolor2 < 0 || dolor2 > 10)
    {
        Console.WriteLine("Dolor no valido");
        break;
    }

    if (temp2 >= 38.5 || dolor2 >= 7)
    {
        Console.WriteLine("Prioridad 3 - Consulta prioritaria");
    }
    else
    {
        Console.WriteLine("Prioridad 4 - Consulta normal");
    }
    break;

case 3: // Pediatria
    Console.Write("Edad: ");
    int edad3 = int.Parse(Console.ReadLine());
    if (edad3 < 0 || edad3 > 150)
    {
        Console.WriteLine("Edad no valida");
        break;
    }

    Console.Write("Temperatura: ");
    double temp3 = double.Parse(Console.ReadLine());
    if (temp3 < 35 || temp3 > 42)
    {
        Console.WriteLine("Temperatura no valida");
        break;
    }

    if (edad3 < 12 && temp3 >= 38.5)
    {
        Console.WriteLine("Prioridad 2 - Atencion pediatrica urgente");
    }
    else
    {
        Console.WriteLine("Prioridad 3 - Consulta pediatrica");
    }
    break;

case 4: // Traumatologia
    Console.Write("Dolor (0-10): ");
    int dolor4 = int.Parse(Console.ReadLine());
    if (dolor4 < 0 || dolor4 > 10)
    {
        Console.WriteLine("Dolor no valido");
        break;
    }

    if (dolor4 >= 8)
    {
        Console.WriteLine("Prioridad 2 - Atencion traumatologica urgente");
    }
    else
    {
        Console.WriteLine("Prioridad 3 - Consulta traumatologica");
    }
    break;

default:
    Console.WriteLine("Opcion no valida");
    break;
}


