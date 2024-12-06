namespace Fina.Core.Requests;

//Uma classe abstrata so pode ser herdada e não posso criar um objeto eu uma newRequest
// Sealed impede que a classe seja herdada

//Entrada de requisições a api
public abstract class Request
{
    public string UserId { get; set; } = string.Empty;
}