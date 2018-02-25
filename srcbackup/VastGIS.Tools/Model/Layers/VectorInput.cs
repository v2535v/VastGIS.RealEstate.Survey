using System;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.Tools.Model.Layers
{
    public class VectorInput: DatasourceInput, IVectorInput
    {
        public VectorInput(IFeatureSet fs, bool selectedOnly = false)
            : base(fs)
        {
            if (fs == null) throw new ArgumentNullException("fs");
            SelectedOnly = selectedOnly;
        }

        public new IFeatureSet Datasource
        {
            get { return base.Datasource as IFeatureSet; }
            set { base.Datasource = value; }
        }
    }
}
