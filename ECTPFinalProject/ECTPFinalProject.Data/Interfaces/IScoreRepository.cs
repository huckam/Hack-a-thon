using ECTPFinalProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTPFinalProject.Data.Interfaces
{
    public interface IScoreRepository
    {
        void CreateScore(Score score);
        Score GetById(int id);
        Score GetByWeekNumberAndMemberId(int weekNumber, int memberId);
        bool UpdateScore(Score score);
        bool DeleteScore(int id);
    }
}
