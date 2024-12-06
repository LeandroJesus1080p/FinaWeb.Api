namespace Fina.Core.Requests;

//Uma classe abstrata so pode ser herdada e não posso criar um objeto eu uma newRequest
// Defini a paginação e a quantidade de conteudo que sera mostrado por pagina
public abstract class PagedRequest : Request
{
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
}