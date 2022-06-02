using NetSatıs.Entities.Interfacess;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using FluentValidation;
using NetSatıs.Entities.Tools;
using System.Collections.Generic;

namespace NetSatıs.Entities.Rapositories
{
    public class EntitiyRapostoryBase<Tcontext, TEntitiy,TValidator> : IentitiyRepository<Tcontext, TEntitiy>
              where Tcontext : DbContext, new()
       where TEntitiy : class, IEntitiy, new()
       where TValidator:IValidator,new()
    {
        public List<TEntitiy> GetAll(Tcontext context, Expression<Func<TEntitiy, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntitiy>().ToList() : context.Set<TEntitiy>().Where(filter).ToList();
        }
        public TEntitiy GetByFilter(Tcontext context, Expression<Func<TEntitiy, bool>> filter)
        {
            return context.Set<TEntitiy>().SingleOrDefault(filter);
        }


        public bool AddDropUpdate(Tcontext context, TEntitiy entitiy)
    {
            TValidator validator = new TValidator();
            var validationResult = VolidatorTool.Validate(validator, entitiy);
            if (validationResult)
            {
                context.Set<TEntitiy>().AddOrUpdate(entitiy);
            }
            return validationResult;
        }

        public void Delete(Tcontext context, Expression<Func<TEntitiy, bool>> filter)
        {
            context.Set<TEntitiy>().RemoveRange(context.Set<TEntitiy>().Where(filter));
        }


        public void Save(Tcontext context)
        {

                context.SaveChanges();
           
        
        }

    
    }
}
