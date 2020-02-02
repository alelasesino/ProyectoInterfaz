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

            Console.WriteLine("Desde: " + fechaDesde.Date.ToShortDateString() + ", Hasta: " + fechaHasta.ToShortDateString());

            foreach(int i in id_clientes)
                Console.WriteLine("ID_:" + i);

            loadReport(id_clientes, fechaDesde, fechaHasta);

        }

        private void loadReport(int[] id_clientes,DateTime fechaDesde,DateTime fechaHasta) {
        
            

            //reportViewer.ReportSource = cr;

        }

    }
}
