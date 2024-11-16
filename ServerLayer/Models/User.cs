using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLayer.Models
{
    public class User
    {
		private int user_id;

		public int User_Id
		{
			get { return user_id; }
			set { user_id = value; }
		}

		private string full_name;

		public string Full_Name
		{
			get { return full_name; }
			set { full_name = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		private DateTime date_register;

		public DateTime Date_Register
		{
			get { return date_register; }
			set { date_register = value; }
		}

		private int rol_id;

		public int Rol_Id
		{
			get { return rol_id; }
			set { rol_id = value; }
		}
    }
}
