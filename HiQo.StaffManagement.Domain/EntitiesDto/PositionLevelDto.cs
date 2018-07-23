using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    class PositionLevelDto
    {
        public int PositionLevelId { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
    }
}
