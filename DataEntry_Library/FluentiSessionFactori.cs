using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Configuracion;
using DataEntry_Library.Mapping;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using MySql.Data.MySqlClient;
using NHibernate.Cfg;
using System.IO;
using System.Data.SQLite;

using FluentNHibernate.Data;

namespace DataEntry_Library
{
    public class FluentiSessionFactori
    {
        private static string DbFile = @"D:\firstProgram.db";

        private static string Cadena = cPublica.ArchivosGlovales.cadena;

        private static ISessionFactory _sessionFactory;


        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactoryMsSql();
                return _sessionFactory;
            }
        }

        /// <summary>
        /// inicializacion de conexion para Ms Sql
        /// </summary>
        public static void InitializeSessionFactoryMsSql()
        {
            if (cPublica.ArchivosGlovales.valorInicial == "0")
                _sessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(Cadena).ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapping.CargoMap>()).ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true)).BuildSessionFactory();
            else
                _sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(Cadena).ShowSql()).Mappings(C => C.FluentMappings.AddFromAssemblyOf<Mapping.CargoMap>()).BuildSessionFactory();

        }

        /// <summary>
        /// inicializacion de conexion para Mysql
        /// </summary>
        public static void InitializeSessionFactoryMysql()
        {
            if (cPublica.ArchivosGlovales.valorInicial == "0")
                _sessionFactory = Fluently.Configure()
                    .Database(MySQLConfiguration.Standard.ConnectionString(Cadena).ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapping.CargoMap>())
                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                    .BuildSessionFactory();
            else
                _sessionFactory = Fluently.Configure()
                    .Database(MySQLConfiguration.Standard.ConnectionString(Cadena).ShowSql())
                    .Mappings(C => C.FluentMappings.AddFromAssemblyOf<Mapping.CargoMap>())
                    .BuildSessionFactory();

        }

        public static void InitializeSessionFactorySqLite()
        {
            _sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                    .UsingFile(DbFile))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapping.CargoMap>())
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
 

        }

        private static void BuildSchema( Configuration config)
        {
            // delete the existing db on each run
            if (File.Exists(DbFile))
                File.Delete(DbFile);

            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(config)
                .Create(false, true);
        }



        /// <summary>
        /// abriendo la sesion
        /// </summary>
        /// <returns></returns>
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
