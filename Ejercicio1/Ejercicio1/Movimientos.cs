/*
 * Created by SharpDevelop.
 * User: PC-10
 * Date: 8/5/2023
 * Time: 08:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of Movimientos.
	/// </summary>
	public class Movimientos
	{
		private string concepto;
		private float cantidad;
		
		public Movimientos()
		{
		}
		public string Concepto{get{return concepto;}set{concepto = value;}}
		public float Cantidad{get{return cantidad;}set{cantidad=value;}}
	}
}
