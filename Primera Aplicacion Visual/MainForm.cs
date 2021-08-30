using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Primera_Aplicacion_Visual
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

		}
		
		void Btn_saludarClick(object sender, EventArgs e)
		{
			txt_mostrar_saludo.Text = "Hola " + txt_ingresar_nombre.Text;			
		}
	}
}
