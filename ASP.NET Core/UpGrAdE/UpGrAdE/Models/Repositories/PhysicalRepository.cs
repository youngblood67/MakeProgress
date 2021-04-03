using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpGrAdE.Models.Interfaces;

namespace UpGrAdE.Models.Repositories
{
    public class PhysicalRepository : IPhysicalRepository
    {
        private List<PhysicalAbility> _physicalAbilities;

        public PhysicalRepository()
        {
            _physicalAbilities = new List<PhysicalAbility>();
        }
        public void Add(PhysicalAbility physicalAbility)
        {
            _physicalAbilities.Add(physicalAbility);
        }

        public PhysicalAbility GetPhysicalAbility(int id)
        {
            return _physicalAbilities.FirstOrDefault(c => c.Id == id);
        }

        public List<PhysicalAbility> GetPhysicalAbilities()
        {
            return _physicalAbilities;
        }
    }
}
