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
        private Global.Service.Global service = new Global.Service.Global();
        public AreasForm()
        {
            InitializeComponent();
            var data = service.GetData("Employees");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var e = data.Rows;
                cbEmployees.Items.Add(e[i]["Name"].ToString());
            }
        }

        private void ShowAreas()
        {
            DataArea.DataSource = service.GetData("Areas");
        }

        private void AreasForm_Load(object sender, EventArgs e)
        {
            ShowAreas();
        }

        private void cComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
