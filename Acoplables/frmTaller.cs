using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Rawrawrawr.Acoplables
{
    public partial class frmTaller : Form
    {
        Image fondo;
        SerialPort port;
        Thread t;
        List<Button> luces;
        /*
         11 AnteMesa
         12 Mesa
         13 Pasillo
         14 Baño
        */

        public frmTaller()
        {
            InitializeComponent();
        }

        private void ConectarPuerto(string puerto)
        {
            try
            {
                port = new SerialPort(puerto, 9600, Parity.None, 8, StopBits.One);

                port.Open();
                MessageBox.Show("Éxito al conectar al puerto " + puerto + ".");
            }
            catch (Exception e)
            {
                port.Close();
                port.Dispose();
                MessageBox.Show("Error al elegir puerto " + puerto + ". \nERROR: " + e.Message.ToString() + " " + e.StackTrace.ToString());
            }
        }

        private void frmTaller_Load(object sender, EventArgs e)
        {
            fondo = btnAleatorio.BackgroundImage;
            t = new Thread(new ThreadStart(ThreadAleatorio));

            luces = new List<Button>
            {
                btnAnteMesa,
                btnMesa,
                btnPasillo,
                btnBano
            };

            //ConectarPuerto("COM1");
        }

        #region botones
        private void btnAnteMesa_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
            PrenderLuz("11", sender as Button);
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
            PrenderLuz("12", sender as Button);
        }

        private void btnPasillo_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
            PrenderLuz("13", sender as Button);
        }

        private void btnBano_Click(object sender, EventArgs e)
        {
            ToggleLights(sender as Button);
            PrenderLuz("14", sender as Button);
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

        #endregion

        private void PrenderLuz(String arg, Button btn)
        {
            if (btn.BackColor.Equals(Color.Green))
            {
                port.Write("#ON" + arg + "\n");
            }
            else
            {
                port.Write("#OF" + arg + "\n");
            }
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

        private void btnPrenderTodo_Click(object sender, EventArgs e)
        {
            foreach (Button btn in luces)
            {
                btn.BackColor = Color.Green;
            }

            port.Write("#ON11\n");
            port.Write("#ON12\n");
            port.Write("#ON13\n");
            port.Write("#ON14\n");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            foreach (Button btn in luces)
            {
                btn.BackColor = Color.Red;
            }

            port.Write("#OF11\n");
            port.Write("#OF12\n");
            port.Write("#OF13\n");
            port.Write("#OF14\n");
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            if (btnAleatorio.BackColor.Equals(Color.Gray))
            { // modo aleatorio está encendido - apagar
                try
                {
                    btnAleatorio.BackgroundImage = fondo;
                    btnAleatorio.BackColor = Color.White;
                    t.Suspend();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al cerrar hilo. \nERROR: " + ex.Message.ToString() + " " + ex.StackTrace.ToString());
                }
            }
            else
            { // modo aleatorio está apagado - encender
                try
                {
                    btnAleatorio.BackgroundImage = null;
                    btnAleatorio.BackColor = Color.Gray;
                    
                    if (t.ThreadState.Equals(ThreadState.Unstarted))
                    {
                        t.Start();
                    }
                    else
                    {
                        t.Resume();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir hilo. \nERROR: " + ex.Message.ToString() + " " + ex.StackTrace.ToString());
                }
            }
        }

        public void ThreadAleatorio()
        {
            Random r = new Random();

            while (true)
            {
                int intRandom = r.Next(1, 5);
                Button luzRandom = luces[intRandom - 1];

                ToggleLights(luzRandom);

                if (luzRandom.BackColor.Equals(Color.Red))
                { // luz apagada - prender
                    port.Write("#ON1" + intRandom.ToString() + "\n");
                }
                else
                { // luz prendida - apagar
                    port.Write("#OF1" + intRandom.ToString() + "\n");
                }

                Thread.Sleep(150);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConectarPuerto(txtPuerto.Text);
        }
    }
}
