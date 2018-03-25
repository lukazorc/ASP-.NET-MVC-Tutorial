using System.Collections.Generic;

namespace Vidly.Dtos
{
    public class NewRentalDto
    {
        public int CustumerId { get; set; }
        public List<int> MoviesIds { get; set; }
    }
}