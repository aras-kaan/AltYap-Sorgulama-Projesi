using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltyapiSorgulama
{
        public class Il
        {
            public int Id { get; set; }
            public string Ad { get; set; }
        }

        public class Ilce
        {
            public int Id { get; set; }
            public int IlId { get; set; }
            public string Ad { get; set; }
        }

        public class Mahalle
        {
            public int Id { get; set; }
            public int IlceId { get; set; }
            public string Ad { get; set; }
        }

        public class Sokak
        {
            public int Id { get; set; }
            public int MahalleId { get; set; }
            public string Ad { get; set; }
        }

        public class ApartmanNo
        {
            public int Id { get; set; }
            public int SokakId { get; set; }
            public string No { get; set; }
            public List<string> AltYapi { get; set; } = new List<string>();
        }
    }
    internal class Siniflar1
    {

    }

