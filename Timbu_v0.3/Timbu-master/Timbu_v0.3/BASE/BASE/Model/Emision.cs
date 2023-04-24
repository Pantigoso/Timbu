using System;
using SQLite;

namespace BASE.Model
{
	[Table("emision")]
	class Emision
	{
        [PrimaryKey, AutoIncrement]
		public int id_Emision { get; set; }

        public DateTime Fecha { get; set; }

        [MaxLength(100)]
		public float DatoEmision { get; set; }

        [MaxLength(100)]
        public String FactorEmision { get; set; }

        [MaxLength(100)]
        public float Potencial { get; set; }

        [MaxLength(100)]
        public float HuellaCarbono { get; set; }

    }
}

