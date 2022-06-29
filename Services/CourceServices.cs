using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Model;
using WEB_API_CORE_DEMO.Repositories;

namespace WEB_API_CORE_DEMO.Services
{
    public class CourceServices: ICourceServices
    {
        private readonly ICourceRepositories _iCourceRepo;
        // Injecition of Dependancy using constructor
        public CourceServices(ICourceRepositories iCourceRepo)
        {
            _iCourceRepo = iCourceRepo;
        }
        public int AddCource(Cource cour)
        {
            return _iCourceRepo.AddCource(cour);
        }
        public int DeleteCource(int id)
        {
            return _iCourceRepo.DeleteCource(id);
        }
        public IEnumerable<Cource> GetAllCources()
        {
            return _iCourceRepo.GetAllCources();
        }
        public int ModifyCource(Cource cour)
        {
            return _iCourceRepo.ModifyCource(cour);
        }

    }
}
