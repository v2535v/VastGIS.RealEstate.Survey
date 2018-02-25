﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.RealEstate.Attribute;
using VastGIS.Plugins.RealEstate.EditSettings;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate
{
    [MapWindowPlugin(loadOnStartUp: true)]
    public class RealEstateEditor : BasePlugin
    {
        private IAppContext _context;
        private MapListener _mapListener;
        private MenuGenerator _menuGenerator;
        private MenuListener _menuListener;
        private ProjectListener _projectListener;
        // private MenuUpdater _menuUpdater;
        private List<ICommand> _commands;
        private VgObjectclass _currentObjectClass;
        private PluginConfig _config;

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }

        public override void Initialize(IAppContext context)
        {
            _context = context;

            var container = context.Container;
            _commands = new List<ICommand>();
            _mapListener = container.GetInstance<MapListener>();
            _menuGenerator = container.GetInstance<MenuGenerator>();
            _menuListener = container.GetInstance<MenuListener>();
            _projectListener = container.GetInstance<ProjectListener>();
            // _menuUpdater = container.GetInstance<MenuUpdater>();
            _commands.AddRange(_menuGenerator.MenuCommands.GetCommands());
            _config=new PluginConfig();
        }

        public void LoadAttributeForm(string objectName,string formName,long id)
        {
            string editFormName = "VastGIS.Plugins.RealEstate.Attribute." + formName;
            IReAttributeForm form =
                Activator.CreateInstance(System.Type.GetType(editFormName),null) as IReAttributeForm;
            form.Context = _context;
            form.LoadEntity(objectName, formName, id);
            //_context.View.ShowChildView(form as Form, true);
           ((Form)form).ShowDialog();
        }

        public override List<ICommand> Commands { get { return _commands; } }

        public MapListener MapListener
        {
            get { return _mapListener; }
            set { _mapListener = value; }
        }

        #region 插件配置

        public PluginConfig Config { get { return _config; } }
        //public override IEnumerable<IConfigPage> ConfigPages
        //{
        //    get { yield return _context.Container.GetInstance<RealEstateEditorConfigPage>(); }
        //}
        #endregion
    }
}
