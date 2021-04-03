using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models.Interfaces
{
    public interface IKnowledgeRepository
    {
        Knowledge GetKnowledge(int id);

        List<Knowledge> GetKnowledges();

        void Add(Knowledge knowledge);
    }
}
