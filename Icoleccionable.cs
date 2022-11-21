/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public interface Icoleccionable : Iterable
	{
		int cuantos(); 
		Icomparable minimo(); 
		Icomparable maximo();
		void agregar (Icomparable c);
		bool contiene (Icomparable c); 
	}
}
