using System.Threading.Tasks;
using Application.ApplicationLayer.Common;
using Application.ApplicationLayer.Common.JSON.Objects;
using Domain.Database;
using Domain.Database.Tables;
using FFImageLoading;
using Newtonsoft.Json;
using UIKit;

namespace UILayer.UILayer
{
    public class Application
    {
        static void Main(string[] args)
        {
            var dbContext = new DbContext();
            dbContext.OnCreate();

            //var imageResponse = WebCaller.Call("https://unsplash.com/napi/search/photos?query=dogs&per_page=20&page=2&xp=feedback-loop-v2%3Aexperiment");

            //var images = JsonConvert.DeserializeObject<WebPhotos>(imageResponse);

            //Task.Run(async () =>
            //{
            //    await SetLocalImages(images);
            //});

            UIApplication.Main(args, null, "AppDelegate");
        }

        static async Task SetLocalImages(WebPhotos images)
        {
            for (int i = 0; i < images.Results.Length; i++)
            {
                var imageStream = await ImageService.Instance.LoadUrl(images.Results[i].Urls.Full).DownSample(388, 388).AsJPGStreamAsync();

                FileManager.Save($"dog{i}", imageStream);
            }
        }
    }
}