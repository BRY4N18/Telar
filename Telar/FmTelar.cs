using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telar
{
    public partial class FmTelar : Form
    {
        Color pintura = Color.Transparent;
        private bool Arrastrar = false;        
        private Point formpoint;
        private Point Cursorpoint;
        public FmTelar()
        {
            InitializeComponent();
        }
        private void FmTelar_Load(object sender, EventArgs e)
        {
            CargarTelar();
        }        
        private void dgvTelar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTelar[e.ColumnIndex, e.RowIndex].Style.BackColor = pintura;
        }        
        private void CargarTelar()
        {
            //Ubicar la cantidad de filas y columnas que deseo
            const int celdas = 6;
            dgvTelar.RowCount = celdas;
            dgvTelar.ColumnCount = celdas;

            TamanoCeldas();

            dgvTelar.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Transparent;

        }
        private void TamanoCeldas()
        {
            //Ponerle tamañoa a los cuadros de la matriz
            for (int i = 0; i < dgvTelar.RowCount; i++)
                dgvTelar.Rows[i].Height = dgvTelar.Height / dgvTelar.RowCount;

            for (int i = 0; i < dgvTelar.ColumnCount; i++)
                dgvTelar.Columns[i].Width = dgvTelar.Width / dgvTelar.ColumnCount;
        }
        private void btnColores_Click(object sender, EventArgs e)
        {           
            Coldiag.ShowDialog();
            pintura = Coldiag.Color;
        }
        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Arrastrar = true;
                formpoint = this.Location;
                Cursorpoint = Cursor.Position;
            }
        }
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastrar) this.Location = formpoint + new Size(Cursor.Position - new Size(Cursorpoint));
        }
        private void PanelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastrar = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {            
            if (this.WindowState==FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
            TamanoCeldas();
        }
    }
}
