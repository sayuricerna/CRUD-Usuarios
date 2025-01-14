using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion.Asistencias
{
    public partial class FrmAsistencias : Form
    {
        public bool modoEdision = false;
        public FrmAsistencias(String modo)
        {
            InitializeComponent();
            if (modo != "n") this.modoEdision = true;

        }
    }
}
