using BPOM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BPOM.Controllers;

namespace BPOM.Controllers
{
    public class pembelianController : Controller
    {

        DataClassesDataContext dc = new DataClassesDataContext();

        public ActionResult Index() 
        {
            return View();
        }

        // GET: pembelian
        public ActionResult HomePembelian()
        {
            var dataPembelian = from x in dc.pembelian_vaksins select x;
            return View(dataPembelian);
        }

        // GET: pembelian/DetailsPembelian/5
        public ActionResult DetailsPembelian(int id)
        {
            var getPembelianDetail = dc.pembelian_vaksins.Single(x => x.id_pembelian == id);
            return View(getPembelianDetail);
        }

        // GET: pembelian/CreatePembelian
        public ActionResult CreatePembelian()
        {
            return View();
        }

        // POST: pembelian/CreatePembelian
        [HttpPost]
        public ActionResult CreatePembelian(pembelian_vaksin collection)
        {
            try
            {
                dc.pembelian_vaksins.InsertOnSubmit(collection);
                dc.SubmitChanges();

                return RedirectToAction("HomePembelian");
            }
            catch
            {
                return View();
            }
        }

        // GET: pembelian/EditPembelian/5
        public ActionResult EditPembelian(int id)
        {
            var getPembelianDetail = dc.pembelian_vaksins.Single(x => x.id_pembelian == id);
            return View(getPembelianDetail);
        }

        // POST: pembelian/EditPembelian/5
        [HttpPost]
        public ActionResult EditPembelian(int id, pembelian_vaksin collection)
        {
            try
            {
                pembelian_vaksin update_pembelian = dc.pembelian_vaksins.Single(x => x.id_pembelian == id);
                update_pembelian.nama = collection.nama;
                update_pembelian.jumlah = collection.jumlah;
                update_pembelian.alamat = collection.alamat;
                dc.SubmitChanges();

                return RedirectToAction("HomePembelian");
            }
            catch
            {
                return View();
            }
        }

        // GET: pembelian/Delete/5
        public ActionResult DeletePembelian(int id)
        {
            var getPembelianDetail = dc.pembelian_vaksins.Single(x => x.id_pembelian == id);
            return View(getPembelianDetail);
        }

        // POST: pembelian/DeletePembelian/5
        [HttpPost]
        public ActionResult DeletePembelian(int id, FormCollection collection)
        {
            try
            {
                var deletePembelian = dc.pembelian_vaksins.Single(x => x.id_pembelian == id);
                dc.pembelian_vaksins.DeleteOnSubmit(deletePembelian);
                dc.SubmitChanges();

                return RedirectToAction("HomePembelian");
            }
            catch
            {
                return View();
            }
        }
    }
}
