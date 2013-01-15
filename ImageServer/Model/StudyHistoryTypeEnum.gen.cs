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

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Collections.Generic;
    using ClearCanvas.ImageServer.Model.EntityBrokers;
    using ClearCanvas.ImageServer.Enterprise;
    using System.Reflection;

[Serializable]
public partial class StudyHistoryTypeEnum : ServerEnum
{
      #region Private Static Members
      private static readonly StudyHistoryTypeEnum _StudyReconciled = GetEnum("StudyReconciled");
      private static readonly StudyHistoryTypeEnum _WebEdited = GetEnum("WebEdited");
      private static readonly StudyHistoryTypeEnum _Duplicate = GetEnum("Duplicate");
      private static readonly StudyHistoryTypeEnum _Reprocessed = GetEnum("Reprocessed");
      private static readonly StudyHistoryTypeEnum _SeriesDeleted = GetEnum("SeriesDeleted");
      private static readonly StudyHistoryTypeEnum _ExternalEdit = GetEnum("ExternalEdit");
      #endregion

      #region Public Static Properties
      /// <summary>
      /// Demographics in the orginal images were modified to match against another study on the server.
      /// </summary>
      public static StudyHistoryTypeEnum StudyReconciled
      {
          get { return _StudyReconciled; }
      }
      /// <summary>
      /// Study was edited via the Web GUI
      /// </summary>
      public static StudyHistoryTypeEnum WebEdited
      {
          get { return _WebEdited; }
      }
      /// <summary>
      /// Duplicate was received and processed.
      /// </summary>
      public static StudyHistoryTypeEnum Duplicate
      {
          get { return _Duplicate; }
      }
      /// <summary>
      /// Study was reprocessed.
      /// </summary>
      public static StudyHistoryTypeEnum Reprocessed
      {
          get { return _Reprocessed; }
      }
      /// <summary>
      /// One or more series was deleted manually.
      /// </summary>
      public static StudyHistoryTypeEnum SeriesDeleted
      {
          get { return _SeriesDeleted; }
      }
      /// <summary>
      /// Study was edited via an external request.
      /// </summary>
      public static StudyHistoryTypeEnum ExternalEdit
      {
          get { return _ExternalEdit; }
      }

      #endregion

      #region Constructors
      public StudyHistoryTypeEnum():base("StudyHistoryTypeEnum")
      {}
      #endregion
      #region Public Members
      public override void SetEnum(short val)
      {
          ServerEnumHelper<StudyHistoryTypeEnum, IStudyHistoryTypeEnumBroker>.SetEnum(this, val);
      }
      static public List<StudyHistoryTypeEnum> GetAll()
      {
          return ServerEnumHelper<StudyHistoryTypeEnum, IStudyHistoryTypeEnumBroker>.GetAll();
      }
      static public StudyHistoryTypeEnum GetEnum(string lookup)
      {
          return ServerEnumHelper<StudyHistoryTypeEnum, IStudyHistoryTypeEnumBroker>.GetEnum(lookup);
      }
      #endregion
}
}
