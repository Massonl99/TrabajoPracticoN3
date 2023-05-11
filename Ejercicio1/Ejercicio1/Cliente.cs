/*
 * Created by SharpDevelop.
 * User: PC-10
 * Date: 8/5/2023
 * Time: 08:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicio1
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		private int dni;
		private string nombre;
		private string apellido;
		
		private List< Cuenta> Cuentas = new List<Cuenta>();
		
		private int nume = -1;
		
		public Cliente()
		{
		}
		public void CrearCuenta(){
			nume++;
			Cuentas.Add(new Cuenta());
		}
		public int DNI {get{return dni;}set{dni=value;}}
		public string Nombre {get{return nombre;}set{nombre=value;}}
		public string Apellido {get{return apellido;}set{apellido=value;}}
	}
}
