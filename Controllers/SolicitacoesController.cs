using Microsoft.AspNetCore.Mvc;
using SolicitacoesApi.Modelos;
using SolicitacoesApi.Repositorios;

namespace SolicitacoesApi.Controllers;

[ApiController]
[Route("solicitacoes")]

public class SolicitacoesController : ControllerBase
{
    // repositório injetado pelo .NET
    private readonly SolicitacaoRepositorio _repo;

    public SolicitacoesController(SolicitacaoRepositorio repo)
    {
        _repo = repo;
    }

    // get /solicitacoes
    [HttpGet]
    public IActionResult BuscarTodos()
    {
        return Ok(_repo.BuscarTodos());
    }

    // post /solicitacoes
    [HttpPost]
    public IActionResult Criar([FromBody] SolicitacaoCreateDto dto)
    {
        
        if (string.IsNullOrWhiteSpace(dto.Titulo))
            return BadRequest(new { erro = "O campo Titulo é mandatorio" });

        if (string.IsNullOrWhiteSpace(dto.Status))
            return BadRequest(new { erro = "O campo Status é mandatorio" });

        var nova = new Solicitacao
        {
            Titulo = dto.Titulo,
            Solicitante = dto.Solicitante,
            Status = dto.Status
        };

        return Ok(_repo.Adicionar(nova));
    }

    // put /solicitacoes/{id}
    [HttpPut("{id}")]
    public IActionResult AtualizarStatus(int id, [FromBody] SolicitacaoUpdateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Status))
            return BadRequest(new { erro = "O campo Status é obrigatório." });

        var atualizada = _repo.AtualizarStatus(id, dto.Status);

        
        if (atualizada is null)
            return NotFound(new { erro = $"Solicitação {id} não encontrada." });// retorna 404 se não encontrar

        return Ok(atualizada);
    }
}