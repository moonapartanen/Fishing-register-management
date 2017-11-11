using System.Collections.Generic;

namespace Kalavale.Entities {
    public class Survey : EntityBase {
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public List<Question> Questions { get; set; }

        public override string ToString() {
            return string.Format("Nimi: {0}, Luotu: {1}", Name, CreationDate);
        }
    }
}
