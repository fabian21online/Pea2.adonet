using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pea2.App.win
{
    public partial class FmrEditCliente : Form
    {
        Cliente cliente;
        public FmrEditCliente(cliente cliente)  
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void iniciarformulario(object sender, EventArgs e)
        {
  
        }
    }
}
