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
public class FabricaDeNumeros : FabricaDeComparables
	{
		override public Icomparable crearAleatorio()
        {
            return new Numero(new Random().Next(0,1000));
        }

        override public Icomparable crearPorTeclado()
        {
            Console.Write("ingrese un numero a comparar: ");
            int numero = int.Parse(Console.ReadLine());
            return new Numero(numero);
        }
		
	}
}
