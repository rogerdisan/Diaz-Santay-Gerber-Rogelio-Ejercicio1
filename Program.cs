Console.WriteLine("Sistema de Triaje Médico");
Console.WriteLine("Tipo de Atención:");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.Write("3 Pediatría");
Console.Write("Traumatología");
int tipo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la edad del paciente:");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Temperatura (°C):");
double temperatura = double.Parse(Console.ReadLine());

Console.WriteLine("Saturación de oxígeno (%)");
int saturacion = int.Parse(Console.ReadLine());

Console.WriteLine("Nivel de dolor (0-10):");
int dolor = int.Parse(Console.ReadLine());

Console.WriteLine("Presión sistólica");
int presionSistolica = int.Parse(Console.ReadLine());
