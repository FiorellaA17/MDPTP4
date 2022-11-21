/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MDPTP4
{
	public class Gerente : IObservador
	{
		List<Vendedor> mejores= new List <Vendedor>();
		double ultimaVenta=0;
		
		
		public Gerente()
		{
		}

		#region IObservador implementation
		public void actualizar(IObservado O)
		{
			ultimaVenta= ((Vendedor)O).getUltimaVenta();
			venta(ultimaVenta,(Vendedor)O);
		}
		#endregion	
		
		public void cerrar()
		{
			Console.WriteLine("");
			Console.WriteLine("Los mejores Vendedores son: ");
			Console.WriteLine("");
			
			foreach( var elem in mejores)
			{
				Console.WriteLine("Nombre: {0}. Con bonus acumulado de: {1}",elem.getNombre(),elem.getBonus());	
			}
			
		}
		
		public void venta(double monto,Vendedor vendedor)
		{
			if(monto > 5000)
			{
				if(!mejores.Contains(vendedor))
					mejores.Add(vendedor);
				vendedor.aumentaBonus();
			}
		}
	}
}
