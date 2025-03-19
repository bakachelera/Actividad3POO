using System;
namespace Act4oop;
// Clase abstracta Producto
// Define la estructura común de todos los productos con atributos Nombre y Precio.
// También declara un método abstracto que será implementado por las subclases.
abstract class Producto
{
	protected string Nombre;
	protected double Precio;

	public Producto(string nombre, double precio)
	{
		Nombre = nombre;
		Precio = precio;
	}

	public abstract void MostrarDetalles(); // Método abstracto que cada subclase implementará.
}

// Subclase Electronico
// Representa productos electrónicos y añade un atributo específico: Marca.
class Electronico : Producto
{
	private string Marca;

	public Electronico(string nombre, double precio, string marca) : base(nombre, precio)
	{
		Marca = marca;
	}

	// Implementación del método MostrarDetalles con información específica de productos electrónicos.
	public override void MostrarDetalles()
	{
		Console.WriteLine($"Electrónico: {Nombre}, Marca: {Marca}, Precio: ${Precio}");
	}
}

// Subclase Alimento
// Representa productos alimenticios e incorpora un atributo para la fecha de expiración.
class Alimento : Producto
{
	private string FechaExpiracion;

	public Alimento(string nombre, double precio, string fechaExpiracion) : base(nombre, precio)
	{
		FechaExpiracion = fechaExpiracion;
	}

	// Implementación del método MostrarDetalles con información específica de alimentos.
	public override void MostrarDetalles()
	{
		Console.WriteLine($"Alimento: {Nombre}, Expira el: {FechaExpiracion}, Precio: ${Precio}");
	}
}

// Subclase Ropa
// Representa productos de ropa e incluye un atributo adicional: Talla.
class Ropa : Producto
{
	private string Talla;

	public Ropa(string nombre, double precio, string talla) : base(nombre, precio)
	{
		Talla = talla;
	}

	// Implementación del método MostrarDetalles con información específica de ropa.
	public override void MostrarDetalles()
	{
		Console.WriteLine($"Ropa: {Nombre}, Talla: {Talla}, Precio: ${Precio}");
	}
}

// Clase principal para demostrar el polimorfismo
class Inventario
{
	static void Main()
	{
		// Se crea un arreglo de productos que almacena diferentes tipos de productos.
		Producto[] productos = new Producto[] {
						new Electronico("Laptop", 1200.99, "Dell"),
						new Alimento("Manzana", 0.99, "15-04-2025"),
						new Ropa("Camiseta", 19.99, "M")
				};

		// Se recorre el arreglo y se llama al método MostrarDetalles de cada producto.
		// Gracias al polimorfismo, se ejecuta la versión específica de cada subclase.
		foreach (Producto producto in productos)
		{
			producto.MostrarDetalles();
		}
	}
}
