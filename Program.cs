namespace Act3OOP // 
{
	using System;
	using System.Collections.Generic;

	// Clase base Empleado
	class Empleado
	{
		public string Nombre { get; set; }
		public string Cargo { get; set; }
		public double Salario { get; set; }

		// Constructor
		public Empleado(string nombre, string cargo, double salario)
		{
			Nombre = nombre;
			Cargo = cargo;
			Salario = salario;
		}

		// Método para calcular bonificación
		public virtual double CalcularBonificacion()
		{
			// Implementación básica
			return Salario * 0.10;  // 10% de bonificación por defecto
		}

		// Método para mostrar la información del empleado
		public virtual void MostrarInfo()
		{
			Console.WriteLine($"Nombre: {Nombre}, Cargo: {Cargo}, Salario: {Salario:C}");
		}
	}

	// Clase derivada para Empleado Administrativo
	class EmpleadoAdministrativo : Empleado
	{
		public EmpleadoAdministrativo(string nombre, double salario) : base(nombre, "Administrativo", salario) { }

		// Sobrescribimos el método para calcular bonificación, por ejemplo, 12% para Administrativos
		public override double CalcularBonificacion()
		{
			return Salario * 0.12;  // 12% de bonificación para administrativos
		}

		// Sobrescribimos el método para mostrar la información del Administrativo
		public override void MostrarInfo()
		{
			Console.WriteLine($"(Administrativo) Nombre: {Nombre}, Cargo: {Cargo}, Salario: {Salario:C}");
		}
	}

	// Clase derivada para Empleado Operativo
	class EmpleadoOperativo : Empleado
	{
		public EmpleadoOperativo(string nombre, double salario) : base(nombre, "Operativo", salario) { }

		// Sobrescribimos el método para calcular bonificación, por ejemplo, 8% para Operativos
		public override double CalcularBonificacion()
		{
			return Salario * 0.08;  // 8% de bonificación para operativos
		}

		// Sobrescribimos el método para mostrar la información del Operativo
		public override void MostrarInfo()
		{
			Console.WriteLine($"(Operativo) Nombre: {Nombre}, Cargo: {Cargo}, Salario: {Salario:C}");
		}
	}

	// Clase principal
	class Program
	{
		static void Main()
		{
			List<Empleado> empleados = new List<Empleado>();

			// Agregar empleados de tipo Administrativo y Operativo
			empleados.Add(new EmpleadoAdministrativo("Carlos López", 4000));
			empleados.Add(new EmpleadoOperativo("Marta Pérez", 2800));

			// Mostrar empleados
			Console.WriteLine("Lista de empleados:");
			foreach (var emp in empleados)
			{
				emp.MostrarInfo();
				double bonificacion = emp.CalcularBonificacion();
				Console.WriteLine($"Bonificación: {bonificacion:C}");
				Console.WriteLine();
			}
		}
	}
}
