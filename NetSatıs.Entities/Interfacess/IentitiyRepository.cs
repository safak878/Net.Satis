using NetSatıs.Entities.Context;
using NetSatıs.Entities.Interfacess;
using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Interfacess
{
   public interface IentitiyRepository<Tcontext, TEntitiy>
        where Tcontext:DbContext,new()
       where TEntitiy : class, IEntitiy, new()
    {
        bool AddDropUpdate(Tcontext context, TEntitiy entitiy);

        void Delete(Tcontext context, Expression<Func<TEntitiy, bool>> filter);
        void Save(Tcontext context);
    }
}
