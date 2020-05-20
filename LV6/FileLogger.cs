using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            //implementation missing!
            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(this.filePath, true))
            {
                streamWriter.WriteLine(type + ": " + message + "[" + DateTime.Now + "]");
            }

        }


    }
}
