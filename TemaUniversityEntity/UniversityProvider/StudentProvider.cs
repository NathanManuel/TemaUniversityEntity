using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaUniversityEntity.UniversityProvider
{
    class StudentProvider : IUniversityProvider
    {
        IEnumerable<string> IUniversityProvider.GetUniversityContent()
        {
            return new List<string>()
            {
         "Name: Student 1",
         "Year: 5"
            };
        }
    }
}
