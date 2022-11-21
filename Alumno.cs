
using System;

namespace MDPTP4
{
	public class Alumno : Persona , IAlumno
	{
		int legajo;
		int promedio;
		Istrategy comparoAlumno; //Tp2 - lo agrego para hacer uso del strategy
		int calificacion; //TP4 -1)
		
		public Alumno(string n, int d, int l, int p) : base(n,d)
		{
			this.legajo=l;
			this.promedio=p;
			comparoAlumno=new PorNombre(); //elijo una comparacion por defecto
		}
		
		 public Alumno(string n, int d, int l, int p, int c) : base(n, d)
        {

            this.legajo = l;
            this.promedio = p;
            this.comparoAlumno = new PorNombre();
            this.calificacion = c;

        }
		
		public void cambiarEstrategia(Istrategy c)
		{
			this.comparoAlumno=c;
		}
		
		public int getLegajo()
		{
			return this.legajo;
		}
		
		public int getPromedio()
		{
			return this.promedio;
		}
		
		public int getCalificacion()
        {
            return this.calificacion;
        }
		
        public void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }
		
		
		
		//18) Reimplemente los métodos de comparable en Alumno para que se compare por legajo o promedio, a elección.
		
		public override bool sosIgual(Icomparable c)
		{	
			return comparoAlumno.sosIgual(this, (IAlumno)c); //Delego a la estrategia como comparar.
		}

		public override bool sosMenor(Icomparable c)
		{		
			return comparoAlumno.sosMenor(this, (IAlumno)c);
		}

		public override bool sosMayor(Icomparable c)
		{
			return comparoAlumno.sosMayor(this, (IAlumno)c);
		}
		
		public virtual int responderPregunta (int pregunta)
		{
			Random rn=new Random();
			int respuesta=rn.Next(1,4);
			
			return respuesta;
		}
		
		public virtual string mostrarCalificacion()
		{
			string mostrarCalif= this.getNombre() + " " + this.getCalificacion();
			
			return mostrarCalif;
		}
		
		
		public override string ToString()
		{
			return string.Format("nombre: {0} - Dni: {1} - Legajo: {2}, promedio: {3} , calificacion: {4}" , this.getNombre(),this.getDni(),this.getLegajo(),this.getPromedio(), this.getCalificacion());
		}
	}
}
