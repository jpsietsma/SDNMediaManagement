using MediaMaintenanceLibrary.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.interfaces
{
    interface IBaseMediaItem
    {
        MediaTypeOptions fileMediaType { get; set; }
    }
}
