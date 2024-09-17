using System;

namespace CalculadoraSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Salarios Mensuales");

            // Solicitar el tipo de empleado
            Console.WriteLine("Ingrese el tipo de empleado (docente por hora, docente de contrato fijo, empleado administrativo):");
            string tipoEmpleado = Console.ReadLine().ToLower();

            decimal salario = 0;

            // Verificar el tipo de empleado
            switch (tipoEmpleado)
            {
                case "docente por hora":
                    // Calcular salario para docente por hora
                    Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                    if (int.TryParse(Console.ReadLine(), out int horasTrabajadas))
                    {
                        salario = horasTrabajadas * 800; // Tarifa de 800 por hora
                    }
                    else
                    {
                        Console.WriteLine("El número de horas no es válido.");
                        return;
                    }
                    break;

                case "docente de contrato fijo":
                case "empleado administrativo":
                    // Calcular salario para docentes de contrato fijo y empleados administrativos
                    Console.WriteLine("¿Alcanzó la meta? (si/no):");
                    string alcanzoMeta = Console.ReadLine().ToLower();

                    decimal salarioBase = 50000; // Ejemplo de salario base

                    if (alcanzoMeta == "si")
                    {
                        salario = salarioBase; // Salario completo
                    }
                    else if (alcanzoMeta == "no")
                    {
                        salario = salarioBase / 2; // Mitad del salario
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para 'Alcanzó la meta'.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Tipo de empleado no válido.");
                    return;
            }

            // Mostrar el salario calculado
            Console.WriteLine($"El salario calculado es: ${salario}");
        }
    }
}
