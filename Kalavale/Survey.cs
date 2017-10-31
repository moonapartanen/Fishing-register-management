using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalavale {
    class Survey {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
        public string CreationDate { get; set; }

        public override string ToString() {
            return string.Format("{0}, {1}, {2} kysymystä", Name, CreationDate, Questions.Count);
        }
    }
}
