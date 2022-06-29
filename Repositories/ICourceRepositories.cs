using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Model;

namespace WEB_API_CORE_DEMO.Repositories
{
     public interface ICourceRepositories
    {
        IEnumerable<Cource> GetAllCources();
        int AddCource(Cource cour);
        int ModifyCource(Cource cour);
        int DeleteCource(int id);
    }
}
