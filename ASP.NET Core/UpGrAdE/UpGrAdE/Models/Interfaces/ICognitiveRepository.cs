using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models.Interfaces
{
    public interface ICognitiveRepository
    {
        CognitiveAbility GetCognitiveAbility(int id);

        List<CognitiveAbility> GetCognitiveAbilities();

        void Add(CognitiveAbility cognitiveAbility);
    }
}
