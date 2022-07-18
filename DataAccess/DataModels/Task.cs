using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataModels
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsCompleted { get; set; }
        public int AssigneeID { get; set; }
        public virtual User Assignee { get; set; }
    }
}
