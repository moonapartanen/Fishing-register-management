using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalavale.Entities {
    class ResearchAreaSurvey {
        public int SurveyId { get; set; }
        public int ResearchAreaId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
    }
}
