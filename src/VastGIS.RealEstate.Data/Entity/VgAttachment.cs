using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.RealEstate.Data.Entity
{
    public partial class VgAttachment
    {
        public AttachmentFileType FileType
        {
            get { return FileExtensionHelper.GetFileType(this.Fjlj); }
        }
    }
}
