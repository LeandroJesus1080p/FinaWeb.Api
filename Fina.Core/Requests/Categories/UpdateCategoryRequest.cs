﻿using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }

    //DataAnotations
    [Required(ErrorMessage = "Titulo inválido")]
    [MaxLength(80, ErrorMessage = "O titulo deve conter ato")]
    public string Title { get; set; } = string.Empty;
    
    //DataAnotations
    [Required(ErrorMessage = "Descrição inválida")]
    public string? Description { get; set; }
}