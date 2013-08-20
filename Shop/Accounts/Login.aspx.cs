﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Accounts
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void cmdLogin_Click(object sender, EventArgs e)
		{
			if (txtLogin.Text == "" || txtPassword.Text == "")
				return;
			User usr = ConnectionClass.GetUser(txtLogin.Text, txtPassword.Text);
			if (usr != null)
			{
				Session["login"] = usr.Name;
				Session["type"] = usr.Type;
				Session["id"] = usr.Id;
				Response.Redirect("~/Default.aspx");
				lblError.Text = "";
			}
			else
			{
				lblError.Text = "Login failed";
			}
		}
	}
}