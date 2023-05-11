/*
 * Created by SharpDevelop.
 * User: PC-10
 * Date: 8/5/2023
 * Time: 08:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button NuevoCliente;
		private System.Windows.Forms.Label labelC1;
		private System.Windows.Forms.TextBox tbC1;
		private System.Windows.Forms.TextBox tbC2;
		private System.Windows.Forms.Label labelC2;
		private System.Windows.Forms.TextBox tbC3;
		private System.Windows.Forms.Label labelC3;
		private System.Windows.Forms.Button btGuardar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.NuevoCliente = new System.Windows.Forms.Button();
			this.labelC1 = new System.Windows.Forms.Label();
			this.tbC1 = new System.Windows.Forms.TextBox();
			this.tbC2 = new System.Windows.Forms.TextBox();
			this.labelC2 = new System.Windows.Forms.Label();
			this.tbC3 = new System.Windows.Forms.TextBox();
			this.labelC3 = new System.Windows.Forms.Label();
			this.btGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NuevoCliente
			// 
			this.NuevoCliente.Location = new System.Drawing.Point(12, 12);
			this.NuevoCliente.Name = "NuevoCliente";
			this.NuevoCliente.Size = new System.Drawing.Size(85, 23);
			this.NuevoCliente.TabIndex = 0;
			this.NuevoCliente.Text = "Nuevo Cliente";
			this.NuevoCliente.UseVisualStyleBackColor = true;
			this.NuevoCliente.Click += new System.EventHandler(this.NuevoClienteClick);
			// 
			// labelC1
			// 
			this.labelC1.Location = new System.Drawing.Point(12, 50);
			this.labelC1.Name = "labelC1";
			this.labelC1.Size = new System.Drawing.Size(100, 23);
			this.labelC1.TabIndex = 1;
			this.labelC1.Text = "Nombre";
			// 
			// tbC1
			// 
			this.tbC1.Location = new System.Drawing.Point(118, 47);
			this.tbC1.Name = "tbC1";
			this.tbC1.Size = new System.Drawing.Size(100, 20);
			this.tbC1.TabIndex = 2;
			// 
			// tbC2
			// 
			this.tbC2.Location = new System.Drawing.Point(118, 70);
			this.tbC2.Name = "tbC2";
			this.tbC2.Size = new System.Drawing.Size(100, 20);
			this.tbC2.TabIndex = 4;
			// 
			// labelC2
			// 
			this.labelC2.Location = new System.Drawing.Point(12, 73);
			this.labelC2.Name = "labelC2";
			this.labelC2.Size = new System.Drawing.Size(100, 23);
			this.labelC2.TabIndex = 3;
			this.labelC2.Text = "Apellido";
			// 
			// tbC3
			// 
			this.tbC3.Location = new System.Drawing.Point(118, 93);
			this.tbC3.Name = "tbC3";
			this.tbC3.Size = new System.Drawing.Size(100, 20);
			this.tbC3.TabIndex = 6;
			// 
			// labelC3
			// 
			this.labelC3.Location = new System.Drawing.Point(12, 96);
			this.labelC3.Name = "labelC3";
			this.labelC3.Size = new System.Drawing.Size(100, 23);
			this.labelC3.TabIndex = 5;
			this.labelC3.Text = "DNI";
			// 
			// btGuardar
			// 
			this.btGuardar.Location = new System.Drawing.Point(15, 137);
			this.btGuardar.Name = "btGuardar";
			this.btGuardar.Size = new System.Drawing.Size(75, 23);
			this.btGuardar.TabIndex = 7;
			this.btGuardar.Text = "Guardar";
			this.btGuardar.UseVisualStyleBackColor = true;
			this.btGuardar.Click += new System.EventHandler(this.BtGuardarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 297);
			this.Controls.Add(this.btGuardar);
			this.Controls.Add(this.tbC3);
			this.Controls.Add(this.labelC3);
			this.Controls.Add(this.tbC2);
			this.Controls.Add(this.labelC2);
			this.Controls.Add(this.tbC1);
			this.Controls.Add(this.labelC1);
			this.Controls.Add(this.NuevoCliente);
			this.Name = "MainForm";
			this.Text = "Ejercicio1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
