using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeKeyProperty.DataAccessLayer.Models
{
    public interface IRoom
    {
        int Id { get; set; }
        string Name { get; set; }
        string? Width { get; set; }
        string? Length { get; set; }
        string? Height { get; set; }
    }
}
