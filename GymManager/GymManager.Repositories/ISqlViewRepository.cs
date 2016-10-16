using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Entities;

namespace GymManager.Repositories
{
    interface ISqlViewRepository
    {
        List<View> SelectView();
    }
}
