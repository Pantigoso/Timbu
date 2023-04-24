using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace BASE.Model
{
	class EmisionRepository
	{
        private SQLiteConnection con;

        private static EmisionRepository instancia;
        public static EmisionRepository Instancia
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
                instancia.con.Close();
            }
            instancia = new EmisionRepository(filename);
        }

        private EmisionRepository(String dbPath)
        {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<Emision>();
        }

        public string EstadoMensaje;

        public int AddNewEmision(DateTime fecha, float datoEmision, string factorEmision,float potencial, float huella)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Emision
                {
                    Fecha = fecha,
                    DatoEmision = datoEmision,
                    FactorEmision = factorEmision,
                    Potencial = potencial,
                    HuellaCarbono = huella
                });
                EstadoMensaje = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return result;
        }
        public IEnumerable<Emision> GetAllEmisions()
        {
            try
            {
                return con.Table<Emision>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Emision>();
        }
    }
}

