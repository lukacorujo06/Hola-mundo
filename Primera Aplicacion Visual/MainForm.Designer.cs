/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 20/8/2021
 * Time: 8:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Primera_Aplicacion_Visual
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.txt_ingresar_nombre = new System.Windows.Forms.TextBox();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.btn_saludar = new System.Windows.Forms.Button();
			this.txt_mostrar_saludo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txt_ingresar_nombre
			// 
			this.txt_ingresar_nombre.Location = new System.Drawing.Point(12, 40);
			this.txt_ingresar_nombre.Name = "txt_ingresar_nombre";
			this.txt_ingresar_nombre.Size = new System.Drawing.Size(260, 20);
			this.txt_ingresar_nombre.TabIndex = 0;
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(12, 14);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(260, 23);
			this.lbl_nombre.TabIndex = 1;
			this.lbl_nombre.Text = "Nombre:";
			this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_saludar
			// 
			this.btn_saludar.Location = new System.Drawing.Point(92, 82);
			this.btn_saludar.Name = "btn_saludar";
			this.btn_saludar.Size = new System.Drawing.Size(89, 23);
			this.btn_saludar.TabIndex = 2;
			this.btn_saludar.Text = "SALUDAR";
			this.btn_saludar.UseVisualStyleBackColor = true;
			this.btn_saludar.Click += new System.EventHandler(this.Btn_saludarClick);
			// 
			// txt_mostrar_saludo
			// 
			this.txt_mostrar_saludo.Location = new System.Drawing.Point(81, 167);
			this.txt_mostrar_saludo.Name = "txt_mostrar_saludo";
			this.txt_mostrar_saludo.Size = new System.Drawing.Size(111, 20);
			this.txt_mostrar_saludo.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txt_mostrar_saludo);
			this.Controls.Add(this.btn_saludar);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.txt_ingresar_nombre);
			this.Name = "MainForm";
			this.Text = "Primera Aplicacion Visual";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txt_mostrar_saludo;
		private System.Windows.Forms.Button btn_saludar;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.TextBox txt_ingresar_nombre;
	}
}
