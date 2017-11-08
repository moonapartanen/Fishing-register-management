namespace Kalavale.Entities {
    class Field : EntityBase {
        public int QuestionId { get; set; }
        public int? RowResourceId { get; set; }
        public int? ColumnResourceId { get; set; }
    }
}
