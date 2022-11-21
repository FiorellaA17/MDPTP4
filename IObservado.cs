/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public interface IObservado
	{
		void agregarObservador(IObservador O);
		void quitarObservador(IObservador O);
		void notificar();
	}
}
