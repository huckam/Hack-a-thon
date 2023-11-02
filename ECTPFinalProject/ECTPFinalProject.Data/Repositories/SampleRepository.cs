using ECTPFinalProject.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Repositories
{
    public class SampleRepository : ISampleRepository
    {
        private readonly ISampleRepository _repository;

        public SampleRepository(ISampleRepository repository)
        {
            _repository = repository;
        }
    }
}
