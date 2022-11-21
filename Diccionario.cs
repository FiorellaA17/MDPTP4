/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 13/11/2022
 * Hora: 18:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP4
{
	public class Diccionario : Icoleccionable
	{
		Conjunto conjuntoDiccionario=new Conjunto();
		ClaveValor cv;

		public Conjunto getConjuntoDiccionario {
			get {
				return conjuntoDiccionario;
			}
		}
			
		public Diccionario()
		{
		}
		
		public void agregar(Icomparable clave, Icomparable valor)
		{
			cv=new ClaveValor(clave,valor);
			this.conjuntoDiccionario.agregar(cv);	
		}
		
		public Icomparable valorDe(Icomparable clave)
		{	
			Iterator iteradorConjunto=conjuntoDiccionario.crearIterador();
            while(!iteradorConjunto.fin())
            {
                Icomparable elem=iteradorConjunto.actual();
                if(clave.sosIgual(elem))
                {
                    return elem;
                }
                
                iteradorConjunto.siguiente();
            }
            
            return null;
		}
		
		
		#region Icoleccionable implementation
		public int cuantos()
		{
			return getConjuntoDiccionario.cuantos();
//			throw new NotImplementedException();
		}
		public Icomparable minimo()
		{
			return conjuntoDiccionario.minimo();

		}
		public Icomparable maximo()
		{
			return conjuntoDiccionario.maximo();
		}
		public void agregar(Icomparable c)
		{
			conjuntoDiccionario.agregar(c);
		}
		public bool contiene(Icomparable c)
		{
			return conjuntoDiccionario.contiene(c);
		}
		#endregion

		public Iterator crearIterador()
		{
			return new IteradorDeColeccion(getConjuntoDiccionario);
//			throw new NotImplementedException();
		}
	}
}
