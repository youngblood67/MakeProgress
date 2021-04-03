using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpGrAdE.Models.Interfaces;

namespace UpGrAdE.Models.Repositories
{
    public class CognitiveRepository : ICognitiveRepository
    {
        private List<CognitiveAbility> _cognitiveAbilities;

        public CognitiveRepository()
        {
            _cognitiveAbilities = new List<CognitiveAbility>();
        }

        public void Add(CognitiveAbility cognitiveAbility)
        {
            _cognitiveAbilities.Add(cognitiveAbility);
        }

        public List<CognitiveAbility> GetCognitiveAbilities()
        {
            return _cognitiveAbilities;
        }

        public CognitiveAbility GetCognitiveAbility(int id)
        {
            return _cognitiveAbilities.FirstOrDefault(e => e.Id == id);
        }
    }
}
