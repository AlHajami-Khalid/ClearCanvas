#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System.Reflection;
using ClearCanvas.Common;
using ClearCanvas.Desktop;
using ClearCanvas.Desktop.Actions;
using ClearCanvas.Utilities.DicomEditor;

namespace ClearCanvas.ImageViewer.Utilities.StudyFilters.Tools
{
	[ButtonAction("activate", DefaultToolbarActionSite + "/ToolbarDumpFiles", "Dump")]
	[MenuAction("activate", DefaultContextMenuActionSite + "/MenuDumpFiles", "Dump")]
	[EnabledStateObserver("activate", "AtLeastOneSelected", "AtLeastOneSelectedChanged")]
	[Tooltip("activate", "TooltipDumpFiles")]
	[IconSet("activate", "Icons.DicomEditorToolSmall.png", "Icons.DicomEditorToolMedium.png", "Icons.DicomEditorToolLarge.png")]
	[ViewerActionPermission("activate", ClearCanvas.Utilities.DicomEditor.AuthorityTokens.DicomEditor)]
	[ExtensionOf(typeof (StudyFilterToolExtensionPoint))]
	public class DicomEditorTool : LocalExplorerStudyFilterToolProxy<ShowDicomEditorTool>
	{
		private static MethodInfo _dumpMethod;

		private static MethodInfo DumpMethod
		{
			get
			{
				if (_dumpMethod == null)
					_dumpMethod = typeof (ShowDicomEditorTool).GetMethod("Dump", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
				return _dumpMethod;
			}
		}

		public void Dump()
		{
			MethodInfo methodInfo = DumpMethod;
			if (methodInfo != null)
				methodInfo.Invoke(base.BaseTool, null);
		}
	}
}