﻿// -------------------------------------------------------------------------------------------
// <copyright file="AddConnectionPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Data.Db;
using VastGIS.Data.Views.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Data.Views
{
    public class AddConnectionPresenter : BasePresenter<IAddConnectionView, AddConnectionModel>
    {
        private readonly IFileDialogService _fileDialog;
        private readonly PostGisConnection _postGis = new PostGisConnection();

        public AddConnectionPresenter(IAddConnectionView view, IFileDialogService fileDialog)
            : base(view)
        {
            Logger.Current.Trace("Start AddConnectionPresenter");
            if (fileDialog == null) throw new ArgumentNullException("fileDialog");
            
            // PM 20160302 Added:
            if (view == null) throw new ArgumentNullException("view");
            
            _fileDialog = fileDialog;

            view.Init(_postGis);

            view.TestConnection += TestConnection;

            view.ConnectionChanged += OnConnectionChanged;
            Logger.Current.Trace("End AddConnectionPresenter");
        }

        public override bool ViewOkClicked()
        {
            var connection = View.GetConnection();
            if (connection == null)
            {
                MessageService.Current.Info("Failed to retrieve connection parameters");
                return false;
            }

            if (!connection.Validate())
            {
                return false;
            }

            Model.Connection = new DatabaseConnection(View.DatabaseType, connection.Name, connection.GetConnection(),
                connection.GetConnection(true));

            return true;
        }

        private void OnConnectionChanged()
        {
            var cn = View.GetConnection();
            var cs = cn.BuildConnection();
            View.SetRawConnection(cs);
        }

        private void TestConnection()
        {
            var info = View.GetConnection();
            if (!info.Validate())
            {
                return;
            }

            string cs = info.GetConnection();
            string errorMessage = string.Empty;

            View.StartWait();

            Task<bool>.Factory.StartNew(() => TestConnectionCore(cs, ref errorMessage)).ContinueWith(t =>
                {
                    View.StopWait();

                    if (!t.Result)
                    {
                        MessageService.Current.Warn("Failed to open connection.");
                    }
                    else
                    {
                        MessageService.Current.Info("Connected successfully");
                    }

                    Logger.Current.Info("Testing connection: {0}\n{1}", cs, t.Result ? "Success" : "Failure");
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private bool TestConnectionCore(string cs, ref string errorMessage)
        {
            using (var ds = new VectorDatasource())
            {
                bool result = ds.Open(cs);
                if (!result)
                {
                    errorMessage = ds.GdalLastErrorMsg;
                }

                return result;
            }
        }
    }
}