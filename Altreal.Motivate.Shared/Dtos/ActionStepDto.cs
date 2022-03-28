using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Shared.Dtos
{
    public class ActionStepDto
    {
        public ActionStep ActionStep { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? DueAt { get; set; }
        public bool? IsCalendarized { get; set; }

    }
}
