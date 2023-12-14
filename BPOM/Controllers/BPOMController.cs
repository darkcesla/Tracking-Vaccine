using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using BPOM.Models;


namespace BPOM.Controllers
{
    public class BPOMController : Controller
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;


        DataClassesDataContext dc = new DataClassesDataContext();

        public ActionResult Home()
        {
            return View();
        }

        // GET: BPOM
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString() {
            conn.ConnectionString = "data source=lumbanraja1807\\LUMBANRAJA; database=TrackingVaccine_05; integrated security = SSPI;";
        }

        [HttpPost]
        public ActionResult Verify(AkunBPOM akunBPOM) {
            connectionString();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Select * from akun where username='"+akunBPOM.username
                +"' and password='"+akunBPOM.password+"' and role=1";



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

        public ActionResult HomeVaksin()
        {
            var dataVaksin = from x in dc.daftar_vaksins select x;
            return View(dataVaksin);
        }

        public ActionResult DetailsVaksin(int id)
        {
            var getVaksinDetail = dc.daftar_vaksins.Single(x => x.id_vaksin == id);
            return View(getVaksinDetail);
        }

        public ActionResult EditVaksin(int id)
        {
            var getVaksinDetail = dc.daftar_vaksins.Single(x => x.id_vaksin == id);
            return View(getVaksinDetail);
        }

        // POST: pembelian/EditPembelian/5
        [HttpPost]
        public ActionResult EditVaksin(int id, daftar_vaksin collection)
        {
            try
            {
                daftar_vaksin update_vaksin = dc.daftar_vaksins.Single(x => x.id_vaksin == id);
                update_vaksin.id_registrasi = collection.id_registrasi;
                update_vaksin.nama_vaksin = collection.nama_vaksin;
                update_vaksin.jenis_vaksin = collection.jenis_vaksin;
                update_vaksin.jumlah = collection.jumlah;
                update_vaksin.status_vaksin = collection.status_vaksin;
                dc.SubmitChanges();

                return RedirectToAction("HomeVaksin");
            }
            catch
            {
                return View();
            }
        }

    }
}