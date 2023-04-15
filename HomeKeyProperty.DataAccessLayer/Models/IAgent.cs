using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeKeyProperty.DataAccessLayer.Models
{
    public interface IAgent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Town { get; set; }
        DateTime DateAdded { get; set; }
        string Address { get; set; }
        string Telephone { get; set; }
        string EmailAddress { get; set; }
    }
}
