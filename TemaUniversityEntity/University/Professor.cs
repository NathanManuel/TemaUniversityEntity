using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaUniversityEntity.UniversityProvider;

namespace TemaUniversityEntity.University
{
    class Professor : IUniversity
    {

        private readonly IUniversityProvider _contentProvider;

        public Professor(IUniversityProvider contentProvider)
        {
            _contentProvider = contentProvider;
        }
        public void Information()
        {
            IEnumerable<string> bookContent = _contentProvider.GetUniversityContent();
            Console.WriteLine("Succesfully uploaded professor information");
        }
    }
}
