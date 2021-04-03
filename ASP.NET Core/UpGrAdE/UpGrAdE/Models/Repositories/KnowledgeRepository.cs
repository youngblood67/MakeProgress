using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpGrAdE.Models.Interfaces;

namespace UpGrAdE.Models.Repositories
{
    public class KnowledgeRepository : IKnowledgeRepository
    {
        private List<Knowledge> _knowledges;

        public KnowledgeRepository()
        {
            _knowledges = new List<Knowledge>();
        }

        public void Add(Knowledge knowledge)
        {
            _knowledges.Add(knowledge);
        }

        public Knowledge GetKnowledge(int id)
        {
            return _knowledges.FirstOrDefault(e => e.Id == id);
        }

        public List<Knowledge> GetKnowledges()
        {
            return _knowledges;
        }
    }
}
