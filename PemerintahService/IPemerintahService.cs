using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PemerintahService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPemerintahService" in both code and config file together.
    [ServiceContract]
    public interface IPemerintahService
    {
        [OperationContract]
        List<akun_pasien> findAll();

        [OperationContract]
        List<akun_pasien> findById(int id_akun);

        [OperationContract]
        List<akun_pasien> findByNik(string nik);

        [OperationContract]
        List<akun_pasien> findByNama(string nama);
    }
}
