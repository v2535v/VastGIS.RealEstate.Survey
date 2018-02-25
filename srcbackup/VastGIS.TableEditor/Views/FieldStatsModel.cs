using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.TableEditor.Views
{
    internal class FieldStatsModel
    {
        public FieldStatsModel(IAttributeTable table, int fieldIndex)
        {
            if (table == null) throw new ArgumentNullException("table");

            Table = table;
            FieldIndex = fieldIndex;
        }

        public IAttributeTable Table { get; private set; }
        public int FieldIndex { get; private set; }
    }
}
