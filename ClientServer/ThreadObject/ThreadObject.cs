using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace MyThreadObject
{
    public class ThreadObject
    {
        private bool Alive = false;
        private Thread myThread = null;
        public int ThreadTimeout = 100;
        public Socket client = null;

        public delegate void ThreadDelegate(Socket client);
        public ThreadDelegate ThreadDel = null;

        public ThreadObject()
        {
            myThread = new Thread(new ThreadStart(ThreadFunction));
        }

        private void ThreadFunction()
        { 
            while( Alive)
            {
                Thread.Sleep(ThreadTimeout);
                ThreadDel(client);
            }
        }
        public void StartThread()
        {
            Alive = true;
            myThread.Start();
        }
        public void StopThread()
        {
            Alive = false;
        }
    }
}
