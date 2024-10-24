﻿using ViaCep.Integracao.Response;

namespace ViaCep.Integracao.Interfaces;

public interface IViaCepIntegracao
{
    Task<ViaCepResponse> ObterDadosViaCep(string cep);
}
