using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Entities;
using WEB_API_CORE_DEMO.Model;

namespace WEB_API_CORE_DEMO.Repositories
{
    public class CourceRepositories : ICourceRepositories
    {
        RepositoriesContext context;
        public CourceRepositories(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddCource(Cource cour)
        {
            context.Cources.Add(cour);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteCource(int id)
        {
            var cour = context.Cources.Where(p => p.Id == id).SingleOrDefault();
            if (cour != null)
            {
                context.Cources.Remove(cour);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Cource> GetAllCources()
        {
            return context.Cources.ToList();
        }

        public int ModifyCource(Cource cour)
        {
            var Cource = context.Cources.Where(p => p.Id == cour.Id).SingleOrDefault();
            if (Cource != null)
            {
                Cource.Name = cour.Name;
                Cource.Fees = cour.Fees;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
