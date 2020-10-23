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
        private string in_data;
        bool isconnected = false;
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
                MessageBox.Show("Le port est maintenant ouvert!");
                Name_List.Text = "";
                isconnected = true;
            }

                catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erreur de connection!");
                isconnected = false;
            }

        }

        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {            
            in_data = myport.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            Name_List.Items.Add(time + "           " + in_data);
        }

        private void Disconnect_Button_Click(object sender, EventArgs e)
        {
            //DISCONNECTS THE SERIAL CONNECTION
            try
            {
                myport.Close();
                MessageBox.Show("Le port est maintenant Fermé!");
                isconnected = false;
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            //SAVES THE LOG INTO A FILE
            try
            {
                string pathfile = @"C:\Users\FiloucoolGaming\Desktop";
                string filename = "Log_data.txt";
                System.IO.File.WriteAllText(pathfile + filename, Name_List.Text);
                MessageBox.Show("Les données ont été sauvergardées dans le dossier suivant:" + pathfile);
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "Error");
            }
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
