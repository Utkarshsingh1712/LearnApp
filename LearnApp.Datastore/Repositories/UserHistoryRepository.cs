using LearnApp.Datastore.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Datastore.Repositories
{
    public class UserHistoryRepository: IUserHistoryRepository
    {
        private readonly ILogger<UserHistoryRepository> _logger;
        private readonly DataStoreContext _storeContext;
        public UserHistoryRepository(ILogger<UserHistoryRepository> logger,DataStoreContext storeContext) 
        { 
            _logger = logger;
            _storeContext = storeContext;
        }
       public void InsertUserInformation(UserInformation userInformation)
        {
            _storeContext.UserInformations.Add(userInformation);
            _storeContext.SaveChanges();
        }
    }
}
