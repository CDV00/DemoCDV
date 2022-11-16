using System;
using System.Collections.Generic;

namespace SER.Domain.Models
{
    public partial class Tepdinhkem
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public string? Type { get; set; }
        public string? FileName { get; set; }
        public string? OriginalName { get; set; }
        public string? Path { get; set; }
        public long? Size { get; set; }
        public int? GroupType { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
