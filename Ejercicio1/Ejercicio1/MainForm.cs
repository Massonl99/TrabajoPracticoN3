/*
 * Created by SharpDevelop.
 * User: PC-10
 * Date: 8/5/2023
 * Time: 08:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int numeroClientes = 0;
		private List< Cliente> Clientes = new List<Cliente>();
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			DeshabilitarCliente();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void DeshabilitarCliente(){
			labelC1.Visible=false;
			labelC2.Visible=false;
			labelC3.Visible=false;
			tbC1.Visible=false;
			tbC2.Visible=false;
			tbC3.Visible=false;
			btGuardar.Visible=false;
		}
		public void HabiliarCliente(){
			labelC1.Visible=true;
			labelC2.Visible=true;
			labelC3.Visible=true;
			tbC1.Visible=true;
			tbC2.Visible=true;
			tbC3.Visible=true;
			btGuardar.Visible=true;
		}
		public void OcultarClientes(){
			tbC1.Enabled = false;
			tbC2.Enabled = false;
			tbC3.Enabled = false;
		}
		
		void NuevoClienteClick(object sender, EventArgs e)
		{
			numeroClientes++;
			Clientes.Add(new Cliente());
			HabiliarCliente();
		}
		void BtGuardarClick(object sender, EventArgs e)
		{
			Clientes[numeroClientes-1].Nombre = tbC1.Text;
			Clientes[numeroClientes-1].Apellido = tbC2.Text;
			Clientes[numeroClientes-1].DNI = Int32.Parse(tbC3.Text);
			OcultarClientes();
			
		}
	}
}
