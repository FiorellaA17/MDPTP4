/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MDPTP4
{
	public class IteradorDeColeccion : Iterator
	{
		List<Icomparable> elementos;
		private int posicion=0;
		
		public IteradorDeColeccion(Cola elementoscola)
		{
			this.elementos=elementoscola.getDatos;
		}
		
		public IteradorDeColeccion(Pila elementospila)
		{
			this.elementos=elementospila.getDatos;
		}
		
		public IteradorDeColeccion(Conjunto elementosconjunto)
		{
			this.elementos=elementosconjunto.getConjunto;
		}
		

		#region Iterator implementation

		public void primero()
		{
			this.posicion=0;
		}

		public void siguiente()
		{
			this.posicion=this.posicion+1;
		}

		public bool fin()
		{
			return this.posicion==elementos.Count;
		}

		public Icomparable actual()
		{
			return elementos[this.posicion];
		}

		#endregion
	}
}
