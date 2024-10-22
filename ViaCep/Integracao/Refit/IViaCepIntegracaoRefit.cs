using Refit;
using ViaCep.Integracao.Response;

namespace ViaCep.Integracao.Refit;

public interface IViaCepIntegracaoRefit
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
}
