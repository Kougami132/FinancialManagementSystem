using System;
using System.Collections.Generic;
using System.Text;

namespace FMSystem.Shared
{
    public class Response
    {
        public int Type { get; set; }
        public string Msg { get; set; }

        public Response()
        {
            
        }
        public Response(int type)
        {
            this.Type = type;
            if (type == 0)
            {
                this.Msg = "error";
            }
            else if (type == 1)
            {
                this.Msg = "Success";
            }
            else
            {
                this.Msg = "unknown";
            }
        }
        public Response(int type, string msg)
        {
            this.Type = type;
            this.Msg = msg;
        }
    }
}
