using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CapaNegocio;

namespace Telar
{
    public partial class FmTelar : Form
    {
        Color pintura = Color.Transparent;
        private bool Arrastrar = false;
        private bool Pulsar = false;
        private Point formpoint;
        private Point Cursorpoint;
        private ConexionPython comunicacion;
        public FmTelar()
        {
            InitializeComponent();
        }
        private void CargarTelar()
        {
            //Ubicar la cantidad de filas y columnas que deseo
            const int celdas = 13;
            dgvTelar.RowCount = celdas;
            dgvTelar.ColumnCount = celdas;

            TamanoCeldas();
        }
        private void TamanoCeldas()
        {
            //Ponerle tamaño a las celdas de la matriz
            for (int i = 0; i < dgvTelar.RowCount; i++)
                dgvTelar.Rows[i].Height = dgvTelar.Height / dgvTelar.RowCount;

            for (int i = 0; i < dgvTelar.ColumnCount; i++)
                dgvTelar.Columns[i].Width = dgvTelar.Width / dgvTelar.ColumnCount;
        }
        private async void MatrizTelar()
        {
            comunicacion = new ConexionPython();
            string matri = "";

            int fila = dgvTelar.Rows.Count, columna = dgvTelar.Columns.Count;
            Color celda = Color.White;
            string[,] matrizTelar = new string[fila,columna];
            for (int i = 0; i < columna; i++)
                for (int j = 0; j < fila; j++)
                {
                    celda = dgvTelar[i,j].Style.BackColor;
                    ColorTranslator.ToHtml(celda);
                    matrizTelar[j, i] = celda.Name;
                }

            matri = "[";
            for (int i = 0; i < columna; i++)
            {
                matri += "[";
                for (int j = 0; j < fila; j++)
                    matri += (j != fila - 1) ? "'" + matrizTelar[j, i] + "'" + "," : "'" + matrizTelar[j, i] + "'";
                matri += (i != columna - 1) ? "]" : "]]";
            }

            FmCargando carga = new FmCargando();
            carga.Show();

            string mensaje = await comunicacion.RespuestaMatriz(matri);
            carga.Hide();
            MessageBox.Show(mensaje.ToString());
        }
        private void FmTelar_Load(object sender, EventArgs e)
        {
            CargarTelar();
        }                      
        private void btnColores_Click(object sender, EventArgs e)
        {           
            Coldiag.ShowDialog();
            pintura = Coldiag.Color;
            dgvTelar.Cursor = Cursors.Hand;
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
        private void btnInterpretar_Click(object sender, EventArgs e)
        {
            MatrizTelar();       
        }
        private void dgvTelar_MouseUp(object sender, MouseEventArgs e)
        {
            Pulsar = false;
        }
        private void dgvTelar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Pulsar = true;
        }
        private void dgvTelar_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTelar.Cursor != Cursors.Hand)
                pintura = Color.White;

            if (Pulsar) dgvTelar[e.ColumnIndex, e.RowIndex].Style.BackColor = pintura;
        }
        private void dgvTelar_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                e.Cell.Selected = false;
            }
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            //Por si se elimina el cursor
            //FileStream file = new FileStream("BorradorCursor.cur", FileMode.OpenOrCreate, FileAccess.Write);
            //file.Close();
            Cursor raton = new Cursor("BorradorCursor.cur");
            dgvTelar.Cursor = raton;
        }
        private void dgvTelar_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvTelar[e.ColumnIndex, e.RowIndex].Style.BackColor = pintura;
        }
    }
}