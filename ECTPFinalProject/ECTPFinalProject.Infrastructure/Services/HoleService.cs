using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Data.Interfaces;
using ECTPFinalProject.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Infrastructure.Services
{
    public class HoleService : IHoleService
    {
        private readonly IHoleRepository _holeRepository;

        public HoleService(IHoleRepository holeRepository)
        {
            _holeRepository = holeRepository;
        }

        public List<Hole> GetBackNineHoles(int golfCourseId)
        {
            return _holeRepository.GetBackNineByGolfCourseId(golfCourseId);
        }

        public List<Hole> GetFrontNineHoles(int golfCourseId)
        {
            return _holeRepository.GetFrontNineByGolfCourseId(golfCourseId);
        }
    }
}
