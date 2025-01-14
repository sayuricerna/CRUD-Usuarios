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

namespace _01_Mi_Primera_Vez.Presentacion.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        public bool modoEdision = false;
        public int id = 0;
        public FrmUsuarios(string modo)
        {
            InitializeComponent();
            if (modo != "n")
            {
                this.modoEdision = true;
                this.id = int.Parse(modo);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == " " || txtContrasenia.Text == " " )
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }
            try
            {
                var dto_usuario = new Datos.dto_usuario
                {
                    NombreUsuario = txtUsuario.Text,
                    Contrasenia = txtContrasenia.Text,
                };
                var cls_usuario = new cls_usuario();
                if (!this.modoEdision)
                {
                    var resultado = cls_usuario.Insertar(dto_usuario);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Se guardó con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar");
                    }
                }
                else
                {
                    dto_usuario.IdUsuario = this.id;
                    var resultado = cls_usuario.actualizar(dto_usuario);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Se actualizó con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error al actualizar");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (!this.modoEdision)
            {
                lblFrmUsuarios.Text = "Ingreso de Nuevo Usuario";
            }
            else
            {
                lblFrmUsuarios.Text = " Actualizacion de Usuario";
                var clsUsuario = new cls_usuario();
                var usuario = clsUsuario.buscarPorId(this.id);
                txtUsuario.Text = usuario.NombreUsuario;
                txtContrasenia.Text = usuario.Contrasenia;
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
