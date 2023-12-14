using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PemerintahService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PemerintahService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PemerintahService.svc or PemerintahService.svc.cs at the Solution Explorer and start debugging.
    public class PemerintahService : IPemerintahService
    {
        private PemerintahEntities myEntities = new PemerintahEntities();

        public List<akun_pasien> findAll()
        {
            return myEntities.akun_pasien.ToList();
        }

        public List<akun_pasien> findById(int id_akun)
        {
            return myEntities.akun_pasien.Where(p => p.id_akun == id_akun).ToList();
        }

        public List<akun_pasien> findByNama(string nama)
        {
            return myEntities.akun_pasien.Where(p => p.nama == nama).ToList();
        }

        public List<akun_pasien> findByNik(string nik)
        {
            return myEntities.akun_pasien.Where(p => p.nik == nik).ToList();
        }
    }
}
