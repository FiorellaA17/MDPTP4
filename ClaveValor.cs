/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
public class ClaveValor : Icomparable
	{
		Icomparable clave;
		Icomparable valor;
		
		public ClaveValor(Icomparable c, Icomparable v)
		{
			this.clave=c;
			this.valor=v;
		}

		public Icomparable getclave()
		{
			return this.clave;
		}
		
		public Icomparable getvalor()
		{
			return this.valor;
		} 
		#region Icomparable implementation

		public bool sosIgual(Icomparable c)
		{
			throw new NotImplementedException();
		}

		public bool sosMenor(Icomparable c)
		{
			throw new NotImplementedException();
		}

		public bool sosMayor(Icomparable c)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
