
using System;

namespace MDPTP4
{

	public class DecoradorPromocion : AlumnoDecorator
	{
		public DecoradorPromocion(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			string nota="";
			int calificacion= alumno.getCalificacion();
			
			if(calificacion >= 7)
			{
				nota= "(PROMOCION)";
			}
			
			if(4 <= calificacion & calificacion < 7)
			{
				nota= "(APROBADO)";
			}
			
			if(alumno.getCalificacion() < 4)
			{
				nota="(DESAPROBADO)";
			}
			
			return base.mostrarCalificacion() + " " + nota;
		}
	}
}
