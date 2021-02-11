using DataObjects.Helpers.Models;
using RestSharp;

namespace DataObjects.Helpers.Api
{
    internal static class RequestHelper
    {
        public static IRestResponse CreateRequest(this RestClient client, string resource, UserEntity user)
        {
            var request = new RestRequest(resource, Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("authenticity_token", "4Fi//ysoi/MCY+nt9FMAT6DDN0Uus8MSHHqGNGN42kWvA4ed50e33I4HZTEAiD2ea9bz3WdGz0hqydSTH1yoOg==", ParameterType.GetOrPost);
            request.AddParameter("user[email]", user.Email, ParameterType.GetOrPost);
            request.AddParameter("user[password]", user.Password, ParameterType.GetOrPost);
            request.AddParameter("commit", "Sign+up", ParameterType.GetOrPost);

            return client.Execute(request);
        }
    }
}
