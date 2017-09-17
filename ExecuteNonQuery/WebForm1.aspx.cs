using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ExecuteNonQuery
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=product;Integrated Security=true"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into tblProduct values(4,'router',5000,10)";
                cmd.Connection = con;
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                Response.Write("the number of rows updated is " + rows);


            }
        }
    }
}