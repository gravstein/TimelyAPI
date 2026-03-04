using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces.DataSourse
{
    public interface IGuitarDataSource : IGenericDataSourse<Guitar>
    {
        Task<Guitar?> GetGuitarWithDetails(Expression<Func<Guitar, bool>> filter);
    }
}
