/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public abstract class FabricaDeComparables
	{
		public const int NUMERO = 1;
		public const int ALUMNO= 2;
		public const int VENDEDOR=3;
		public const int ALUMNOMUYESTUDIOSO=4;
		
		
		public static Icomparable crearPorTeclado(int seleccion)
		{
			FabricaDeComparables fabrica= null;
			
			switch(seleccion)
			{
				case NUMERO: 
					fabrica = new FabricaDeNumeros();
			        break;
				case ALUMNO:
			        fabrica = new FabricaDeAlumnos();
			        break;
			 	case VENDEDOR:
			        fabrica = new FabricaDeVendedores();
			        break;
			    case ALUMNOMUYESTUDIOSO:
			        fabrica=new FabricaDeAlumnosMuyEstudiosos();
			        break;
			        
			   
			}
			
			return fabrica.crearPorTeclado();
		}
		
		public abstract Icomparable crearPorTeclado();
		
		public static Icomparable crearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica= null;
			
			if(opcion==1)
			{
				fabrica=new FabricaDeNumeros();
			}
			
			if(opcion==2)
			{
				fabrica=new FabricaDeAlumnos();
			}
			
			if(opcion==3)
			{
				fabrica=new FabricaDeVendedores();
			}
			if(opcion==4)
			{
				fabrica=new FabricaDeAlumnosMuyEstudiosos();
			}
						
			return fabrica.crearAleatorio();
		}
		
		public abstract Icomparable crearAleatorio();
		
	}
}
