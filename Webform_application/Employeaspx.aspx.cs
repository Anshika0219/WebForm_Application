using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.Data;

public partial class Employeaspx : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-UQON0I1;Initial Catalog=company_Hr;Integrated Security=True");

 
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void Insert_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string insertquery = "Exec SP_InsertEmployeinfo '" + EmployeName.Text + "','" + Employeage.Text + "','" + emailId.Text + "' , '" + password.Text + "','" + contactnumber.Text + "','" + Sallery.Text + "'";
            SqlCommand insertcommand = new SqlCommand(insertquery, con);
            insertcommand.ExecuteNonQuery();
            Message.Text = "Your Data inserted successfully";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    protected void Read_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string displayquery = "select * from SP_SelectEmployeinfo";
            SqlCommand displayCommand = new SqlCommand(displayquery, con);
            SqlDataReader dataReader = displayCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("Employe Name : " + dataReader.GetValue(0).ToString());
                Console.WriteLine("Employe Age : " + dataReader.GetValue(1).ToString());
                Console.WriteLine("EmailId : " + dataReader.GetValue(2).ToString());
                Console.WriteLine("ContactNumber: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Sallery: " + dataReader.GetValue(4).ToString());
            }
            Message.Text = "your data display Successfully";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally {
            con.Close();
        }
      }
    protected void Update_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string updatequery = "Exec SP_UpdateEmployeInfo '" + EmployeName.Text + "','" + Employeage.Text + "','" + emailId.Text + "','" + password.Text + "','" + contactnumber.Text + "','" + Sallery.Text + "'";
            SqlCommand updatecommand = new SqlCommand(updatequery, con);
            updatecommand.ExecuteNonQuery();
            Message.Text = "your data updated Successfully";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    protected void Delete_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string deletequery = "Exec SP_DeleteEmployeinfo '" + emailId.Text + "' ";
            SqlCommand deletecommand = new SqlCommand(deletequery, con);
            deletecommand.ExecuteNonQuery();
            Message.Text = "your data deleted successfully";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }

    protected void Employeage_TextChanged(object sender, EventArgs e)
    {

    }
}