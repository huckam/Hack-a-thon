using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Interfaces
{
    public interface IGolfCourseRepository
    {
        void CreateGolfCourse(GolfCourse golfCourse);
        GolfCourse GetById(int id);
        GolfCourse GetByName(string name);
        bool UpdateGolfCourse(GolfCourse golfCourse);
        bool DeleteGolfCourse(int id);
    }
}
