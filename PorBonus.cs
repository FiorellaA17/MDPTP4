/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public class PorBonus : Istrategy
	{
		public PorBonus(){}

		#region Istrategy implementation

		public bool sosIgual(Icomparable c, Icomparable o)
		{
			if(((Vendedor)c).getBonus() == ((Vendedor)o).getBonus())
				return true;
			else
				return false;
		}

		public bool sosMenor(Icomparable c, Icomparable o)
		{
			if(((Vendedor)c).getBonus() < ((Vendedor)o).getBonus())
				return true;
			else
				return false;
		}

		public bool sosMayor(Icomparable c, Icomparable o)
		{
			if(((Vendedor)c).getBonus() > ((Vendedor)o).getBonus())
				return true;
			else
				return false;
		}

		#endregion
	}
}
