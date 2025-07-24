namespace Telar
{
    partial class FmTelar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTelar));
            this.dgvTelar = new System.Windows.Forms.DataGridView();
            this.Coldiag = new System.Windows.Forms.ColorDialog();
            this.btnColores = new System.Windows.Forms.Button();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInterpretar = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelar)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTelar
            // 
            this.dgvTelar.AllowUserToAddRows = false;
            this.dgvTelar.AllowUserToDeleteRows = false;
            this.dgvTelar.AllowUserToResizeColumns = false;
            this.dgvTelar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvTelar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelar.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTelar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelar.ColumnHeadersHeight = 29;
            this.dgvTelar.ColumnHeadersVisible = false;
            this.dgvTelar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTelar.GridColor = System.Drawing.Color.Black;
            this.dgvTelar.Location = new System.Drawing.Point(70, 115);
            this.dgvTelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTelar.MultiSelect = false;
            this.dgvTelar.Name = "dgvTelar";
            this.dgvTelar.ReadOnly = true;
            this.dgvTelar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTelar.RowHeadersVisible = false;
            this.dgvTelar.RowHeadersWidth = 51;
            this.dgvTelar.RowTemplate.Height = 24;
            this.dgvTelar.Size = new System.Drawing.Size(312, 346);
            this.dgvTelar.TabIndex = 0;
            this.dgvTelar.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTelar_CellMouseDown);
            this.dgvTelar.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTelar_CellMouseMove);
            this.dgvTelar.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvTelar_CellStateChanged);
            this.dgvTelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTelar_MouseDown);
            this.dgvTelar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvTelar_MouseUp);
            // 
            // btnColores
            // 
            this.btnColores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColores.BackColor = System.Drawing.Color.Transparent;
            this.btnColores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColores.BackgroundImage")));
            this.btnColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColores.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnColores.FlatAppearance.BorderSize = 0;
            this.btnColores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnColores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColores.ForeColor = System.Drawing.Color.Transparent;
            this.btnColores.Location = new System.Drawing.Point(494, 115);
            this.btnColores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(79, 85);
            this.btnColores.TabIndex = 1;
            this.btnColores.UseVisualStyleBackColor = false;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.White;
            this.PanelSuperior.Controls.Add(this.btnMinimizar);
            this.PanelSuperior.Controls.Add(this.btnMaximizar);
            this.PanelSuperior.Controls.Add(this.btnSalir);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(600, 24);
            this.PanelSuperior.TabIndex = 2;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            this.PanelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseMove);
            this.PanelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(518, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 20);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(546, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 20);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(578, 2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInterpretar
            // 
            this.btnInterpretar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInterpretar.BackColor = System.Drawing.Color.Transparent;
            this.btnInterpretar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInterpretar.BackgroundImage")));
            this.btnInterpretar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInterpretar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterpretar.FlatAppearance.BorderSize = 0;
            this.btnInterpretar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterpretar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterpretar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInterpretar.Location = new System.Drawing.Point(494, 367);
            this.btnInterpretar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInterpretar.Name = "btnInterpretar";
            this.btnInterpretar.Size = new System.Drawing.Size(79, 75);
            this.btnInterpretar.TabIndex = 3;
            this.btnInterpretar.UseVisualStyleBackColor = false;
            this.btnInterpretar.Click += new System.EventHandler(this.btnInterpretar_Click);
            // 
            // btnBorrador
            // 
            this.btnBorrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrador.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrador.BackgroundImage")));
            this.btnBorrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrador.FlatAppearance.BorderSize = 0;
            this.btnBorrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrador.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrador.Location = new System.Drawing.Point(494, 240);
            this.btnBorrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(75, 79);
            this.btnBorrador.TabIndex = 4;
            this.btnBorrador.UseVisualStyleBackColor = false;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // FmTelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 570);
            this.Controls.Add(this.btnBorrador);
            this.Controls.Add(this.btnInterpretar);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.dgvTelar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FmTelar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FmTelar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelar)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelar;
        private System.Windows.Forms.ColorDialog Coldiag;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnInterpretar;
        private System.Windows.Forms.Button btnBorrador;
    }
}

