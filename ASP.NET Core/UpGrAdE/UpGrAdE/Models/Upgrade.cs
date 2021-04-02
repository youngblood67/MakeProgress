using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models
{
    public abstract class Upgrade
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string FeedBack { get; set; }


        public Upgrade()
        {
            this.Title ="";
            this.FeedBack = "";

        }
        public Upgrade(string title, string feedback)
        {
            this.Title = title;
            this.FeedBack = feedback;

        }
        public Upgrade(int id, string title, string feedback)
        {
            this.Id = id;
            this.Title = title;
            this.FeedBack = feedback;

        }

    }
}
