using ECTPFinalProject.Infrastructure.Interfaces;

namespace ECTPFinalProject.Infrastructure.Services
{
    public class SampleService : ISampleService
    {
        private readonly ISampleService _sampleService;

        public SampleService(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }
    }
}