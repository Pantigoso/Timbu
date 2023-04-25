using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace BASE.Model
{
	class UserRepository
	{
		private SQLiteConnection conn;

		private static UserRepository instancia;
		public static UserRepository Instancia
		{
            get
			{
				if (instancia == null)
					throw new Exception("Debe llamar al inicializador, acción detenida");
				return instancia;
			}
        }

		public static void Inicializador(String filename)
		{
            if (filename == null)
			{
				throw new ArgumentException();
			}
            if (instancia != null)
			{
				instancia.conn.Close();
			}
            instancia = new UserRepository(filename);
        }

        private UserRepository(String dbPath)
		{
			conn = new SQLiteConnection(dbPath);
			conn.CreateTable<User>();
		}

        public string EstadoMensaje;

        public int AddNewUser(string correoElectronico, string nombre, string apellido, string contrasenna)
		{ int result = 0;
			try
			{
				result = conn.Insert(new User {
					CorreoElectronico = correoElectronico,
					Nombre = nombre,
					Apellido = apellido,
					Contrasenna = contrasenna
				});
				EstadoMensaje = string.Format("Cantidad filas : {0}", result);
			}
			catch (Exception e)
			{
				EstadoMensaje = e.Message;
			}
			return result;
		}
        public IEnumerable<User> GetAllUsers()
		{
			try
			{
				return conn.Table<User>();
			}
			catch (Exception e)
			{
				EstadoMensaje = e.Message;
			}
			return Enumerable.Empty<User>();
		}
    }
}

