/*
 * Created by SharpDevelop.
 * User: PC-10
 * Date: 8/5/2023
 * Time: 08:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;


namespace Ejercicio1
{
	/// <summary>
	/// Description of Cuenta.
	/// </summary>
	/// 
	public class Cuenta
	{
		private int numeroCuenta;
		public string titular;
		private float saldo;
		private List< Movimientos> Move = new List<Movimientos>();
		
		public int num = -1;
		
		public Cuenta()
		{
			Random rnd = new Random();
			numeroCuenta = rnd.Next(13,13);
		}
		
		public int NumeroCuenta{
			get{return numeroCuenta;}
		}
		
		public void CrearMovimiento(){
			num++;
			Move.Add(new Movimientos());
		}
		public void GuardarMovimiento(){
			if (num > -1){
			saldo += Move[num].Cantidad;
			}
		}
	}
}
