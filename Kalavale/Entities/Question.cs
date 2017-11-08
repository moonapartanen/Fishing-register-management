using System.Collections.Generic;

namespace Kalavale.Entities {
    class Question : EntityBase {
        public int SurveyId { get; set; }
        public int Type { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public List<Field> Fields { get; set; }

        public override string ToString() {
            return string.Format("{0}. {1}...", Number, Title);
        }
    }
}
