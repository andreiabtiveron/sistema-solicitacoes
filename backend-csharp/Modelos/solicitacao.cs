namespace SolicitacoesApi.Modelos;

public class Solicitacao{
    public int Id{get; set;}
    public string Titulo{get;set;} = string.Empty; //inicia vazio p evitar null
    public string Solicitante{get;set;} = string.Empty; 
    public string Status{get;set;} = "Pendente"; //define valor padrao
}

//dto separado pro post
public class SolicitacaoCreateDto{
    public string Titulo{get;set;} = string.Empty;
    public string Solicitante{get;set;} = string.Empty;
    public string Status {get;set;} = "Pendente";
}

//dto pro put
public class SolicitacaoUpdateDto{
    public string Status{get;set;} = string.Empty;
}