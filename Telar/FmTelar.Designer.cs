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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTelar));
            this.dgvTelar = new System.Windows.Forms.DataGridView();
            this.Coldiag = new System.Windows.Forms.ColorDialog();
            this.btnColores = new System.Windows.Forms.Button();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInterpretar = new System.Windows.Forms.Button();
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
            this.dgvTelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelar.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTelar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTelar.ColumnHeadersHeight = 29;
            this.dgvTelar.ColumnHeadersVisible = false;
            this.dgvTelar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTelar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTelar.Location = new System.Drawing.Point(31, 53);
            this.dgvTelar.MultiSelect = false;
            this.dgvTelar.Name = "dgvTelar";
            this.dgvTelar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTelar.RowHeadersVisible = false;
            this.dgvTelar.RowHeadersWidth = 51;
            this.dgvTelar.RowTemplate.Height = 24;
            this.dgvTelar.Size = new System.Drawing.Size(634, 703);
            this.dgvTelar.TabIndex = 0;
            this.dgvTelar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelar_CellClick);
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
            this.btnColores.Location = new System.Drawing.Point(702, 96);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(133, 130);
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
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(876, 30);
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
            this.btnMinimizar.Location = new System.Drawing.Point(767, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 24);
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
            this.btnMaximizar.Location = new System.Drawing.Point(804, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 24);
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
            this.btnSalir.Location = new System.Drawing.Point(847, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInterpretar
            // 
            this.btnInterpretar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInterpretar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterpretar.FlatAppearance.BorderSize = 0;
            this.btnInterpretar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterpretar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInterpretar.Location = new System.Drawing.Point(702, 462);
            this.btnInterpretar.Name = "btnInterpretar";
            this.btnInterpretar.Size = new System.Drawing.Size(146, 56);
            this.btnInterpretar.TabIndex = 3;
            this.btnInterpretar.Text = "Interpretar";
            this.btnInterpretar.UseVisualStyleBackColor = true;
            this.btnInterpretar.Click += new System.EventHandler(this.btnInterpretar_Click);
            // 
            // FmTelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(876, 778);
            this.Controls.Add(this.btnInterpretar);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.dgvTelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}

