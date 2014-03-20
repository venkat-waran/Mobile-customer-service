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


public partial class Default4 : System.Web.UI.Page
{
    static int res;
    string pswd;
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
        ConnectToData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Connection.Open();
            String s = "";
            if ((TextBox4.Text == TextBox5.Text) && (TextBox1.Text != null) && (TextBox3.Text != null) && (TextBox4.Text != null))
            {
                if (TextBox2.Text != "")
                    //s = "insert into sam(IMEI,UserName,Contact,Complaint,EmailId,PhoneModel) values ('a','a','a','a','a','a')";
                    s = @"insert into userlogin values ( '" + TextBox1.Text + "' , '" + TextBox2.Text + "' , '" + TextBox3.Text + "' , '" + TextBox4.Text + "');";
                //s = "insert into login values (1,'venkat','bala','venkat','123')";
                else
                    s = @"insert into userlogin values ('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";

                //Response.Write(s);
                command = new OleDbCommand(s, Connection);
                //OleDbCommand command = new OleDbCommand(s, Connection);
                command.ExecuteNonQuery();
                //command.ExecuteReader();
            }
            else
                Response.Write("Field Empty !!");
        }
        catch (Exception ex)
        {
            Response.Write("Error:" + ex);
        }
        Session["emailid"] = TextBox3.Text;
        //Response.Write(Session["emailid"]);
      //  Response.Redirect("Default2.aspx");
           
        Response.Redirect("complaint.aspx");      
    }
}