using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Releasers;

namespace VastGIS.QuickDB.Concrete
{
    [Serializable]
    internal class TransientReleasePolicy : LifecycledComponentsReleasePolicy
    {
        public TransientReleasePolicy(IKernel kernel)
            : base(kernel)
        {

        }

        public override void Track(object instance, Burden burden)
        {
            ComponentModel model = burden.Model;

            // to modify the way Castle handles the Transient object uncomment the following lines
            if (model.LifestyleType == LifestyleType.Transient) return;

            base.Track(instance, burden);
        }
    }
}