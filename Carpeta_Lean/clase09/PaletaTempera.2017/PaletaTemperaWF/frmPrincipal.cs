using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PaletaTemperaWF
{
    public partial class frmPrincipal : Form
    {
        private List<Paleta> _paletas;

        public frmPrincipal()
        {
            InitializeComponent();
            this._paletas = new List<Paleta>();
            
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            foreach (ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
	{
	    	 
	}
            System.ConsoleColor

        }


    }
}
