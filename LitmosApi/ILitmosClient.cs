using System.Collections.Generic;
using LitmosApi.Models;

namespace LitmosApi
{
    public interface ILitmosClient
    {
        List<User> GetUsers(string search = null, int limit= 100, bool showInactive = false);

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userIdOrUserName">Name of the user identifier or user name.</param>
        /// <returns>Users.</returns>
        User GetUser(string userIdOrUserName);
    }
}