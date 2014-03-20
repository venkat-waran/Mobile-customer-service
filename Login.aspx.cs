using System;
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
using System.Collections;
public partial class Default : System.Web.UI.Page
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
        if ((TextBox1.Text == "venkates30@gmail.com") && (TextBox2.Text == "venkatyuva"))
        {
            Response.Redirect("Admin.aspx");
        }
        else
        {
            try
            {
                Connection.Open();
                command = new OleDbCommand("Select [Password] from userlogin where Emailid ='" + this.TextBox1.Text + "' and Password='" + this.TextBox2.Text + "'", Connection);
                //command.Parameters.AddWithValue("emailid", TextBox1.Text); 
                OleDbDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    pswd = dr.GetValue(0).ToString();
                   // Label1.Text = pswd;
                   // Label1.Visible = true;
                }
                if (TextBox2.Text.Equals(pswd))
                {
                    Response.Write("Login successfull");
                    Session["emailid"] = TextBox1.Text;
                    //Response.Write(Session["emailid"]);
                    Response.Redirect("complaint.aspx");
                }
                else
                   // Response.Write(Label4.Text);
                    Label4.Visible = true;
                }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex + "\nresult:" + res);
            }



        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("newuser.aspx");
    }
   /* protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["emailid"] == TextBox1.Text)
        {
            Response.Redirect("complaint.aspx");
        }
        else
        {
            Label3.Visible = true;
            //Response.Redirect("Default.aspx");

        }
    }*/
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        try
        {
            /*if (TextBox1.Text.Equals(null))
            {
                //Response.Redirect("complaint.aspx");
                Label3.Visible = true;
            }
            else
            {

                Response.Redirect("complaint.aspx");

            }*/
            if (Session["emailid"] == TextBox1.Text)
            {
                Response.Redirect("complaint.aspx");
            }
            else
            {
                Label5.Visible = true;
                //Response.Redirect("Default.aspx");

            }

        }
        catch (Exception ee)
        {
            Response.Write("Error:" + ee + "\nresult:" + res);

            //Label3.Text = ee.ToString();
            //Label3.Visible = true;

            //}
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
       
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("newprod.aspx");
    }
}










