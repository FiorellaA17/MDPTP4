
using System;

namespace MDPTP4
{
	public interface IAlumno :Icomparable
	{
		void cambiarEstrategia(Istrategy c);
		
		string getNombre();
		int getLegajo();
		int getPromedio();
		int getCalificacion();
		void setCalificacion(int calificacion);
		
		bool sosIgual(Icomparable c);
		bool sosMenor(Icomparable c);
		bool sosMayor(Icomparable c);
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
		string ToString();
	}
}
