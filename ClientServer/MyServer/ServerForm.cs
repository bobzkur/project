using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//required namespaces
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using MyThreadObject;
using CommLib;

namespace MyServer
{
    public partial class ServerForm : Form
    {
        //My channels
        private const int COM_PORT = 8080;
        private const int DAT_PORT = 8090;

        //My threads alive bools
        private bool bCommandListener = false;
        private bool bDataListener = false;

        //My Listeners Threads
        private Thread CommandThreadListener = null;
        private Thread DataThreadListener = null;

        //List of My connections
        Dictionary<string, ThreadObject> ListOfServerThreads =
            new Dictionary<string, ThreadObject>();

        //List of CommandDataObject 
      /*  Dictionary<string, DataObject>CommandsDataSet =
            new Dictionary<string, DataObject>();*/

        private Object __object = new Object();

        public ServerForm()
        {
            InitializeComponent();
            IPHostEntry IPHost =
                Dns.GetHostByName(Dns.GetHostName());
            this.Text = "TCP/IP - " +
                IPHost.AddressList[0].ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //=====START THE LISTENERS
            //Start The Command Listener
            CommandThreadListener = new
                  Thread( new ThreadStart(CommandListener) );
            bCommandListener = true;
            CommandThreadListener.Start();
            //Start the Data Listener
            DataThreadListener = new
                 Thread( new ThreadStart( DataListener) );
            bDataListener = true;
            DataThreadListener.Start();                 
        }
        
        private void CommandListener()
        {
            TcpListener tcpListener =
                    new TcpListener(IPAddress.Any, COM_PORT);
            tcpListener.Start();

            while( bCommandListener == true)
            {
                while( tcpListener.Pending() == false)
                {
                    if (bCommandListener == false)
                        break;
                }
                //This will stop th thread and exits
                if( bCommandListener == false)
                {
                    tcpListener.Stop();
                    break;
                }
                //You are here because a new connection
                Socket client = tcpListener.AcceptSocket();
                if( client.Connected == true)
                {
                    string ip = "COM_" +
                        (client.RemoteEndPoint as IPEndPoint).Address.ToString();
                    if (ListOfServerThreads.ContainsKey(ip) == true)
                        continue;
                    ThreadObject clientThread = new ThreadObject();
                    clientThread.client = client;
                    clientThread.ThreadDel =
                        new ThreadObject.ThreadDelegate(CommandProcessHandler);
                    clientThread.StartThread();
                    //Map the IP of the connection(key) 
                    //to the ThreadObject(value)
                    
                    ListOfServerThreads.Add(ip, clientThread);
                    UpdateConnectionsListBox(ip);
                }
            }
        }

        private void DataListener()
        {
            TcpListener tcpListener =
                    new TcpListener(IPAddress.Any, DAT_PORT);
            tcpListener.Start();

            while (bDataListener == true)
            {
                while (tcpListener.Pending() == false)
                {
                    if (bDataListener == false)
                        break;
                }
                //This will stop th thread and exits
                if (bDataListener == false)
                {
                    tcpListener.Stop();
                    break;
                }
                //You are here because a new connection
                Socket client = tcpListener.AcceptSocket();
                if (client.Connected == true)
                {
                    string ip = "DAT_" +
                        (client.RemoteEndPoint as IPEndPoint).Address.ToString();
                    if (ListOfServerThreads.ContainsKey(ip) == true)
                        continue;
                    ThreadObject clientThread = new ThreadObject();
                    clientThread.client = client;
                    clientThread.ThreadDel =
                        new ThreadObject.ThreadDelegate(DataProcessHandler);
                    clientThread.StartThread();
                    //Map the IP of the connection(key) 
                    //to the ThreadObject(value)

                    ListOfServerThreads.Add(ip, clientThread);
                    UpdateConnectionsListBox(ip);
                }
            }
        }
   

        private delegate void UpdateConnectionDel(string ip);
        private void UpdateConnectionsListBox( string ip )
        {
            if( this.InvokeRequired)
            {
                UpdateConnectionDel UpdateDel =
                    new UpdateConnectionDel(UpdateConnectionsListBox);
                this.Invoke(UpdateDel, new object[] { ip });
            }
            else
            {
                ListOfConnections.Items.Add(ip);
            }
        }

        //Thread for communicating the commands with the client
        private void CommandProcessHandler( Socket client)
        {
            try
            {
                Byte[] data = new Byte[1024];
                NetworkStream NetStream = new NetworkStream(client);
                //Read the command from the client
                int bytes = NetStream.Read(data, 0, 1024);
                string Command = Encoding.ASCII.GetString(data, 0, bytes);
                //Do something with the command
                //Lets get the UID from the command
                lock (__object)
                {
                    string UID =
                        CommandDataObject.Instance.DecodeUIDFromMessage(Command);
                   /* if (CommandsDataSet.ContainsKey(UID) == true)
                    {
                        //Get the CommandData Object
                       /* DataObject CDO = CommandsDataSet[UID] as DataObject;
                        //Initialize the Command Property of CDO
                        CDO.Command =
                            CommandDataObject.Instance.DecodeMessageFromUID(Command);
                        //Send it for Processing
                        ProcessServerFunctions(CDO, client);
                    }
                    else
                    {
                        //Create the CDO
                        DataObject CDO = new DataObject();
                        //Initialize the Command property
                        CDO.Command =
                            CommandDataObject.Instance.DecodeMessageFromUID(Command);
                        //Initialize the UID Property
                        CDO.UID = UID;
                        //Store the CDO for later processing
                        CommandsDataSet.Add(UID, CDO);
                    }*/
                }
                //Display the command in the command list box
                Command =
                    ((client.RemoteEndPoint) as IPEndPoint).Address.ToString() +
                    ">>>" + Command;
                UpdateCommandsListBox(Command);
            }
            catch( Exception ex)
            {
               client.Close();
               // ListOfServerThreads.Remove(ip);
            }
        }


        //Thread for communicating the commands with the client
        private void DataProcessHandler(Socket client)
        {
            try
            {
                Byte[] data = new Byte[1024];
                NetworkStream NetStream = new NetworkStream(client);
                //Read the dtaa from the client
                int bytes = NetStream.Read(data, 0, 1024);
                string 
                    Data= Encoding.ASCII.GetString(data, 0, bytes);
                //Do something with the command
                //Lets get the UID from the command
              /*  lock (__object)
                {
                    string UID =
                        CommandDataObject.Instance.DecodeUIDFromMessage(Data);
                    if (CommandsDataSet.ContainsKey(UID) == true)
                    {
                        //Get the CommandData Object
                        DataObject CDO = CommandsDataSet[UID] as DataObject;
                        //Initialize the Command Property of CDO
                        CDO.Data =
                            CommandDataObject.Instance.DecodeMessageFromUID(Data);
                        //Send it for Processing
                        ProcessServerFunctions(CDO, client);
                    }
                    else
                    {
                        //Create the CDO
                        DataObject CDO = new DataObject();
                        //Initialize the Command property
                        CDO.Data =
                            CommandDataObject.Instance.DecodeMessageFromUID(Data);
                        //Initialize the UID Property
                        CDO.UID = UID;
                        //Store the CDO for later processing
                        CommandsDataSet.Add(UID, CDO);
                    }
                }*/
                //Display the command in the command list box
                Data =
                    ((client.RemoteEndPoint) as IPEndPoint).Address.ToString() +
                    ">>>" + Data;
                UpdateDataListBox(Data);
            }
            catch (Exception ex)
            {
                client.Close();
                // ListOfServerThreads.Remove(ip);
            }
        }

     /*   private void ProcessServerFunctions(DataObject CDO, Socket client)
        {
            if (CDO.Command == "LOGIN")
                Login(CDO, client);

        }*/
     /*   private void Login(DataObject CDO, Socket client)
        {
            //do Auth
            //if CDO.Data == "012345"
            //Authenticated
        }*/
        private delegate void UpdateDataLBDel(string command);
        private void UpdateDataListBox(string command)
        {
            if (this.InvokeRequired)
            {
                UpdateDataLBDel UpdateDel =
                    new UpdateDataLBDel(UpdateDataListBox);
                this.Invoke(UpdateDel, new object[] { command });
            }
            else
            {
                ListOfData.Items.Add(command);
            }
        }   

        private delegate void UpdateCommandLBDel(string command);
        private void UpdateCommandsListBox( string command)
        {
            if( this.InvokeRequired)
            {
                UpdateCommandLBDel UpdateDel =
                    new UpdateCommandLBDel(UpdateCommandsListBox);
                this.Invoke(UpdateDel, new object[] { command });
            }
            else
            {
                ListOfCommands.Items.Add(command);
            }
        }

     
    }
}
