using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class E_MessageContent
    {
		private string _Type;

		public string tipoMensaje
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
