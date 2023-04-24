using System;
using SQLite;

namespace BASE.Model
{
	[Table("user")]
	class User
	{
		[PrimaryKey, Unique]
		public String CorreoElectronico { get; set; }

		[MaxLength(100)]
		public String Nombre { get; set; }

        [MaxLength(100)]
        public String Apellido { get; set; }

        [MaxLength(100)]
        public String Contrasenna { get; set; }

    }
}

