using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Datastore.Entities
{
    public class UserInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string? Message { get; set; }
    }
}
