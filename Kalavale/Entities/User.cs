namespace Kalavale.Entities {
    class User : EntityBase{
        public int ResearchAreaId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Key { get; set; }
        public int Status { get; set; }
    }
}
