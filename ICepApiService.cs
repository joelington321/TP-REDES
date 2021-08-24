using System.Threading.Tasks;
using Refit;

namespace Redes{

    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync (string cep);
    }
}