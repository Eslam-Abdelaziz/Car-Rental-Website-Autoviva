using AdminPanel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Extenstions
{
	public static class HttpClientExtenstions
    {
        public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client,string url,T obj) 
        {
            string payload = JsonConvert.SerializeObject(obj);
            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            // Post to the endpoint
            return  await client.PostAsync(url, content);
        }

        public static async Task<(bool , string)> PostAsyncEx<T>(this HttpClient client, string url, T obj)
        {
            try
            {
                string payload = JsonConvert.SerializeObject(obj);
                var content = new StringContent(payload, Encoding.UTF8, "application/json");
                // Post to the endpoint
                var res = await client.PostAsync(url, content);
                if (res.IsSuccessStatusCode)
                {
                    return (true, "");
                }
                else
                {
                    return (false, "Server Side Error");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);

            }

        }



		public static async Task<T> PostJsonAsync<T>(this HttpClient client, string url,Object obj)
		{
			try
			{
				string payload = JsonConvert.SerializeObject(obj);
				var content = new StringContent(payload, Encoding.UTF8, "application/json");

				var res = await client.PostAsync(url, content);

#if DEBUG
                var resStr = await res.Content.ReadAsStringAsync();
#endif  
                if (res.IsSuccessStatusCode)
				{
					return JsonConvert.DeserializeObject<T>(await res.Content.ReadAsStringAsync());
				}
			}
			catch
			{

			}

			return default(T);
		}
		public static async Task<(bool, string)> PutAsync<T>(this HttpClient client, string url, T obj)
        {
            try
            {
                string payload = JsonConvert.SerializeObject(obj);
                var content = new StringContent(payload, Encoding.UTF8, "application/json");
                // Post to the endpoint
                var res = await client.PutAsync(url, content);
                if (res.IsSuccessStatusCode)
                {
                    return (true, "");
                }
                else
                {
                    return (false, await res.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);

            }

        }

        public static async Task<(bool , ServerResponse)> GetServerResponse(this HttpClient client, string url)
        {
            ServerResponse response = null;
            try 
            {
                // Post to the endpoint
                var res = await client.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    response = JsonConvert.DeserializeObject<ServerResponse>(await res.Content.ReadAsStringAsync());
                    if (response != null)
                    {
                        if (response.Success)
                        {
                            return (true, response);
                        }
                        else
                        {
                            return (false, response);
                        }
                    }
                }
                response = new ServerResponse();
                response.Message = "Request Failed";
                response.Success = false;
            }
            catch(Exception ex) 
            {
                response = new ServerResponse();
                response.Message = ex.Message;
                response.Success = false;
            }
            return (false, response);
        }
        public static async Task<T> GetJsonAsync<T>(this HttpClient client ,string url) 
        {
            try 
            {
                var res = await client.GetAsync(url);
#if DEBUG 
                var resstr = await res.Content.ReadAsStringAsync();
#endif
                if (res.IsSuccessStatusCode)
                {
					return JsonConvert.DeserializeObject<T>(await res.Content.ReadAsStringAsync());
                }
            }
            catch 
            {

            }
         
            return default(T);
        }

        public static async Task<bool> PostImagesAsync(this HttpClient httpClient, string url, List<Image> images)
		{

            try
            {
                var rnd = new Random();

				using (var formData = new MultipartFormDataContent())
				{
					foreach (var image in images)
					{
						var ms = new MemoryStream();
                        var newimg = new Bitmap(image);
                        newimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
						var imageContent = new ByteArrayContent(ms.ToArray());
						imageContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
						formData.Add(imageContent, "files", rnd.GenerateRandomString(20) + ".jpeg");
					}
					var res = await httpClient.PostAsync(url, formData);
                    var resstr = res.Content.ReadAsStringAsync();
					if (res.IsSuccessStatusCode)
					{
						return true;
					}
				}
			}
			catch
            {

            }
			return false;

		}
		public static async Task<Image> GetImageAsync(this HttpClient client, string url)
		{
            try
            {
				var response = await client.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					using (var stream = await response.Content.ReadAsStreamAsync())
					{
						return Image.FromStream(stream);
					}
				}
			}
            catch 
            {

            }
			return null;

		}

	}
}
