
namespace ProyectoMesaAyuda.Pages.Areas
{
    partial class AreasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataArea = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCB = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbEmployees = new ProyectoMesaAyuda.Controllers.CComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataArea)).BeginInit();
            this.SuspendLayout();
            // 
            // DataArea
            // 
            this.DataArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataArea.Location = new System.Drawing.Point(57, 59);
            this.DataArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataArea.Name = "DataArea";
            this.DataArea.RowHeadersWidth = 51;
            this.DataArea.RowTemplate.Height = 24;
            this.DataArea.Size = new System.Drawing.Size(475, 508);
            this.DataArea.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1048, 86);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1077, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1077, 133);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 22);
            this.textBox2.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1003, 137);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre :";
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Location = new System.Drawing.Point(989, 210);
            this.lblCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(79, 17);
            this.lblCB.TabIndex = 5;
            this.lblCB.Text = "Empleado :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(651, 505);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(364, 63);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1040, 505);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(364, 63);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cbEmployees
            // 
            this.cbEmployees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmployees.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbEmployees.BorderSize = 1;
            this.cbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEmployees.ForeColor = System.Drawing.Color.DimGray;
            this.cbEmployees.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbEmployees.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbEmployees.ListTextColor = System.Drawing.Color.DimGray;
            this.cbEmployees.Location = new System.Drawing.Point(1077, 190);
            this.cbEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmployees.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Padding = new System.Windows.Forms.Padding(1);
            this.cbEmployees.Size = new System.Drawing.Size(267, 37);
            this.cbEmployees.TabIndex = 9;
            this.cbEmployees.Texts = "";
            // 
            // AreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 640);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.DataArea);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AreasForm";
            this.Text = "AreasForm";
            this.Load += new System.EventHandler(this.AreasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataArea;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCB;
        private Controllers.CComboBox cComboBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private Controllers.CComboBox cbEmployees;
    }
}