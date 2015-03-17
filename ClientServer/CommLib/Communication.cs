using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommLib
{
    public class DataObject
    {
        public string Command = string.Empty;
        public string Data = string.Empty;
        public string UID = string.Empty;
    }
    public class CommandDataObject
    {
        private static CommandDataObject instance;

        public static CommandDataObject Instance
        {
            get
            {
                if( instance == null)
                {
                    instance = new CommandDataObject();
                }
                return instance;
            }
        }
        private string GetUID( )
        {
            DateTime beginOfCentury = new DateTime(2001, 1, 1);
            DateTime currentDate = DateTime.Now;

            long Ticks = currentDate.Ticks - beginOfCentury.Ticks;
            return Ticks.ToString();
        }

        public string FormatMessage( string message)
        {
            return GetUID() + ":" + message;
        }

        public string DecodeUIDFromMessage( string message)
        {
            return message.Substring(0, message.IndexOf(':'));
        }

        public string DecodeMessageFromUID( string message)
        {
            return message.Substring(message.IndexOf(':') + 1);
        }

        public string FormatMessageWithID( string Str1, string Str2)
        {
            //Extract the ID from the formatted command
            string ID = DecodeUIDFromMessage(Str1);
            //Format the Data with the extracted ID
            Str2 = ID + ":" + Str2;
            //Send the formatted Data back
            return Str2;
        }
    }
}
