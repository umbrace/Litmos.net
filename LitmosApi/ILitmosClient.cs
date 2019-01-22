using System.Collections.Generic;
using LitmosApi.Models;

namespace LitmosApi
{
    public interface ILitmosClient
    {
        List<User> GetUsers(string search = null);

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userIdOrUserName">Name of the user identifier or user name.</param>
        /// <returns>Users.</returns>
        User GetUser(string userIdOrUserName);
    }
}