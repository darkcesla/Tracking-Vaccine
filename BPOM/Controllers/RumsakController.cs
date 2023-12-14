using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using BPOM.Models;
using BPOM.PemerintahService;
using BPOM.RumsakService;
using BPOM.VaccineService;

namespace BPOM.Controllers
{
    public class RumsakController : Controller
    {
        private PemerintahServiceClient psc = new PemerintahServiceClient();
        private RumsakServiceClient rsc = new RumsakServiceClient();
        private VaccineServiceClient vsc = new VaccineServiceClient();

        // GET: Rumsak
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
        public ActionResult Home()
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
        public ActionResult Verify(AkunBPOM akunUSER)
        {
            connectionString();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Select * from akun where username='" + akunUSER.username
                + "' and password='" + akunUSER.password + "' and role=4";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return View("Home");
            }
            else
            {
                conn.Close();
                return View("Login");

            }
        }

        [HttpPost]
        public ActionResult Register(AkunBPOM akunUSER)
        {
            connectionString();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Insert into akun (username,PASSWORD,role) values ('" + akunUSER.username
                + "','" + akunUSER.password + "',4)";

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

        public ActionResult CariPenduduk()
        {
            ViewBag.listPenduduk = psc.findAll();
            return View();
        }

        public ActionResult cari(FormCollection fc)
        {
            string condition = fc["condition"];
            string keyword = fc["keyword"];

            if (condition.Equals("byIdAkun"))
                ViewBag.listPenduduk = psc.findById(Convert.ToInt32(keyword));
            else if (condition.Equals("byNama"))
                ViewBag.listPenduduk = psc.findByNama(Convert.ToString(keyword));
            else if (condition.Equals("byNIK"))
                ViewBag.listPenduduk = psc.findByNik(Convert.ToString(keyword));
            else
                ViewBag.listPenduduk = "Maaf Penduduk tidak ditemukan";
            return View("CariPenduduk");
        }

        public ActionResult LaporVaksin()
        {
            ViewBag.listLaporan = rsc.findAll();
            return View();
        }

        public ActionResult TambahLaporan()
        {
            ViewBag.listIDVaksin = vsc.findAll();
            return View();
        }

        [HttpPost]
        public ActionResult TambahLaporan(int idPembelian, int vaksinId,string laporan)
        {
            ViewBag.listIDVaksin = vsc.findAll();

            PemerintahServiceClient psc = new PemerintahServiceClient();
            RumsakService.pembelian_rumsak data = new RumsakService.pembelian_rumsak
            {
                id_pembelian_rumsak = idPembelian,
                vaksin_id = vaksinId,
                laporan = laporan
            };
            return View();
        }

    }
}