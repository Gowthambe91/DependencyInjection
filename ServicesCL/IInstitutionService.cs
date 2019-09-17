using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesCL;

namespace ServicesCL
{
    public interface IInstitutionService
    {
        IList<Institution> GetInstitutions();
    }
}
