using Language_Study_App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Domain.Entities.Common
{
    public class BaseEntitiy
    {
        public int Id { get; set; }
        public StateTypes StateType { get; set; }
        public string EnglishMean { get; set; }
        public string Sentece { get; set; }
        public string TurkishMean { get; set; }
    }
}
