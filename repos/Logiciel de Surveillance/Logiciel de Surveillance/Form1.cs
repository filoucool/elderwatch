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


namespace Logiciel_de_Surveillance
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private DateTime datetime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Verify_Button_Click(object sender, EventArgs e)
        {
            //VERIFIES THE STATUS OF THE SELECTED PERSON AND UPDATES THE STATUS LIST
        }

        private void Verify_All_Button(object sender, EventArgs e)
        {
            //VERIFIES EVERYONE'S STATUS AND UPDATES THE STATUS LIST
        }

        private void Call_Button_Click(object sender, EventArgs e)
        {
            //CALLS (BUZZER) THE SELECTED PERSON
        }

        private void Call_All_Button_Click(object sender, EventArgs e)
        {
            //CALLS (BUZZER) EVERYONE THAT IS CONNECTED
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            //STARTS SERIAL COMMUNICATION
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = Port_Box.Text;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += Myport_DataReceived;
            try{
                myport.Open();
                Name_List.Text = "";
            }
                catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erreur de connection!");
            }
        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            datetime = DateTime.Now;

            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;

            string in_data = myport.ReadLine();
            Details_List.Text = time + "/t/t/t/t/t" + in_data;
        }

        private void Disconnect_Button_Click(object sender, EventArgs e)
        {
            //DISCONNECTS THE SERIAL CONNECTION
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            //SAVES THE LOG INTO A FILE
        }

        private void Name_List_DoubleClick(object sender, EventArgs e)
        {
            //LOAD PERSON'S INFORMATION AND PICTURE
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
