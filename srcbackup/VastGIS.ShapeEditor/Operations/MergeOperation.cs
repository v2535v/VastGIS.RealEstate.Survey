﻿using System.Linq;
using VastGIS.Api;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.ShapeEditor.Operations
{
    /// <summary>
    /// Merges selected shapes of the active shapefile
    /// </summary>
    internal static class MergeOperation
    {
        public static MergeResult Run(IAppContext context)
        {
            var fs = context.Map.SelectedFeatureSet;
            
            if (fs == null || fs.NumSelected <= 1 || !fs.InteractiveEditing)
            {
                return MergeResult.NoInput;
            }

            if (fs.NumSelected > 50)
            {
                return MergeResult.TooManyShapes;
            }

            return Merge(context, fs);
        }

        private static MergeResult Merge(IAppContext context, IFeatureSet fs)
        {
            // merging
            IGeometry result = null;
            foreach (var ft in fs.Features.Where(ft => ft.Selected))
            {
                if (result == null)
                {
                    result = ft.Geometry.Clone();
                }
                else
                {
                    result = result.Clip(ft.Geometry, ClipOperation.Union);
                }
            }
            
            if (result == null)
            {
                return MergeResult.Failed;
            }

            // TODO: request for attributes

            // registering in undo list
            var history = context.Map.History;
            history.BeginBatch();

            int layerHandle = context.Map.Layers.Current.Handle;

            foreach (var ft in fs.Features.Reverse())
            {
                if (ft.Selected)
                {
                    history.Add(UndoOperation.RemoveShape, layerHandle, ft.Index);
                    fs.Features.EditDelete(ft.Index);
                }
            }
            //var features = fs.Features;
            //for (int i = features.Count() - 1; i >= 0 ; i--)
            //{
            //    if (features[i].Selected)
            //    {
            //        history.Add(UndoOperation.RemoveShape, layerHandle, i);
            //        features.EditDelete(i);
            //    }
            //}
          
            int shapeIndex = fs.Features.EditAdd(result);
            if (shapeIndex != -1)
            {
                history.Add(UndoOperation.AddShape, layerHandle, shapeIndex);
            }

            history.EndBatch();

            return MergeResult.Ok;
        }
    }
}
