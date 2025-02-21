namespace Act2OOP;
using System;
using System.Collections.Generic;

// Clase Empleado
class Empleado // se declara la clase empleado con sus campos a usar.
{
	public string Nombre { get; set; }
	public string Cargo { get; set; }
	public double Salario { get; set; }

	// Constructor
	public Empleado(string nombre, string cargo, double salario) //aqui declaramos un objeto Empleado publico, que sera el constructor para el Empleado.
	{
		Nombre = nombre;
		Cargo = cargo;
		Salario = salario;
	}

	// Método para calcular bonificación
	public double CalcularBonificacion(double porcentaje) //un ejemplo de metodo para calcular alguna bonificacion, tal vez algun subsidio ó prestación.
	{
		return Salario * (porcentaje / 100);
	}

	// Método para mostrar la información del empleado
	public void MostrarInfo() // este metodo muestra la info de algun empleado.
	{
		Console.WriteLine($"Nombre: {Nombre}, Cargo: {Cargo}, Salario: {Salario:C}");
	}
}

// Clase principal
class Program
{
	static void Main()
	{
		List<Empleado> empleados = new List<Empleado>();

		// Agregar empleados
		empleados.Add(new Empleado("Juan Pérez", "Desarrollador", 3500));
		empleados.Add(new Empleado("Ana Gómez", "Gerente", 5000));

		// Mostrar empleados
		Console.WriteLine("Lista de empleados:");
		foreach (var emp in empleados)
		{
			emp.MostrarInfo();
			double bonificacion = emp.CalcularBonificacion(10);
			Console.WriteLine($"Bonificación (10%): {bonificacion:C}");
			Console.WriteLine();
		}
	}
}
