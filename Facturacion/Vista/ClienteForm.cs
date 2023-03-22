using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Datos;
using Entidades;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        ClienteDB clienteDB = new ClienteDB();
        Cliente clientes = new Cliente


        private void ClienteForm_Load(object sender, EventArgs e)
        {
            TraerClientes();

        }

        private void TraerClientes ()
        {
            dt = clienteDB.DevolverCliente();
            dtgCliente.DataSource  = dt;
        }
    }
}
