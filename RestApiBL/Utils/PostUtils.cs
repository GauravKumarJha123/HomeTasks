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
using RestApiBL.Models.Response;

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

        public static UpdatePutValidResponse UpdatePost(int id, String title, string author)
        {
            return RestClientUtil.Put<UpdatePutValidResponse>
                 (
                 "posts/"+id.ToString() , UpdatePostRequestBody(id, title, author)
                 );
        }

        public static UpdatePutValidResponse UpdatePostUsingPatch(String title)
        {
            return RestClientUtil.Patch<UpdatePutValidResponse>
                 (
                 "posts/2" , UpdatePatchRequestBody(title)
                 );
        }

        public static UpdatePutValidResponse GetPostUsingPatch(int id, String title, string author)
        {
            return RestClientUtil.Get<UpdatePutValidResponse>
                 (
                 "posts/" + id.ToString(), UpdatePostRequestBody(id,title,author)
                 );
        }

        private static string UpdatePatchRequestBody( string title)
        {
            UpdatePutValidResponse updatePostValidRequest = new UpdatePutValidResponse();
            updatePostValidRequest.title = title;

            return JsonConvert.SerializeObject(updatePostValidRequest);
        }

        private static string UpdatePostRequestBody(int id, string title, string author)
        {
            UpdatePutValidResponse updatePostValidRequest = new UpdatePutValidResponse();
            updatePostValidRequest.id = id;
            updatePostValidRequest.title = title;
            updatePostValidRequest.author = author;

            return JsonConvert.SerializeObject(updatePostValidRequest);
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

        // retrieve

       
    }
}
