using System.Net.Http;
using System.Threading.Tasks;

namespace CardADay.Data.WebServices;

public interface IWebService
{
    abstract Task<HttpResponseMessage> Send();
}