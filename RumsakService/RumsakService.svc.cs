using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RumsakService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RumsakService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RumsakService.svc or RumsakService.svc.cs at the Solution Explorer and start debugging.
    public class RumsakService : IRumsakService
    {
        private RumsakEntities myEntities = new RumsakEntities();

        

        public bool AddLaporanRumsak(pembelian_rumsak dataPembelian)
        {
            if(dataPembelian != null)
            {
                myEntities.pembelian_rumsak.Add(dataPembelian);
                myEntities.SaveChanges();
                myEntities.Dispose();

                return true;
            }
            else
            {
                myEntities.Dispose();
                return false;
            }
        }

        public List<pembelian_rumsak> findAll()
        {
            return myEntities.pembelian_rumsak.ToList();
        }

        public List<pembelian_rumsak> findById(int id_pembelian_rumsak)
        {
            return myEntities.pembelian_rumsak.Where(p => p.id_pembelian_rumsak == id_pembelian_rumsak).ToList();
        }
    }
}
