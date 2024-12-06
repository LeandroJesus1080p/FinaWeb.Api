using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class CreateCategoryRequest: Request
{
    //DataAnotations
    [Required(ErrorMessage = "Titulo inválido")] 
    [MaxLength(80, ErrorMessage = "O titulo deve conter at")]
    public string Title { get; set; } = string.Empty;
    
    //DataAnotations
    [Required(ErrorMessage = "Descrição invalida")]
    public string Description { get; set; } = string.Empty;
}