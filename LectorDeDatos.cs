/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public int numeroPorTeclado()
		{
			Console.WriteLine("ingrese un numero");
            int num = int.Parse(Console.ReadLine());
            return num;
		}
		
		public string stringPorTeclado()
		{
			Console.WriteLine("ingrese una palabra");
			string palabra = Console.ReadLine();
            return palabra;
		}
		
	}
}
