using System;

namespace RecursiveGeek.RegattaBoss.Models.Table
{
    public class Question
    {
        public Guid Id { get; set; }
        public string QuestionCode { get; set; }
        public InvItemType ItemType { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Modified => Updated ?? Created;
    }
}
