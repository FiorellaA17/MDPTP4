/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public class PorPromedio: Istrategy
	{

		public PorPromedio(){}
		
		public bool sosIgual(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getPromedio() == ((Alumno)o).getPromedio())
				return true;
			else
				return false;
		}

		public bool sosMenor(Icomparable c,Icomparable o)
		{
			
			if(((Alumno)c).getPromedio() < ((Alumno)o).getPromedio())
				return true;
			else
				return false;
		}

		public bool sosMayor(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getPromedio() > ((Alumno)o).getPromedio())
				return true;
			else
				return false;
		}
	}
}
