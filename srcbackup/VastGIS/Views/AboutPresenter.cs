﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Controls;
using VastGIS.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    public class AboutPresenter: BasePresenter<IAboutView>
    {
        private readonly IAboutView _view;

        public AboutPresenter(IAboutView view, IAppContext context) : base(view)
        {
            if (view == null) throw new ArgumentNullException("view");
            _view = view;

            view.AssemblyFilterChanged += OnAssemblyFilterChanged;
            view.OcxVersion = context.Map.VersionNumber;

            OnAssemblyFilterChanged();
        }

        private void OnAssemblyFilterChanged()
        {
            _view.Assemblies = GetAssemblies();
        }

        private List<AssemblyInfo> GetAssemblies()
        {
            IEnumerable<Assembly> list = null;

            switch (_view.AssemblyFilter)
            {
                case AssemblyFilter.All:
                    list = AppDomain.CurrentDomain.GetAssemblies()
                            .Where(item => !item.IsDynamic);
                    break;
                case AssemblyFilter.Referenced:
                    var asm = Assembly.GetExecutingAssembly();
                    var names = new HashSet<string>( asm.GetReferencedAssemblies().Select(item => item.FullName));
                    list = AppDomain.CurrentDomain.GetAssemblies()
                            .Where(item => !item.IsDynamic && names.Contains(item.FullName));
                    break;
            }

            if (list == null)
            {
                return null;
            }

            return list.Select(item => new AssemblyInfo(item))
                     .OrderBy(item => item.Name)
                     .ToList();
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
