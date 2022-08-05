using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubeService youtubeService = new YoutubeService();
            ProxyYoutubeService proxyYoutubeService = new ProxyYoutubeService(youtubeService);
            proxyYoutubeService.GetVideo(10);
            proxyYoutubeService.GetVideo(10);
        }
    }
}
