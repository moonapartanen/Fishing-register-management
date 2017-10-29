using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalavale
{
    class Question
    {
        public int SurveyId { get; set; }
        public int Type { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public List<int> Columns { get; set; }
        public List<int> Rows { get; set; }


        public override string ToString()
        {
            //TODO: parempi lyhyt kuvaus kysymyksestä
            return string.Format("Kysymys {0}, Tyyppi {1}", Number, Type);
        }
    }
}
