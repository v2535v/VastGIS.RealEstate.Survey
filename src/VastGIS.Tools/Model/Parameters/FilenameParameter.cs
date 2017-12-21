using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Enums;
using VastGIS.Tools.Controls.Parameters;
using VastGIS.Tools.Controls.Parameters.Input;

namespace VastGIS.Tools.Model.Parameters
{
    public class FilenameParameter: BaseParameter, IInputParameter
    {
        private readonly DataSourceType _dataType;

        public FilenameParameter(DataSourceType dataType)
        {
            _dataType = dataType;
        }

        public DataSourceType DataType
        {
            get { return _dataType; }
        }

        private IEnumerable<string> Filenames
        {
            get
            {
                var blpc = Control as BatchFilenameParameterControl;
                if (blpc != null)
                {
                    return blpc.Filenames;
                }

                return new List<string>();
            }
        }

        public object BatchInputs
        {
            get { return Filenames; }
        }

        public bool HasBatchInputs
        {
            get { return Filenames.Any(); }
        }
    }
}
