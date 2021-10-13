
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
            ((System.ComponentModel.ISupportInitialize)(this.DataArea)).BeginInit();
            this.SuspendLayout();
            // 
            // DataArea
            // 
            this.DataArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataArea.Location = new System.Drawing.Point(56, 59);
            this.DataArea.Name = "DataArea";
            this.DataArea.RowHeadersWidth = 51;
            this.DataArea.RowTemplate.Height = 24;
            this.DataArea.Size = new System.Drawing.Size(554, 508);
            this.DataArea.TabIndex = 0;
            // 
            // AreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 640);
            this.Controls.Add(this.DataArea);
            this.Name = "AreasForm";
            this.Text = "AreasForm";
            this.Load += new System.EventHandler(this.AreasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataArea;
    }
}