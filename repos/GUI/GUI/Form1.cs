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

namespace GUI
{
    public partial class Form1 : Form
    {

        bool isConnected = false;
        String[] ports;
        SerialPort port;
        private DateTime datetime;
        private string Port_Data;

        public Form1()
        {
            InitializeComponent();        
            getAvailableComPorts();

            foreach (string port in ports)
            {
                Port_Box.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    Port_Box.SelectedItem = ports[0];
                }
            }
        }

        private void Check_Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                GetSelectedID();
             port.Write("#Check\n");              
            }
        }

        private void Check_All_Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {           
             port.Write("#CheckAll\n");                
            }
        }

        private void Call_Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                GetSelectedID();
                port.Write("#Call\n");               
            }
        }

        private void Call_All_Button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {            
              port.Write("#CallAll\n");                             
            }
        }

        private void Port_Button_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = Port_Box.GetItemText(Port_Box.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += port_DataReceived;

            try
            {
                port.Open();
                port.Write("#STAR\n");
                Port_Button.Text = "Se Déconnecter";
                MessageBox.Show("Vous êtes maintenant connecté!");
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Erreur de connection");

            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Port_Data = port.ReadLine();
            this.Invoke(new EventHandler(displaydata));
        }

        private void displaydata(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            Name_List.Items.Add(time + "           " + Port_Data);
        }

        private void disconnectFromArduino()
        {
            try
            {
                isConnected = false;
                port.Write("#STOP\n");
                port.Close();
                Port_Button.Text = "Se Connecter";
                MessageBox.Show("Vous êtes maintenant déconnecté!");

            }
            catch (Exception ex2) {
                MessageBox.Show(ex2.Message, "Erreur de déconnection");

            }
        }

        private void GetSelectedID() 
        {
        /* get the id from the selected person from the list box */
        }

    }
}
