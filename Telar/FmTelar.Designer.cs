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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Progreso = new System.Windows.Forms.ProgressBar();
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
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvTelar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelar.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTelar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTelar.ColumnHeadersHeight = 29;
            this.dgvTelar.ColumnHeadersVisible = false;
            this.dgvTelar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelar.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTelar.GridColor = System.Drawing.Color.Black;
            this.dgvTelar.Location = new System.Drawing.Point(205, 96);
            this.dgvTelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTelar.MultiSelect = false;
            this.dgvTelar.Name = "dgvTelar";
            this.dgvTelar.ReadOnly = true;
            this.dgvTelar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTelar.RowHeadersVisible = false;
            this.dgvTelar.RowHeadersWidth = 51;
            this.dgvTelar.RowTemplate.Height = 24;
            this.dgvTelar.Size = new System.Drawing.Size(436, 423);
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
            this.btnColores.Location = new System.Drawing.Point(108, 630);
            this.btnColores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(211, 87);
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
            this.PanelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(840, 30);
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
            this.btnMinimizar.Location = new System.Drawing.Point(731, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 25);
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
            this.btnMaximizar.Location = new System.Drawing.Point(768, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 25);
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
            this.btnSalir.Location = new System.Drawing.Point(811, 2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 25);
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
            this.btnInterpretar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.btnInterpretar.FlatAppearance.BorderSize = 0;
            this.btnInterpretar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInterpretar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInterpretar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterpretar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterpretar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInterpretar.Location = new System.Drawing.Point(523, 630);
            this.btnInterpretar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInterpretar.Name = "btnInterpretar";
            this.btnInterpretar.Size = new System.Drawing.Size(209, 89);
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
            this.btnBorrador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.btnBorrador.FlatAppearance.BorderSize = 0;
            this.btnBorrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBorrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrador.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrador.Location = new System.Drawing.Point(315, 630);
            this.btnBorrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(207, 89);
            this.btnBorrador.TabIndex = 4;
            this.btnBorrador.UseVisualStyleBackColor = false;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // Progreso
            // 
            this.Progreso.BackColor = System.Drawing.Color.Bisque;
            this.Progreso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Progreso.Location = new System.Drawing.Point(243, 262);
            this.Progreso.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Progreso.MarqueeAnimationSpeed = 10000;
            this.Progreso.Maximum = 100000000;
            this.Progreso.Name = "Progreso";
            this.Progreso.Size = new System.Drawing.Size(369, 63);
            this.Progreso.Step = 1;
            this.Progreso.TabIndex = 5;
            this.Progreso.Visible = false;
            // 
            // FmTelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 740);
            this.Controls.Add(this.Progreso);
            this.Controls.Add(this.btnBorrador);
            this.Controls.Add(this.btnInterpretar);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.dgvTelar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ProgressBar Progreso;
    }
}

