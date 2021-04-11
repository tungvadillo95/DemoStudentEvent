using DemoEventStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.RepositoryInterface
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Gets();
    }
}
