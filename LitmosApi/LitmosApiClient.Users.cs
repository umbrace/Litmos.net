using System;
using System.Collections.Generic;
using System.Text;
using LitmosApi.Models;
using RestSharp;

namespace LitmosApi
{
     public partial class LitmosApiClient
    {
        public Users GetUsers(string search = null)
        {
            var request = new RestRequest(Method.GET)
            {
                Resource = "users"
            };
            if (string.IsNullOrWhiteSpace(search) == false)
            {
                request.AddParameter("search", search, ParameterType.QueryString);
            }

            return Get<Users>(request);
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userIdOrUserName">Name of the user identifier or user name.</param>
        /// <returns>Users.</returns>
        public User GetUser(string userIdOrUserName)
        {
            if (string.IsNullOrWhiteSpace(userIdOrUserName))
            {
                throw new ArgumentOutOfRangeException(nameof(userIdOrUserName), "Argument can not be empty");
            }
            var request = new RestRequest(Method.GET)
            {
                Resource = "users/{userId}"
            };
            request.AddParameter("userId", userIdOrUserName);

            return Get<User>(request);
        }
    }
}
