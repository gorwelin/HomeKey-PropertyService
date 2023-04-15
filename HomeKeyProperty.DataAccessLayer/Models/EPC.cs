using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeKeyProperty.DataAccessLayer.Models
{
    public interface EPC
    {
        int Id { get; set; }
        string CertificateNumber { get; set; }
        int PropertyId { get; set; }
        DateTime DateRegistered { get; set; }
        DateTime ExpiryDate { get; set; }
        int FloorAreaSM { get; set; }
        int CurrentRating { get; set; }
        int PotentialRating { get; set; }
    }
}
