/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public interface Istrategy
	{
		bool sosIgual (Icomparable c, Icomparable o);
		bool sosMenor (Icomparable c, Icomparable o);
		bool sosMayor (Icomparable c, Icomparable o);
	}
}
