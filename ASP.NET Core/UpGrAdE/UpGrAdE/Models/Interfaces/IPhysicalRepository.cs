using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models.Interfaces
{
    public interface IPhysicalRepository
    {
        PhysicalAbility GetPhysicalAbility(int id);

        List<PhysicalAbility> GetPhysicalAbilities();

        void Add(PhysicalAbility physicalAbility);
    }
}
