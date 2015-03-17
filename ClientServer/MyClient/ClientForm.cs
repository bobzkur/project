using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using CommLib;

namespace MyClient
{
    public partial class ClientForm : Form
    {
        private TcpClient CommandConnection = null;
        private NetworkStream CommandStream = null;

        private TcpClient DataConnection = null;
        private NetworkStream DataStream = null;


        public ClientForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            //COMMAND CONNECTION
            //Open Connection to the command port
            CommandConnection = new TcpClient(
                  ServerIPAddress.Text,
                  Convert.ToInt32(PortNumber.Text));
            //Get the command stream 
            CommandStream = CommandConnection.GetStream();
            //Update connection status
            ConnectionStatus.Text = "Connected to 8080";

            //DATA CONNECTION
            //Open Connection to the Data port
            DataConnection = new TcpClient(
                  ServerIPAddress.Text,
                  Convert.ToInt32(DataPort.Text));
            //Get the data stream 
            DataStream = DataConnection.GetStream();
            //Update connection status
            ConnectionStatus.Text = "Connected to 8080/8090";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Byte[] data = new Byte[1024];
            Byte[] Command = new Byte[1024];
            string dataStr = "tonytohme:012345";
            string commandStr = "LOGIN";

            commandStr =
                CommandDataObject.Instance.FormatMessage(commandStr);
            dataStr =
                CommandDataObject.Instance.FormatMessageWithID(commandStr, dataStr);

            data = Encoding.ASCII.GetBytes(dataStr);
            Command = Encoding.ASCII.GetBytes(commandStr);
            CommandStream.Write(Command, 0, Command.GetLength(0));
            DataStream.Write(data, 0, data.GetLength(0));            
        }

        private void DataPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {

        }

        private void ConnectionStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PortNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerIPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte[] data = new Byte[1024];
            Byte[] Command = new Byte[1024];
            string dataStr = "BUTTON1";
            string commandStr = "PUSHED";

            commandStr =
                CommandDataObject.Instance.FormatMessage(commandStr);
            dataStr =
                CommandDataObject.Instance.FormatMessageWithID(commandStr, dataStr);

            data = Encoding.ASCII.GetBytes(dataStr);
            Command = Encoding.ASCII.GetBytes(commandStr);
            CommandStream.Write(Command, 0, Command.GetLength(0));
            DataStream.Write(data, 0, data.GetLength(0)); 
        }
    }
}

