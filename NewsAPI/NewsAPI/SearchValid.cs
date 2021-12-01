using System;
using System.ComponentModel.DataAnnotations;

namespace ValidateSearch
{
    public class ValidSearch
    {
        [Required(ErrorMessage = "Search cannot be empty")]
        [StringLength(30, ErrorMessage ="Search is too long")]

        public string SearchInput { get; set; }

        public override string ToString()
        {
            return $"Error {SearchInput}";
        }
    }
}