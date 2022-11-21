/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 19:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
//	TP4-2)
	public class AlumnoMuyEstudioso : Alumno
	{
		
		 public AlumnoMuyEstudioso(string n, int d, int l, int p) : base(n, d, l, p)
        {

        }
		 
		 public int responderPregunta(int pregunta)
		 {
		 	return (pregunta % 3);
		 }
	}
}
