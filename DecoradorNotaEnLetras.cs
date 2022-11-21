
using System;

namespace MDPTP4
{
	public class DecoradorNotaEnLetras : AlumnoDecorator
	{
		public DecoradorNotaEnLetras(IAlumno alumno) : base(alumno)
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
			string nota="";
			switch (alumno.getCalificacion())
			{
				case 0:
					nota= "(CERO)";
					break;
				case 1:
					nota= "(UNO)";
					break;
				case 2:
					nota= "(DOS)";
					break;
				case 3:
					nota= "(TRES)";
					break;
				case 4:
					nota="(CUATRO)";
					break;
				case 5:
					nota="(CINCO)";
					break;
				case 6:
					nota="(SEIS)";
					break;
				case 7:
					nota="(SIETE)";
					break;
				case 8:
					nota="(OCHO)";
					break;
				case 9:
					nota="(NUEVE)";
					break;
				case 10:
					nota="(DIEZ)";
					break;
				
			}
			return  base.mostrarCalificacion() + " " + nota;
		}
	}
}
