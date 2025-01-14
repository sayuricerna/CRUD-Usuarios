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

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUUsuarios : UserControl
    {
        public CUUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Usuarios.FrmUsuarios frmUsuarios = new Usuarios.FrmUsuarios("n");
            frmUsuarios.Text = "Nuevo Ingreso de Usuario";
            frmUsuarios.ShowDialog();
        }
        public void cargaGrilla(int numero)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            var logicaUsuario = new cls_usuario();
            var autoincrmento = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dataGridView1.Columns.Add(autoincrmento);

            var btnEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            if (numero == 1)
            {
                dataGridView1.DataSource = logicaUsuario.todos();
            }
            else
            {
                dataGridView1.DataSource = logicaUsuario.buscador(txtBuscar.Text.Trim());
            }

            dataGridView1.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
            dataGridView1.Columns["Contrasenia"].HeaderText = "Contraseña";
            dataGridView1.Columns["CreateAt"].HeaderText = "Creación";
            dataGridView1.Columns["ModifiedAt"].HeaderText = "Última actualización";
            dataGridView1.Columns["IdUsuario"].Visible = false;

            dataGridView1.Columns.Add(btnEditar);
            dataGridView1.Columns.Add(btnEliminar);
        }

        private void CUUsuarios_Load(object sender, EventArgs e)
        {
            var logicaUsuario = new cls_personal();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = logicaUsuario.todos();
            this.cargaGrilla(1);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.cargaGrilla(2);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.cargaGrilla(2);

        }
        public void EditarUsuario(int id)
        {
            Usuarios.FrmUsuarios frm = new Usuarios.FrmUsuarios(id.ToString());
            frm.ShowDialog();
            this.cargaGrilla(1);
        }
        public void EliminarUsuario(int id)
        {
            DialogResult cuadrodialogo = MessageBox.Show("Esta srguro que desea eliminar el usuario"
                , "Eliminar Usuario", MessageBoxButtons.YesNo);
            if (cuadrodialogo == DialogResult.Yes)
            {
                var cls_usuario = new cls_usuario();
                if (cls_usuario.eliminar(id))
                {
                    MessageBox.Show("El registro se a eliminado con exito");
                    this.cargaGrilla(1);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la eliminacion");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var filaselecciona = dataGridView1.Rows[e.RowIndex];
                var IdUsuario = filaselecciona.Cells["IdUsuario"].Value;
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    EditarUsuario((int)IdUsuario);
                }
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    EliminarUsuario((int)IdUsuario);
                }
            }

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
