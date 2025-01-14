﻿using System;
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
    public partial class CUPersonal : UserControl
    {
        public CUPersonal()
        {
            InitializeComponent();
        }

        private void CUPersonal_Load(object sender, EventArgs e)
        {
            var logicaPersonal = new cls_personal();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = logicaPersonal.todos();
            this.cargaGrilla(1);
        }

        private void btnNuevoPersonal_Click(object sender, EventArgs e)
        {
            Personal.FrmPersonal frmPersonal = new Personal.FrmPersonal("n");
            frmPersonal.Text = "Nuevo Ingreso de Personal";
            frmPersonal.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.cargaGrilla(2);

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.cargaGrilla(2);
        }
        /*
         int numero = Parametro para identificar el tipo de carga ene la grilla
        1 => llama en lla clase clsperosnal al metodo todos
        2 => llama en la clase clspersonal al metodo buscar
         */
        public void cargaGrilla(int numero)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            var logicaPersonal = new cls_personal();
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
                dataGridView1.DataSource = logicaPersonal.todos();
            }
            else
            {
                dataGridView1.DataSource = logicaPersonal.buscador(txtBuscar.Text.Trim());
            }

            dataGridView1.Columns["cedula"].HeaderText = "Cédula";
            dataGridView1.Columns["nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["cargo"].HeaderText = "Cargo";
            dataGridView1.Columns["sueldo"].HeaderText = "Salario";
            dataGridView1.Columns["Detalle"].HeaderText = "Detalle";
            dataGridView1.Columns["IdPersonal"].Visible = false;
            dataGridView1.Columns["IdPais"].Visible = false;

            dataGridView1.Columns.Add(btnEditar);
            dataGridView1.Columns.Add(btnEliminar);

            //dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
        }
        public void EditarPersonal(int id)
        {
            Personal.FrmPersonal frmpersonal = new Personal.FrmPersonal(id.ToString());
            frmpersonal.ShowDialog();
            this.cargaGrilla(1);
        }
        public void ElimnarPersonal(int id)
        {
            DialogResult cuadrodialogo = MessageBox.Show("Esta srguro que desea eliminar el personal"
                , "Eliminar Personal", MessageBoxButtons.YesNo);
            if (cuadrodialogo == DialogResult.Yes)
            {
                var cls_personal = new cls_personal();
                if (cls_personal.eliminar(id))
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
                var IdPersonal = filaselecciona.Cells["IdPersonal"].Value;
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    EditarPersonal((int)IdPersonal);
                }
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    ElimnarPersonal((int)IdPersonal);
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
