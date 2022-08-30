using Pea2.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pea2.App.win
{
    public partial class pea2 : Form
    {
        public pea2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iniciarformmulario(object sender, EventArgs e)
        {
            cargarDatos();

        }
        private void cargarDatos()
        {
            var listado = ClienteBL.Listar();
            foreach (var Cliente in listado)
            {
                dgvListado.Rows.Add(Cliente.ID, Cliente.categoria, Cliente.cliente, Cliente.producto);
            }

        }

        private void nuevoregistro(object sender, EventArgs e)
        {
            var frm = new FmrEditCliente();
        }
    }
}
