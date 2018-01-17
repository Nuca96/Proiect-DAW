using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace Proiect_DAW.Users
{
    public partial class AddBookmark : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                conn.Open();


                string stringName = IdName.Text;
                Guid idBookmark = Guid.NewGuid();
                string nameCategory = IdCategory.SelectedValue;
                DateTime date = DateTime.Now;
                string user = Membership.GetUser().UserName;
                string description = IdDescription.Text;
                string photoPath = IdPhoto.FileName;
                string userId;
                string categoryId;

                string stringSelect = "SELECT UserId FROM Users WHERE UserName = @user;";
                SqlCommand sqlSelect1 = new SqlCommand(stringSelect, conn);
                sqlSelect1.Parameters.AddWithValue("@user", user);
                SqlDataReader sqlDataReader = sqlSelect1.ExecuteReader();
                sqlDataReader.Read();
                userId = sqlDataReader["UserId"].ToString();

                string stringSelect2 = "SELECT Id FROM Categories WHERE Name = @name;";
                SqlCommand sqlSelect2 = new SqlCommand(stringSelect2, conn);
                sqlSelect2.Parameters.AddWithValue("@name", nameCategory);
                SqlDataReader sqlDataReader2 = sqlSelect2.ExecuteReader();
                sqlDataReader2.Read();
                categoryId = sqlDataReader2["Id"].ToString();

                string stringInsert = "INSERT INTO Bookmarks VALUES (@Id, @Name, @Author, @Description, @PhotoPath, @CreateDate, @Category)";
                SqlCommand sqlInsert = new SqlCommand(stringInsert, conn);
                sqlInsert.Parameters.AddWithValue("@Id", idBookmark);
                sqlInsert.Parameters.AddWithValue("@Name", stringName);
                sqlInsert.Parameters.AddWithValue("@Category", categoryId);
                sqlInsert.Parameters.AddWithValue("@CreateDate", date);
                sqlInsert.Parameters.AddWithValue("@Author", userId);
                sqlInsert.Parameters.AddWithValue("@Description", description);
                sqlInsert.Parameters.AddWithValue("@PhotoPath", photoPath);
                int rows = sqlInsert.ExecuteNonQuery();
                if (1 == rows)
                {
                    message.Text = "Mulț'an' fain!";
                }
                else
                {
                    message.Text = "Și fași, ăi?";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                message.Text = ex.ToString();
            }
        }
    }
}