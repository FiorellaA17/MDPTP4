
using System;

namespace MDPTP4
{
	class Program
	{
		public static void Main(string[] args)
		{
            
			llenarStudent();
			
			IAlumno alumnoDecorado = (Alumno)FabricaDeComparables.crearAleatorio(2);
            alumnoDecorado = new DecoradorLegajo(alumnoDecorado);
            alumnoDecorado = new DecoradorNotaEnLetras(alumnoDecorado);
            alumnoDecorado = new DecoradorPromocion(alumnoDecorado);
            alumnoDecorado= new DecoradorAsteriscos(alumnoDecorado);
            Console.WriteLine( alumnoDecorado.mostrarCalificacion());
            
            llenarStudentDecorator();
		
            
			Console.WriteLine("");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
//		TP3 -6)
		public static void llenar(Icoleccionable c, int opcion)
		{	
			for (int x = 1; x <= 20; x++) 
			{
				c.agregar(FabricaDeComparables.crearAleatorio(opcion));
			}
		}
		
//		TP3 - 6)	
		public static void informar(Icoleccionable c, int opcion)
		{

			Console.WriteLine("La cantidad de elementos que tiene la coleccion es de: {0}",c.cuantos());
			Console.WriteLine("Valor minimo: {0}",c.minimo());
			Console.WriteLine("Valor maximo: {0}",c.maximo());
			
			Console.WriteLine("");
			Console.WriteLine("Ingrese datos para comparar en la coleccion: ");
			Icomparable elemento=FabricaDeComparables.crearPorTeclado(opcion);
	
			if(c.contiene(elemento))
			{
				Console.WriteLine("");
				Console.WriteLine("El elemento leido esta en la coleccion");
			}
			else
			{
				Console.WriteLine("");
				Console.WriteLine("El elemento leido no esta en la coleccion");
			}
	
		}

		
//		7)Implemente una función imprimirElementos que reciba un coleccionable y usando el iterador del coleccionable imprima todos los elementos del coleccionable
		public static void imprimirElementos(Icoleccionable c)
		{
			Iterator iterador=c.crearIterador();
			
			while(!iterador.fin())
			{
				Console.WriteLine(iterador.actual());
				iterador.siguiente();
			}
		
		}
		
//		9)Implemente una función cambiarEstrategia que reciba un coleccionable y una estrategia de comparación (implementada en el ejercicio 1)
//		y asigne esa estrategia a todos los elementos del coleccionable
		public static void cambiarEstrategias(Icoleccionable c, Istrategy estrategia)
        {
            Iterator iteradorEstrategia=c.crearIterador();
            
            while(!iteradorEstrategia.fin())
            {
                Icomparable elemento=iteradorEstrategia.actual();
                ((Alumno)elemento).cambiarEstrategia(estrategia);
                
                iteradorEstrategia.siguiente();
            }
            
        }
		
		//a cada vendedor se le agrega el observador
		public static void registrarObservador(Icoleccionable c,IObservador o)
        {
            Iterator iterador = c.crearIterador();
            
            while (!iterador.fin())
            {
                Vendedor vendedorActual = (Vendedor)iterador.actual();
                vendedorActual.agregarObservador(o);
                iterador.siguiente();
            }

        }
		
//		TP3 -13) Implemente la función jornadaDeVentas.
		
		public static void jornadaDeVentas(Icoleccionable c)
		{
			Iterator iterador=c.crearIterador();
	
			while(!iterador.fin())
			{
				Vendedor vendedorActual = (Vendedor)iterador.actual();
				for(int i=0; i < 20; i++)
				{
					int monto=new Random().Next(1,7000);
					vendedorActual.venta(monto);
				}
				
				iterador.siguiente();
			}
		}
		
//		TP4-4)
		static void llenarStudent()
            {
                Teacher profesor = new Teacher();
                
                for (int i = 0; i < 10; i++)
                {
                    Alumno auxAlumno = (Alumno)FabricaDeComparables.crearAleatorio(2);
                    Student student = new StudentAdapter(auxAlumno);
                    profesor.goToClass(student);
                }
                for (int i = 0; i < 10; i++)
                {
                    AlumnoMuyEstudioso auxAlumnoEstudioso = ((AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4));
                    Student student = new StudentAdapter(auxAlumnoEstudioso);
                    profesor.goToClass(student);
                }


                profesor.teachingAClass();
            }
		
		static void llenarStudentDecorator()
		{
			Teacher profesor = new Teacher();
                
                for (int i = 0; i < 10; i++)
                {
                	IAlumno alumnoDecorado = (Alumno)FabricaDeComparables.crearAleatorio(2);
                    alumnoDecorado = new DecoradorLegajo(alumnoDecorado);
		            alumnoDecorado = new DecoradorNotaEnLetras(alumnoDecorado);
		            alumnoDecorado = new DecoradorPromocion(alumnoDecorado);
		            alumnoDecorado = new DecoradorAsteriscos(alumnoDecorado);
					Student student= new StudentAdapter(alumnoDecorado);

                    profesor.goToClass(student);
                }
                
                for (int i = 0; i < 10; i++)
                {
                    IAlumno alumnoMuyEstudiosoDecorado = ((AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4));
                    alumnoMuyEstudiosoDecorado = new DecoradorLegajo(alumnoMuyEstudiosoDecorado);
		            alumnoMuyEstudiosoDecorado = new DecoradorNotaEnLetras(alumnoMuyEstudiosoDecorado);
		            alumnoMuyEstudiosoDecorado = new DecoradorPromocion(alumnoMuyEstudiosoDecorado);
		            alumnoMuyEstudiosoDecorado = new DecoradorAsteriscos(alumnoMuyEstudiosoDecorado);
                    Student student = new StudentAdapter(alumnoMuyEstudiosoDecorado);
                    
                    profesor.goToClass(student);
                }


                profesor.teachingAClass();
			
		}
		
	
	}
}