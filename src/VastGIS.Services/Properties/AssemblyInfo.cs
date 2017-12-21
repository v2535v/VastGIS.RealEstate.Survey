// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   AssemblyInfo.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
// The other assembly attributes are in SolutionItems/SolutionInfoCore.cs
[assembly: AssemblyProduct("VastGIS.Services")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3F8B8BF5-4C5B-4A69-B344-BD1D8EAC6CCC")]

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

[assembly: InternalsVisibleTo("VastGIS")]
