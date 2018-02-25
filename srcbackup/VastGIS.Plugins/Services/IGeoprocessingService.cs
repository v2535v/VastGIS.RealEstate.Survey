﻿namespace VastGIS.Plugins.Services
{
    public interface IGeoprocessingService
    {
        /// <summary>
        /// Merges selected shapes
        /// </summary>
        void MergeShapes();

        /// <summary>
        /// Splits selected multipart shapes
        /// </summary>
        void ExplodeShapes();

        /// <summary>
        /// Removes selected shapes
        /// </summary>
        void RemoveSelectedShapes(bool prompt);

        void RemoveSelectedShapes(int layerHandle, bool prompt);

        bool BufferIsEmpty { get; }
        void CopyShapes();
        void PasteShapes();
        void CutShapes();
    }
}
