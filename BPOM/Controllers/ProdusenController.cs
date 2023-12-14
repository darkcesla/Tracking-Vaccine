using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using BPOM.Models;

namespace BPOM.Controllers
{
    public class ProdusenController : Controller
    {
        // GET: Produsen
        SqlConnection conn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: User

        DataClassesDataContext dc = new DataClassesDataContext();


        public ActionResult Home()
        {
            return View();
        }

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
        public ActionResult Verify(AkunBPOM akunUSER)
        {
            connectionString();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Select * from akun where username='" + akunUSER.username
                + "' and password='" + akunUSER.password + "' and role=3";

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
                + "','" + akunUSER.password + "',3)";

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

        // GET: pembelian/CreatePembelian
        public ActionResult CreateVaksin()
        {
            return View();
        }

        // POST: pembelian/CreatePembelian
        [HttpPost]
        public ActionResult CreateVaksin(daftar_vaksin collection)
        {
            try
            {
                dc.daftar_vaksins.InsertOnSubmit(collection);
                dc.SubmitChanges();

                return RedirectToAction("HomeVaksin");
            }
            catch
            {
                return View();
            }
        }

        // GET: pembelian/EditPembelian/5
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
                dc.SubmitChanges();

                return RedirectToAction("HomeVaksin");
            }
            catch
            {
                return View();
            }
        }

        // GET: pembelian/Delete/5
        public ActionResult DeleteVaksin(int id)
        {
            var getVaksinDetail = dc.daftar_vaksins.Single(x => x.id_vaksin == id);
            return View(getVaksinDetail);
        }

        // POST: pembelian/deleteVaksin/5
        [HttpPost]
        public ActionResult DeleteVaksin(int id, daftar_vaksin collection)
        {
            try
            {
                var deleteVaksin = dc.daftar_vaksins.Single(x => x.id_vaksin == id);
                dc.daftar_vaksins.DeleteOnSubmit(deleteVaksin);
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