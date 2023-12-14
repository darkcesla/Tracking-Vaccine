using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VaccineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VaccineService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VaccineService.svc or VaccineService.svc.cs at the Solution Explorer and start debugging.
    public class VaccineService : IVaccineService
    {
        private VaccineEntities myEntities = new VaccineEntities();

        public List<daftar_vaksin> findAll()
        {
            return myEntities.daftar_vaksin.ToList();
        }
    }
}
