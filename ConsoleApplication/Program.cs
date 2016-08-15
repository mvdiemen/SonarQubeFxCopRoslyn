using System.Net;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public async Task<string> DownloadContent(string url)
        {
            //Download The Search Page
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
