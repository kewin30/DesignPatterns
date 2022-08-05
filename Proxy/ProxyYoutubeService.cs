using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ProxyYoutubeService : IYouTubeService
    {
        private YoutubeService _youtubeService;
        private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();
        public ProxyYoutubeService(YoutubeService youtubeService)
        {
            _youtubeService = youtubeService;
        }
    
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"ProxyYouTubeService getting {videoId}");
            byte[] cachedVideo;
            if(_cache.TryGetValue(videoId, out cachedVideo))
            {
                Console.WriteLine($"Getting from cache {videoId}");
                return cachedVideo;
            }
            var video =_youtubeService.GetVideo(videoId);
            _cache.Add(videoId, video);

            return video;
        }
    }
}
