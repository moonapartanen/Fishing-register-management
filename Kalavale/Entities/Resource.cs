namespace Kalavale.Entities {
    class Resource : EntityBase {
        public string Name { get; set; }
        public int Type { get; set; }

        public override string ToString() {
            return Name;
        }
    }
}
