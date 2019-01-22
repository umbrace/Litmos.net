using LitmosApi.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LitmosApi
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public partial class LitmosClient : ILitmosClient
    {
        /// <summary>
        /// Returns all users with a matching username, first name, last name, email address, or company name.
        /// AccessLevel: Administrators Only
        /// </summary>
        /// <param name="search">Username, First/Last Name, Email, or Company Name.</param>
        /// <param name="limit">Limit the number of results</param>
        /// <param name="showInactive"></param>
        /// <returns>List&lt;User&gt;.</returns>
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public List<User> GetUsers(string search = null, int limit = 100, bool showInactive = false)
        {
            var request = new RestRequest(Method.GET)
            {
                Resource = "users"
            };
            if (string.IsNullOrWhiteSpace(search) == false)
            {
                request.AddParameter("search", search, ParameterType.QueryString);
            }

            if (limit < 100)
            {
                request.AddParameter("limit", limit, ParameterType.QueryString);
            }

            if (showInactive == true)
            {
                request.AddParameter("showInactive", showInactive.ToString().ToLower(), ParameterType.QueryString);
            }

            return Get<List<User>>(request);
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userIdOrUserName">Name of the user identifier or user name.</param>
        /// <returns>Users.</returns>
        public User GetUser(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "Argument can not be empty");
            }
            var request = new RestRequest(Method.GET)
            {
                Resource = "users/{userId}"
            };
            request.AddParameter("userId", userId, ParameterType.UrlSegment);

            return Get<User>(request);
        }
    }
}
