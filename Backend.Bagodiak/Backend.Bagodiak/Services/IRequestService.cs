using System.Net.Http;

namespace Backend.Bagodiak.Services
{
    public interface IRequestService
    {
        HttpClient Client { get; set; }
    }
}
