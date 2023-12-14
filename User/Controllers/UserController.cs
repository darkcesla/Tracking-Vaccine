using System.Data.SqlClient;
using System.Web.Mvc;
using User.Models;

namespace User.Controllers
{
    public class UserController : Controller
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: User

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DaftarForm()
        {
            return View();
        }

        void connectionString()
        {
            conn.ConnectionString = "data source=lumbanraja1807\\LUMBANRAJA; database=TrackingVaccine_05; integrated security = SSPI;";
        }

        [HttpPost]
        public ActionResult Verify(AkunUSER akunUSER)
        {
            connectionString();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Select * from akun where username='" + akunUSER.username
                + "' and password='" + akunUSER.password + "' and role=2";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return View("home");
            }
            else
            {
                conn.Close();
                return View("Login");

            }
        }

        [HttpPost]
        public ActionResult Register(AkunUSER akunUSER)
        {
            connectionString();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Insert into akun (username,PASSWORD,role) values ('" + akunUSER.username
                + "','" + akunUSER.password + "',2)";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return View("DaftarForm");
            }
            else
            {
                conn.Close();
                return View("Login");

            }
        }
    }
}