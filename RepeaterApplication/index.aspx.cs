using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepeaterApplication
{
    public partial class index : System.Web.UI.Page
    {

        //edit this
        public MySqlConnection con = new MySqlConnection("Server=localhost;Database=name;Uid=username;Pwd=password;Encrypt=false;AllowUserVariables=True;UseCompression=True;Charset=utf8");

        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlCommand kmt = new MySqlCommand("Select * from tablename", con);
            con.Open();
            kmt.ExecuteNonQuery();
            MySqlDataReader drem = kmt.ExecuteReader();
            rptAdi.DataSource = drem;
            rptAdi.DataBind();
            drem.Close();
            con.Close();
        }
    }
}