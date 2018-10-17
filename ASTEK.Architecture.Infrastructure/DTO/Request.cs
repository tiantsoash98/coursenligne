using System;
using ASTEK.Architecture.Infrastructure.Domain;

namespace ASTEK.Architecture.Infrastructure.DTO
{
    public class Request
    {
        public int Page { get; set; }
        public int Count { get; set; }
        public int Skip { get; set; }
        public SortDirection SortDirection { get; set; }
        public bool ShowAll { get; set; }
        public string[] SortCondition { get; set; }
        public string SortExpression { get; set; }
        public string Culture { get; set; }
    }
}
