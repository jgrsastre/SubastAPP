using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLayer.Models
{
    public class E_MessageContentServer
    {
        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private Object _Data;

        public Object Data
        {
            get { return _Data; }
            set { _Data = value; }
        }
    }
}
