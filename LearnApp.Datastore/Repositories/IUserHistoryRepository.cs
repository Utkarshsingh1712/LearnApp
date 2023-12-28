using LearnApp.Datastore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Datastore.Repositories
{
    public interface IUserHistoryRepository
    {
        void InsertUserInformation(UserInformation userInformation);
    }
}
