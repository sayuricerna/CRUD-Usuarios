using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Mi_Primera_Vez.Logica;
using _01_Mi_Primera_Vez.Datos;

namespace _01_Mi_Primera_Vez.Presentacion.Personal
{
    public partial class FrmPersonal : Form
    {
        public bool modoEdision = false;
        public int id = 0;

        public FrmPersonal( String modo)
        {
            InitializeComponent();
            if (modo != "n")
            {
                this.modoEdision = true;
                this.id = int.Parse(modo);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            if (!this.modoEdision) 
            {
                lblFrmPersonal.Text = "Ingreso de Nuevo Personal";
            }
            else
            {
                lblFrmPersonal.Text = " Actualizacion de Personal";
            }
            var listapaises = new cls_pais();
            cmbPais.DataSource = listapaises.leer();
            cmbPais.ValueMember = "IdPais";
            cmbPais.DisplayMember = "Detalle";
        }
        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == " " || txtNombre.Text == " " || txtCargo.Text == " " || txtSalario.Text == " ")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }
            if (!decimal.TryParse(txtSalario.Text, out var sueldo))
            {
                MessageBox.Show("El salario debe ser un número válido");
                return;
            }
            try
            {
                var dto_personal = new Datos.dto_personal
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Cargo = txtCargo.Text,
                    Sueldo = sueldo,
                    IdPais = (int)cmbPais.SelectedValue,
                };
                var cls_personal = new cls_personal();
                if (!this.modoEdision)
                {
                    var resultado = cls_personal.Insertar(dto_personal);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Se guardó con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error al guardar: {resultado}");
                    }
                }
                else
                {
                    dto_personal.IdPersonal = this.id;
                    var resultado = cls_personal.actualizar(dto_personal);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Se actualizó con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
