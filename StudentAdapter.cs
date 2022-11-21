/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 19:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	
	public class StudentAdapter : Student
	{
		IAlumno alumno;
			
		public StudentAdapter(IAlumno A)
		{
			this.alumno=A;
		}

		#region Student implementation

		public string getName()
		{
			return alumno.getNombre();
		}

		public int yourAnswerIs(int question)
		{
			return alumno.responderPregunta(question);
		}

		public void setScore(int score)
		{
			alumno.setCalificacion(score);
		}

		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}

		public bool equals(Student student)
		{
//			return alumno.sosIgual(((IAlumno)(StudentAdapter)student));
			return alumno.sosIgual(((StudentAdapter)student).alumno);
		}

		public bool lessThan(Student student)
		{
//			return alumno.sosMenor(((IAlumno)(StudentAdapter)student));
			return alumno.sosMenor(((StudentAdapter)student).alumno);
		}

		public bool greaterThan(Student student)
		{
//			return alumno.sosMayor((IAlumno)((StudentAdapter)student));
			return alumno.sosMayor(((StudentAdapter)student).alumno);
		}

		#endregion
	}
}
