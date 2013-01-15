﻿#region License

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

using System;


namespace ClearCanvas.Desktop
{
	/// <summary>
	/// Holds parameters that control the creation of an alert notification.
	/// </summary>
	public class AlertNotificationArgs
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="level"></param>
		/// <param name="message"></param>
		public AlertNotificationArgs(AlertLevel level, string message)
		{
			this.Level = level;
			this.Message = message;
		}

		/// <summary>
		/// Gets or sets the alert level.
		/// </summary>
		public AlertLevel Level { get; set; }

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the link text, if the alert has a contextual link.
		/// </summary>
		public string LinkText { get; set; }

		/// <summary>
		/// Gets or sets the link action, if the alert has a contextual link.
		/// </summary>
		public Action<DesktopWindow> LinkAction { get; set; }

		/// <summary>
		/// Gets or sets a value that determines whether the alert notification is dismissed upon clicking the link.
		/// </summary>
		public bool DismissOnLinkClicked { get; set; }
	}
}
