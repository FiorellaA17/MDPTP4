
using System;

namespace MDPTP4
{
	public abstract class AlumnoDecorator : IAlumno
	{
		protected IAlumno alumno;
		
		public AlumnoDecorator(IAlumno alumno)
		{
			this.alumno=alumno;
		}

		public void cambiarEstrategia(Istrategy c)
		{
			alumno.cambiarEstrategia(c);
		}

		public virtual string getNombre()
		{
			return alumno.getNombre();
		}
//		public abstract string getNombre();

		public virtual int getLegajo()
		{
			return alumno.getLegajo();
		}
		
//		public abstract int getLegajo();
		
		public virtual int getPromedio()
		{
			return alumno.getPromedio();
		}
		
		public virtual int getCalificacion()
		{
			return alumno.getCalificacion();
		}
//		public abstract int getCalificacion();
		
		public virtual void setCalificacion(int calificacion)
		{
			alumno.setCalificacion(calificacion);
		}
		
		
		public bool sosIgual(Icomparable c)
		{
			return alumno.sosIgual(c);
		}

		public bool sosMenor(Icomparable c)
		{
			return alumno.sosMenor(c);
		}

		public bool sosMayor(Icomparable c)
		{
			return alumno.sosMayor(c);
		}

		public int responderPregunta(int pregunta)
		{
			return alumno.responderPregunta(pregunta);
		}

		public virtual string mostrarCalificacion()
		{
			return alumno.mostrarCalificacion();
		}
	}
}
