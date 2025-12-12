using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuestions.Domain.Comments
{
    internal class Comment
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public Comment? Parent { get; set; }

        public required Guid EntityId { get; set; }  
        public List<Comment> Childrens { get; set; } = [];
    }
}
