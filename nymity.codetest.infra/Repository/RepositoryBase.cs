using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nymity.codetest.infra.Repository
{
    public abstract class RepositoryBase<TEntity> where TEntity : class 
    {
        protected  TEntity Context { get; set; }

        public RepositoryBase(TEntity context)
        {
            Context = context;
        }
    }
}
