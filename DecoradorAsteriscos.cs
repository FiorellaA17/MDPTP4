
using System;

namespace MDPTP4
{
	public class DecoradorAsteriscos : AlumnoDecorator
	{
		public DecoradorAsteriscos(IAlumno alumno) : base(alumno)
		{
			
		}
		
//		public override int getCalificacion()
//        {
//            return alumno.getCalificacion();
//        }
//
//        public override int getLegajo()
//        {
//            return alumno.getLegajo();
//        }
//
//        public override string getNombre()
//        {
//            return alumno.getNombre();
//        }
		
		public override string mostrarCalificacion()
		{
			string linea= "****************************************************";
			
			return linea +"\n" + "*	" + base.mostrarCalificacion() + "	*" + "\n" + linea;
		}
	}
}
