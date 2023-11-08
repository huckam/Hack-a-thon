using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Interfaces
{
    public interface IHoleRepository
    {
        void CreateHole(Hole hole);
        Hole GetById(int id);
        Hole GetByHoleNumberAndCourseName(int holeNumber, string courseName);
        bool UpdateHole(Hole hole);
        bool DeleteHole(int id);
    }
}
