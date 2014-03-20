using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class Default2 : System.Web.UI.Page
{
    String a,b;
     OleDbConnection Connection;
        String ConnectionString;
        OleDbCommand command;

    
        public void ConnectToData()
        {
            try
            {
                ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;" + @"data source=C:\Users\venkatesh\Documents\Visual Studio 2008\WebSites\WebSite2\App_Data\Database2.mdb;";
                Connection = new OleDbConnection(ConnectionString);

            }
            catch (Exception e)
            {
                Response.Write("Error:" + e);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emailid"] != null)
            {
                //TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
                b = Session["emailid"].ToString();
               //Response.Write(b);
                Label5.Visible = true;
            }
            else
            {
                Response.Write("NULLL");
            }
            ConnectToData();

        }
      /*if (Session["emailid"] != null)
            {
                b = Session["emailid"].ToString();
              // Response.Write(Session["emailid"]);
            }
            else
            {
                Response.Write("NULLL");
            }*/


    protected void Button1_Click(object sender, EventArgs e)
    {

       /* if (Session["Emailid"] != null)
        {
            a = Session["Emailid"].ToString();
          Response.Write(a);
        }
        
        else
        {
            Response.Redirect("Default.aspx");
        }*/
        try
        {
            Connection.Open();
           // String s = "";

            //String s = "insert into Complaints values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + Session["emailid"] + "' );";
            String s = "insert into Complaints values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "','" + TextBox4.Text + "','" + b + "' );";
            
            //String s = "insert into login(First_name,Last_name,Emailid,Password) values ('a','a','a','a')";
           // Response.Write(s);

            //Response.Write(" lol "+TextBox1.Text +" "+ TextBox2.Text +" "+ TextBox3.Text +" "+ TextBox4.Text);
            TextBox1.Text = TextBox2.Text = DropDownList1.SelectedValue = TextBox4.Text = "";
                command = new OleDbCommand(s, Connection);
                //OleDbCommand command = new OleDbCommand(s, Connection);
                command.ExecuteNonQuery();
                Response.Redirect("Login.aspx");
            
        }
        catch (Exception ex)
        {
            Response.Write("Error:" + ex);
        }
        
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        //Regex rex = new Regex();
        /*Match rex = Regex.Match(TextBox1.Text, @"\d");
        if (!rex.Success)
        {
            Label5.ToolTip = "IMEI can only be number.."; 
        }*/

    }
    protected void logout_Click(object sender, EventArgs e)
    {
       // Session["Emailid"] = "";
        //Response.Write("send");
        Response.Redirect("Login.aspx");
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
