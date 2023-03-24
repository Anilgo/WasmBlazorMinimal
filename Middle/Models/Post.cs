

using System.ComponentModel.DataAnnotations;

namespace Middle.Models;

    public sealed class Post
    {
    [Key]
    public int PostId { get; set; } = 0;

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Content { get; set; } = string.Empty;
}

