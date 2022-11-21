
using System;

namespace MDPTP4
{
	public class DecoradorLegajo : AlumnoDecorator
	{
		public DecoradorLegajo(IAlumno alumno) : base(alumno)
		{
		}

		
		public override string mostrarCalificacion()
		{
			return alumno.getNombre()  + " (" + alumno.getLegajo() + ") " + " " + alumno.getCalificacion();
		} 
		
	}
}
