using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMesaAyuda.Controllers
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class CComboBox : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBlackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        private ComboBox cmdList;
        private Label lblText;
        private Button btnIcon;

        public event EventHandler OnSelectedIndexChanged;

        public CComboBox()
        {
            cmdList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cmdList.BackColor = backColor;
            cmdList.Font = new Font(this.Font.Name, 10F);
            cmdList.ForeColor = listTextColor;
            cmdList.SelectedIndexChanged += new EventHandler(CB_SelectedIndexChanged);
            cmdList.TextChanged += new EventHandler(CB_TextChanged);

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmdList);

            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            this.backColor = borderColor;

            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cmdList.Width = lblText.Width;
            cmdList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmdList.Width,
                Y = lblText.Bottom - cmdList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            cmdList.Select();
            if (cmdList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmdList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;

            var reactICon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Width - iconWidth) / 2);
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            cmdList.Select();
            cmdList.DroppedDown = true;
        }

        private void CB_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cmdList.Text;
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);

            lblText.Text = cmdList.Text;
        }
    }
}
