using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace Proiect_DAW.Admin
{
    public partial class UserMgmt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                conn.Open();
                string catName = TextCategory.Text;
                string stringSelect = "SELECT * FROM Categories WHERE Name=@CatName";

                SqlCommand sqlSelect = new SqlCommand(stringSelect, conn);
                sqlSelect.Parameters.AddWithValue("@CatName", catName);
                SqlDataReader sqlDataReader = sqlSelect.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    message.Text = "Deja era!";
                }
                else
                {
                    string stringInsert = "INSERT INTO Categories VALUES (@Id, @Name);";
                    SqlCommand sqlInsert = new SqlCommand(stringInsert, conn);
                    sqlInsert.Parameters.AddWithValue("@Name", catName);
                    Guid catId = Guid.NewGuid();
                    sqlInsert.Parameters.AddWithValue("@Id", catId);

                    int rows = sqlInsert.ExecuteNonQuery();
                    if (1 == rows)
                    {
                        message.Text = "Categorii adaugatî!";
                    }
                    else
                    {
                        message.Text = "Și fași, ăi?";
                    }
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                message.Text = ex.ToString();
            }
        }

        protected void AddTag_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                conn.Open();
                string tagName = TextTag.Text;
                string stringSelect = "SELECT * FROM Tags WHERE Name=@TagName";

                SqlCommand sqlSelect = new SqlCommand(stringSelect, conn);
                sqlSelect.Parameters.AddWithValue("@TagName", tagName);
                SqlDataReader sqlDataReader = sqlSelect.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    message.Text = "Deja era!";
                }
                else
                {
                    string stringInsert = "INSERT INTO Tags VALUES (@Id, @Name);";
                    SqlCommand sqlInsert = new SqlCommand(stringInsert, conn);
                    sqlInsert.Parameters.AddWithValue("@Name", tagName);
                    Guid tagId = Guid.NewGuid();
                    sqlInsert.Parameters.AddWithValue("@Id", tagId);

                    int rows = sqlInsert.ExecuteNonQuery();
                    if (1 == rows)
                    {
                        message.Text = "Etichetî adaugatî!";
                    }
                    else
                    {
                        message.Text = "Și fași, ăi?";
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                message.Text = ex.ToString();
            }
        }
        
    }
}