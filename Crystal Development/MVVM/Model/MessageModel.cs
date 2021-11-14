using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal_Development.MVVM.Model
{
    internal class MessageModel
    {
        private string v1;
        private string v2;
        private string v3;

        public MessageModel(string v1, string v2, string v3, string v, DateTime dateTime)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public MessageModel(string v1, string v2, string v3, string v, DateTime dateTime, bool v4) : this(v1, v2, v3, v, dateTime)
        {
        }

        public MessageModel(string v1, string v2, string v3, string v, DateTime dateTime, bool v4, bool v5) : this(v1, v2, v3, v, dateTime)
        {
            V4 = v4;
            V5 = v5;
        }

        public string Username { get; set; }
        public string UsernameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? FirstMessage { get; set; }
        public bool V4 { get; }
        public bool V5 { get; }
    }
}
