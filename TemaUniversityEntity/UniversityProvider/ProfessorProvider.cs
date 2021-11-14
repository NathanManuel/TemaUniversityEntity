using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaUniversityEntity.UniversityProvider
{
    class ProfessorProvider : IUniversityProvider
    {
        IEnumerable<string> IUniversityProvider.GetUniversityContent()
        {
            return new List<string>()
            {
         "Name: Professor 1",
         "Age: 35"
            };
        }
    }
}
