using Newtonsoft.Json;
using RestApiAutomationFramework.Utils;
using RestApiBL.Request;
using RestApiBL.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace RestApiBL.Utils
{
    public class PostUtils
    {

        //create 
        public static CreatePostValidResponse CreatPost(int id , String title , string author)
        {
           return RestClientUtil.Post<CreatePostValidResponse>
                (
                "posts", CreatePostRequestBody(id, title, author)
                );
        }
        public static string[] GetPostUtil(int id)
        {
            return RestClientUtil.GetPost("posts/" + id.ToString()); 
        }
        public static string CreatePostRequestBody(int id , string title , string author)
        {

            CreatePostValidRequest request = new CreatePostValidRequest();
            request.id = id;
            request.title = title;
            request.author = author;
            return JsonConvert.SerializeObject(request);
        }

        //delete

        public static bool DeletePost(int id)
        {
            return RestClientUtil.Delete("posts/" + id.ToString() ,HttpStatusCode.OK);
        }

    }
}
