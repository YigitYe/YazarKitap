using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBOpsLayeredArch.Entity
{
    internal class EKitap
    {
        public int kitapID { get; set; }
        public string kitapAdi { get; set; }
        public int  sayfaSayisi { get; set; }
        public int kategoriID { get; set; }
    }
}
