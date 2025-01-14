namespace _01_Mi_Primera_Vez.Presentacion
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_respaldos = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_asistencias = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.Panel_Bienvenida = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.PanelGeneral.SuspendLayout();
            this.Panel_Bienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_respaldos);
            this.panel1.Controls.Add(this.btn_restaurar);
            this.panel1.Controls.Add(this.btn_personal);
            this.panel1.Controls.Add(this.btn_asistencias);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 950);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 748);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Control de Asistencias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::_01_Mi_Primera_Vez.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 571);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_respaldos
            // 
            this.btn_respaldos.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_respaldos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_respaldos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_respaldos.Image = global::_01_Mi_Primera_Vez.Properties.Resources.respaldos;
            this.btn_respaldos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_respaldos.Location = new System.Drawing.Point(0, 484);
            this.btn_respaldos.Name = "btn_respaldos";
            this.btn_respaldos.Size = new System.Drawing.Size(212, 87);
            this.btn_respaldos.TabIndex = 3;
            this.btn_respaldos.Text = "Respaldos";
            this.btn_respaldos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_respaldos.UseVisualStyleBackColor = false;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_restaurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_restaurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurar.Image = global::_01_Mi_Primera_Vez.Properties.Resources.restaurarDB;
            this.btn_restaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restaurar.Location = new System.Drawing.Point(0, 398);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(212, 86);
            this.btn_restaurar.TabIndex = 2;
            this.btn_restaurar.Text = "Restaurar BD";
            this.btn_restaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restaurar.UseVisualStyleBackColor = false;
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_personal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_personal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personal.ForeColor = System.Drawing.Color.Black;
            this.btn_personal.Image = global::_01_Mi_Primera_Vez.Properties.Resources.personal;
            this.btn_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personal.Location = new System.Drawing.Point(0, 301);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(212, 97);
            this.btn_personal.TabIndex = 1;
            this.btn_personal.Text = "Personal";
            this.btn_personal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_asistencias
            // 
            this.btn_asistencias.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_asistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_asistencias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asistencias.ForeColor = System.Drawing.Color.Black;
            this.btn_asistencias.Image = global::_01_Mi_Primera_Vez.Properties.Resources.asistencia;
            this.btn_asistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asistencias.Location = new System.Drawing.Point(0, 206);
            this.btn_asistencias.Name = "btn_asistencias";
            this.btn_asistencias.Size = new System.Drawing.Size(212, 95);
            this.btn_asistencias.TabIndex = 0;
            this.btn_asistencias.Text = "Asistencias";
            this.btn_asistencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_asistencias.UseVisualStyleBackColor = false;
            this.btn_asistencias.Click += new System.EventHandler(this.btn_asistencias_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 206);
            this.panel3.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(212, 106);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelGeneral.Controls.Add(this.Panel_Bienvenida);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(212, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(873, 950);
            this.PanelGeneral.TabIndex = 1;
            // 
            // Panel_Bienvenida
            // 
            this.Panel_Bienvenida.Controls.Add(this.label2);
            this.Panel_Bienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Bienvenida.Location = new System.Drawing.Point(0, 0);
            this.Panel_Bienvenida.Name = "Panel_Bienvenida";
            this.Panel_Bienvenida.Size = new System.Drawing.Size(873, 950);
            this.Panel_Bienvenida.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(873, 950);
            this.label2.TabIndex = 0;
            this.label2.Text = "BIENVENIDO AL SISTEMA DE CONTROL DE ASISTENCIAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 950);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.PanelGeneral.ResumeLayout(false);
            this.Panel_Bienvenida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.Button btn_asistencias;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_respaldos;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Bienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUsuarios;
    }
}