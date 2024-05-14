using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEtapa3Ahumada
{
    public partial class frmEtapa3 : Form
    {
        //Creo instancias de la clase clsVehiculo (para acceder a las propiedades y metodos de la clase clsVehiculo)
        private clsVehiculo auto;
        private clsVehiculo barco;
        private clsVehiculo avion;

        public frmEtapa3()
        {
            InitializeComponent();

            auto = new clsVehiculo("Auto", "Auto", Properties.Resources.auto);
            barco = new clsVehiculo("Barco", "Barco", Properties.Resources.barco);
            avion = new clsVehiculo("Avion", "Avion", Properties.Resources.avion);
        }

        private void MostrarVehiculo(clsVehiculo vehiculo)
        {
            pctImagen.Image = vehiculo.Imagen;
            pctImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void btnAuto_Click(object sender, EventArgs e)
        {
            MostrarVehiculo(auto);
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            MostrarVehiculo(barco);
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            MostrarVehiculo(avion);
        }
    }
}
