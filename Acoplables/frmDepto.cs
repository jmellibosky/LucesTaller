using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Rawrawrawr.Acoplables
{
    public partial class frmDepto : Form
    {
        SerialPort port;


        public frmDepto()
        {
            InitializeComponent();
        }

        private void prueba()
        {
            if (btnComedor.BackColor.Equals(Color.Green))
            {
                port.Write("#ON11\n");
            }
            else
            {
                port.Write("#OF11\n");
            }
        }

        private void btnComedor_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);

            prueba();
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
        }

        private void btnLiving_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
        }

        private void btnBano_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
        }

        private void btnPasillo_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
        }

        private void btnHabitación_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
        }

        private void btnPatio_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
        }

        private void ToggleLights(Button btn)
        {
            if (btn.BackColor.Equals(Color.Red)) // El botón es rojo
            { // Se prende la luz
                /*
                PRENDER LUZ 
                */
                btn.BackColor = Color.Green;
            }
            else // El botón es verde
            { // Se apaga la luz
                /*
                APAGAR LUZ
                */
                btn.BackColor = Color.Red;
            }
        }

        private void btnAire_Click(object sender, EventArgs e)
        {
            if (btnAire.BackColor.Equals(Color.Red)) // El botón es rojo
            { // Se prende el aire
                /*
                PRENDER AIRE
                */
                btnAire.BackColor = Color.DeepSkyBlue;
            }
            else // El botón es verde
            { // Se apaga el aire
                /*
                APAGAR AIRE
                */
                btnAire.BackColor = Color.Red;
            }
        }

        private void frmDepto_Load(object sender, EventArgs e)
        {
            port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.Open();
        }
    }
}
