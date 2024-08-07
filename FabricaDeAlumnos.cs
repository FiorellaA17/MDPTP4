﻿/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		override public Icomparable crearPorTeclado()
		{
			 Console.Write("ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("ingrese dni: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("ingrese legajo: ");
            int legajo = int.Parse(Console.ReadLine());
            Console.Write("ingrese promedio: ");
            int promedio = int.Parse(Console.ReadLine());

            return new Alumno( nombre,dni,legajo,promedio);
		}
		
	 	override public Icomparable crearAleatorio( )
        {
           string [] listaNombres= {"Ana", "juan", "jose", "ruth", "gael", "pedro", "esther", "maria", "belen", "pablo", "lucas", "mia", "lucia", "Leonel", "Dante","milena","giovanni","luciano","mauro","stefania","catalina","milton"};
			Random random = new Random();

            string auxNombre = listaNombres[random.Next(0, listaNombres.Length)];
           
            return new Alumno(auxNombre,random.Next(50000000), random.Next(listaNombres.Length),random.Next(10));
        }
	}
}
