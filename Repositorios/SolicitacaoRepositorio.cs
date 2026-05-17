namespace SolicitacoesApi.Repositorios;

using SolicitacoesApi.Modelos;

public class SolicitacaoRepositorio
{
    // lista com dados de exemplo pra testar
    private readonly List<Solicitacao> _solicitacoes = new(){
    new Solicitacao { 
        Id = 1, 
        Titulo = "Compra notebook", 
        Solicitante = "João", 
        Status = "Pendente" },

        new Solicitacao { 
        Id = 2, 
        Titulo = "Compra mouse", 
        Solicitante = "Joana", 
        Status = "Concluída" },
    };

    private int _proximoId = 3;

    // retorna todas as solicitacoes
    public List<Solicitacao> BuscarTodos() => _solicitacoes.ToList();

    // add uma nova solicitação
    public Solicitacao Adicionar(Solicitacao solicitacao){
        solicitacao.Id = _proximoId++;
        _solicitacoes.Add(solicitacao);
        return solicitacao;
    }

    // atualiza o status de uma solicitação
    public Solicitacao? AtualizarStatus(int id, string novoStatus)
    {
        var item = _solicitacoes.FirstOrDefault(s => s.Id == id);
        if (item is null) return null;
        item.Status = novoStatus;
        return item;
    }
}