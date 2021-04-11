using Dapper;
using DemoEventStudent.Models;
using DemoEventStudent.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.RepositoryImplement
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public async Task<IEnumerable<Book>> Gets()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@bookId", 1);
                var querySQL = "SELECT * FROM public.\"Books\" WHERE \"BookId\" = @bookId";
                return await SqlMapper.QueryAsync<Book>(cnn: connection,
                                                        sql: querySQL,
                                                        param: parameters,
                                                        commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
