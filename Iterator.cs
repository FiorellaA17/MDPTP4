/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public interface Iterator
	{
		void primero();
        void siguiente();
        bool fin();
        Icomparable actual();
	}
}
