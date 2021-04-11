using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.RepositoryImplement
{
    public class BaseRepository
    {
        protected IDbConnection connection;
        public BaseRepository()
        {
            connection = new NpgsqlConnection(@"Server = localhost; Port = 5432; User Id = postgres; Password = Vadillo40523; Database = DemoEventStudent;");
        }
    }
}
