using UpGrAdE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.ViewModels
{
    public class ShowKnowledgeViewModel
    {
        public string PageTitle { get; set; }

        public List<Knowledge> Knowledges { get; set; } = new List<Knowledge>();

    }
}
