using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Common;
public class BaseEntity : IBaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; } = false;

    public DateTime CreatedDate = DateTime.Now;
    public DateTime UpdatedDate { get; set; }   
}
