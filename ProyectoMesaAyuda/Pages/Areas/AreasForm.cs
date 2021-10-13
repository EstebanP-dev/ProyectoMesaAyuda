using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMesaAyuda.Pages.Areas
{
    public partial class AreasForm : Form
    {
        private Service.Areas service = new Service.Areas();
        public AreasForm()
        {
            InitializeComponent();
        }

        private void ShowAreas()
        {
            DataArea.DataSource = service.GetAreas();
        }

        private void AreasForm_Load(object sender, EventArgs e)
        {
            ShowAreas();
        }
    }
}
