using System.Collections.Generic;
using GymManager.Entities;

namespace GymManager.Repositories
{
    interface IVisitingRepository
    {
        IEnumerable<Visiting> SelectAllVisits();

        int InsertNewVisit(Visiting obj);

        IEnumerable<Visiting> GetVisitsByKeyNumber(Visiting obj);

        IEnumerable<Visiting> GetVisitsByDateVisit(Visiting obj);
    }

}
