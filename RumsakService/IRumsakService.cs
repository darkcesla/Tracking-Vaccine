using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RumsakService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRumsakService" in both code and config file together.
    [ServiceContract]
    public interface IRumsakService
    {
        [OperationContract]
        List<pembelian_rumsak> findAll();

        [OperationContract]
        List<pembelian_rumsak> findById(int id_pembelian_rumsak);

        [OperationContract]
        bool AddLaporanRumsak(pembelian_rumsak dataPembelian);

    }
}
