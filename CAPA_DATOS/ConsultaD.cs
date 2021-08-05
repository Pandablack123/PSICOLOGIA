﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class ConsultaD
    {
        string ID_Consulta;
        string ID_Cita;
        string Actividades;
        string Observaciones;
        string Tipo;

        public ConsultaD() { }

        public ConsultaD(string iD_Consulta, string iD_Cita, string actividades, string observaciones, string tipo)
        {
            ID_Consulta = iD_Consulta;
            ID_Cita = iD_Cita;
            Actividades = actividades;
            Observaciones = observaciones;
            Tipo = tipo;
        }

        public string ID_Consulta1 { get => ID_Consulta; set => ID_Consulta = value; }
        public string ID_Cita1 { get => ID_Cita; set => ID_Cita = value; }
        public string Actividades1 { get => Actividades; set => Actividades = value; }
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }


        public string insert(ConsultaD exp)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand New_C = new SqlCommand();
                New_C.Connection = Conectar;
                New_C.CommandText = "psci.Consulta";
                New_C.CommandType = CommandType.StoredProcedure;

                SqlParameter Consulta = new SqlParameter();
                Consulta.ParameterName = "@ID_Consulta";
                Consulta.SqlDbType = SqlDbType.Int;
               // Consulta.Size = 0;
                Consulta.Value = exp.ID_Consulta1;
                New_C.Parameters.Add(Consulta);

                SqlParameter Cita = new SqlParameter();
                Cita.ParameterName = "@ID_Cita";
                Cita.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                Cita.Value = exp.ID_Cita1;
                New_C.Parameters.Add(Cita);

                SqlParameter Actividades = new SqlParameter();
                Actividades.ParameterName = "@ID_Cita";
                Actividades.SqlDbType = SqlDbType.NVarChar;
                Actividades.Size = 50;
                Actividades.Value = exp.Actividades1;
                New_C.Parameters.Add(Actividades);

                SqlParameter Observacion = new SqlParameter();
                Observacion.ParameterName = "@Observaciones";
                Observacion.SqlDbType = SqlDbType.NVarChar;
                Observacion.Size = 3000;
                Observacion.Value = exp.Observaciones1;
                New_C.Parameters.Add(Observacion);

                SqlParameter Tipo = new SqlParameter();
                Tipo.ParameterName = "@Tipo";
                Tipo.SqlDbType = SqlDbType.NChar;
                Tipo.Size = 1;
                Tipo.Value = exp.Tipo1;
                New_C.Parameters.Add(Tipo);




                if (New_C.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }
            }
            catch (Exception e)
            {
                retorno = e.Message;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return retorno;


        }


        public string Update(ConsultaD exp)
        {
            return "";
        }













    }
}
