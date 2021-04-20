using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTalk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;
using Newtonsoft.Json;
using System.Net;

namespace BookTalk.Pages
{
    public class DemoModel : PageModel
    {

        [BindProperty]
        public List<UserModel> Users { get; set; } = new List<UserModel>();

        public void OnGet()
        {
            Users = GetUsers();
        }



        public IActionResult OnPostLogin(string user, string password)
        {
            // prepare your body
            var body = new
            {
                user = user,
                password = password
            };

            //convert body to json
            string json = JsonConvert.SerializeObject(body, Formatting.Indented);


            RestClient client = new RestClient("https://localhost:44362/UserPlayground/login");

            RestRequest request = new RestRequest 
            { 
                Method = Method.POST
            };

            request.Parameters.Clear();
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);


            if (response.StatusCode == HttpStatusCode.OK)
            {

                UserLoginSuccessModel message = JsonConvert.DeserializeObject<UserLoginSuccessModel>(response.Content);

                ViewData["message"] = $"{message.message} - Token: {message.token}";

            }
            else
            {
                UserLoginError message = JsonConvert.DeserializeObject<UserLoginError>(response.Content);

                ViewData["message"] = message.message;
            }


            return Page();
        }


        public List<UserModel> GetUsers()
        {

            // Set the url
            RestClient client = new RestClient("https://localhost:44362/UserPlayground/getusers");

            // Set the http method post,get,put,delete.etc
            RestRequest request = new RestRequest 
            { 
                Method = Method.GET
            };

            // optional clear parameters
            request.Parameters.Clear();

            // Execute the request
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Convert the request to an object from a json.
                List<UserModel> users = JsonConvert.DeserializeObject<List<UserModel>>(response.Content);
                // return the result
                return users;
            }
            else
            {
                return null;
            }

        }


        

    }
}
