using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using FeatureLayer;

namespace PresentationLayer
{
    public partial class FrmAreas : Form
    {
        private string idCategoria;
        public FrmAreas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAreas_Load(object sender, EventArgs e)
        {
            showSearchAreas("");
            tableMethodInitialize();
        }

        private void tableMethodInitialize()
        {
            tableArea.Columns[0].Visible = false;
            tableArea.Columns[1].Width = 60;
            tableArea.Columns[2].Width = 80;
            tableArea.Columns[3].Width = 85;

            tableArea.ClearSelection();
        }
        private void CleanForm()
        {
            txtCode.ResetText();
            txtName.ResetText();
            cbEmployees.ResetText();

            txtName.Focus();
        }

        private void showSearchAreas(string nameArea)
        {
            AreasService service = new AreasService();

            tableArea.DataSource = service.SearchAreas(nameArea);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showSearchAreas(tbSearch.Text);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tableArea.SelectedRows.Count > 0)
            {
                idCategoria = tableArea.CurrentRow.Cells[0].Value.ToString();
                txtCode.Text = tableArea.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = tableArea.CurrentRow.Cells[2].Value.ToString();
                cbEmployees.SelectedItem = tableArea.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
