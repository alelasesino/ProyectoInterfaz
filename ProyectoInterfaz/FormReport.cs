using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInterfaz {
    public partial class FormReport:Form {

        public FormReport(int[] id_clientes, DateTime fechaDesde, DateTime fechaHasta) {
            InitializeComponent();
            
            string str_id_clientes = string.Join(",",id_clientes);

            Console.WriteLine("Desde: " + fechaDesde.Date.ToShortDateString() + ", Hasta: " + fechaHasta.ToShortDateString());

            Console.WriteLine(str_id_clientes);

            loadReport(str_id_clientes, fechaDesde, fechaHasta);

        }

        private void loadReport(string idClientes,DateTime fechaDesde,DateTime fechaHasta) {
            
            polizasClientes.SetParameterValue("idClientes",idClientes);
            polizasClientes.SetParameterValue("fechaDesde",fechaDesde);
            polizasClientes.SetParameterValue("fechaHasta",fechaHasta);

        }

    }
}
