using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Employeaspx : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);


    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    //.................Insert Data.................//
    protected void Insert_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string insertquery = "Exec SP_InsertEmployeinfo '" + EmployeName.Text + "','" + Employeage.Text + "','" + emailId.Text + "' , '" + password.Text + "','" + contactnumber.Text + "','" + Sallery.Text + "'";
            SqlCommand cmd = new SqlCommand(insertquery, con);
            cmd.ExecuteNonQuery();
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
    //.................Display Data.................//
    protected void Read_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string displayquery = "select * from SP_SelectEmployeinfo";
            SqlCommand cmd = new SqlCommand(displayquery, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind(); ;
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
    //.................Update Data.................//
    protected void Update_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string updatequery = "Exec SP_UpdateEmployeInfo '" + EmployeName.Text + "','" + Employeage.Text + "','" + emailId.Text + "','" + password.Text + "','" + contactnumber.Text + "','" + Sallery.Text + "'";
            SqlCommand cmd = new SqlCommand(updatequery, con);
            cmd.ExecuteNonQuery();
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
    //.................Delete Data.................//
    protected void Delete_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string deletequery = "Exec SP_DeleteEmployeinfo '" + emailId.Text + "' ";
            SqlCommand cmd = new SqlCommand(deletequery, con);
            cmd.ExecuteNonQuery();
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
}

    