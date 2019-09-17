using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesCL;

namespace ServicesCL
{
    public class InstitutionService : IInstitutionService
    {
        public IList<Institution> GetInstitutions()
        {
            return new List<Institution>() {
                new Institution { InstitutionId =1, Address = "Chennai", Name="Anna University", Telephone="#00000"},
                new Institution { InstitutionId =2, Address = "Coimbatore", Name="Bharathiar University", Telephone="#11111"},
                new Institution { InstitutionId =3, Address = "Trichy", Name="Alagappa", Telephone="#22222"}
            };
        }
    }
}
