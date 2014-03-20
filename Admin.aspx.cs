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
using System.Net.Mail;
using System.Net;

public partial class Default5 : System.Web.UI.Page
{
    int count = 0;
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
        if (count==0)
        {
            count++;
            try
            {
                ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;" + @"data source=C:\Users\venkatesh\Documents\Visual Studio 2008\WebSites\WebSite2\App_Data\Database2.mdb;";
                Connection = new OleDbConnection(ConnectionString);
                Connection.Open();

                String s = "SELECT [Emailid] FROM [Complaints]";
                command = new OleDbCommand(s, Connection);
                OleDbDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    this.DropDownList1.Items.Add(dr.GetString(0));

                }
            }
            catch (Exception ex)
            {
                
            }

               
        }

    }
       
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            /*
             * Connection.Open();
            String s = "Select Complaint,Emailid from complaints ";
            command = new OleDbCommand(s, Connection);
            */
            
        }
        catch (Exception ex)
        {
            Response.Write("Error:" + ex + "\nresult:");
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        try
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            //message.From = new MailAddress("chatroomcit@gmail.com");
            message.From = new MailAddress("chatroomcit@gmail.com", "Nokia custamercare", System.Text.Encoding.UTF8);
            message.To.Add(new MailAddress(this.DropDownList1.Text));
            message.Subject = "confirmation";
            message.Body = "Thank you for contacting us.\n We will respond to your query shortly.";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("chatroomcit@gmail.com", "formyproject123");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
        catch (Exception ex) 
        {
            this.Label3.Text = ex.ToString();
            
        }
           

    }
}
