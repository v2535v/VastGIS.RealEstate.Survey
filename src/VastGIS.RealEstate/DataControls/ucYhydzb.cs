﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucYhydzb:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private Yhydzb _yhydzb;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucYhydzb()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
             intID.Enabled = false;
            _hasChanged=false;
        }
        
        private void InitDictionaries()
        {
            foreach (var onepair in _dictionaryNames)
            {
                string dName = onepair.Key;
                string dValue = onepair.Value;
                List<VgDictionary> _dicts = _database.DomainService.GetDictionaryByName(dValue);
                ComboBoxAdv combo = FindControl(this,"cmb" + onepair.Key) as ComboBoxAdv;
                combo.DataSource = _dicts;
                combo.DisplayMember ="Zdsm";
                combo.ValueMember ="Zdz";
            }
        }
        
        private Control FindControl(Control control, string controlName)
        {
            Control c1;
            foreach (Control c in control.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
                else if (c.Controls.Count > 0)
                {
                    c1 = FindControl(c, controlName);
                    if (c1 != null)
                    {
                        return c1;
                    }
                }
            }
            return null;
        }
        
        public void LinkObject(IREDatabase database,IEntity entity)
        {
            _database = database; 
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            _yhydzb=entity as Yhydzb;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_yhydzb,"ID",true,DataSourceUpdateMode.OnPropertyChanged);
            txtZhhddm.DataBindings.Clear();
            txtZhhddm.DataBindings.Add("Text",_yhydzb,"Zhhddm",true,DataSourceUpdateMode.OnPropertyChanged);
            intXh.DataBindings.Clear();
            intXh.DataBindings.Add("IntegerValue",_yhydzb,"Xh",true,DataSourceUpdateMode.OnPropertyChanged);
            dblBw.DataBindings.Clear();
            dblBw.DataBindings.Add("DoubleValue",_yhydzb,"Bw",true,DataSourceUpdateMode.OnPropertyChanged);
            dblDj.DataBindings.Clear();
            dblDj.DataBindings.Add("DoubleValue",_yhydzb,"Dj",true,DataSourceUpdateMode.OnPropertyChanged);
            
            ((INotifyPropertyChanged)_yhydzb).PropertyChanged += Entity_PropertyChanged;
            _hasChanged=false;
        }

        private void Entity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _hasChanged=true;
        }
        
        #region IEntityControl接口
        public bool HasChanged{get{return _hasChanged;}}
        public bool Save()
        {
            return _database.SystemService.Save((IEntity)_yhydzb);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_yhydzb);
        }        
        #endregion
        
        
    }
}