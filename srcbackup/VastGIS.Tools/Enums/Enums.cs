﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Enums.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The parameter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace VastGIS.Tools.Enums
{
    /// <summary>
    /// The parameter type.
    /// </summary>
    public enum ControlHint
    {
        Auto = 0, 
        Field = 1, 
        Combo = 2,
        Filename = 3,
        MultiLineString = 4,
        OutputName = 5,
        MultipleFilename = 6,
    }

    public enum TaskCommand
    {
        Clear = 0,
        OpenLog = 2,
        CancelTask = 3,
        PauseTask = 4,
        RemoveTask = 5,
        Rerun = 6,
        RunAnother = 7,
        RemoveOutput = 8,
        OpenLocation = 9,
    }

    internal enum TaskIcons
    {
        InProgress = 0,
        Success = 1,
        Error = 2,
        Input = 3,
        Result = 4,
        Execution = 5,
        Log = 6,
        Cancel = 7,
        Pause = 8,
        Tasks = 9,
        NotStarted = 10,
    }

    public enum ToolIcon
    {
        Folder = 0,
        ToolDefault = 1,
        Vector = 2,
        Database = 3,
        Hammer = 4,
    }

    public enum ToolboxCommand
    {
        Run = 0,
        BatchRun = 1,
    }

    public enum InputType
    {
        Datasource = 0,
        Layer = 1,
    }

    public enum ParameterGroup
    {
        Input = 0,
        Output = 1,
        Required = 2,
        Optional = 3,
    }

    public enum PolygonCenter
    {
        Center = 0,
        Centroid = 1,
        InteriorPoint = 2,
    }

    public enum ValidationError
    {
        None = -1,
        TopologyError = 0,        		    
		RepeatedPoint = 1,
		HoleLiesOutsideShell = 2,
		HolesAreNested = 3,
		InteriorIsDisconnected = 4,
		RingSelfIntersection = 5,
		SelfIntersection = 6,
		NestedShells = 7,
		DuplicateRings = 8,
		TooFewPointsInGeometryComponent = 9,
		InvalidCoordinate = 10,
		RingIsNotClosed = 11,
        PolygonMustBeClockWise = 12,
        Unknown = 1000,
    }
}