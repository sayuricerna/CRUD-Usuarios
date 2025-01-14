using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void btn_personal_Click(object sender, EventArgs e)
        {
            CUPersonal frmPersonal = new CUPersonal();
            PanelGeneral.Controls.Clear();
            frmPersonal.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPersonal);
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CUUsuarios frmUsuarios = new CUUsuarios();
            PanelGeneral.Controls.Clear();
            frmUsuarios.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmUsuarios);
        }
        private void btn_asistencias_Click(object sender, EventArgs e)
        {
            Asistencias.FrmAsistencias frmAsistencias = new Asistencias.FrmAsistencias("n");
            frmAsistencias.Text = "Nuevo Ingreso de Personal";
            frmAsistencias.ShowDialog();
        }
    }
}
