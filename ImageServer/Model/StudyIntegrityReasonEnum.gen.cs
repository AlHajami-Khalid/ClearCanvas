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
public partial class StudyIntegrityReasonEnum : ServerEnum
{
      #region Private Static Members
      private static readonly StudyIntegrityReasonEnum _InconsistentData = GetEnum("InconsistentData");
      private static readonly StudyIntegrityReasonEnum _Duplicate = GetEnum("Duplicate");
      #endregion

      #region Public Static Properties
      /// <summary>
      /// Images must be reconciled because of inconsistent data.
      /// </summary>
      public static StudyIntegrityReasonEnum InconsistentData
      {
          get { return _InconsistentData; }
      }
      /// <summary>
      /// Duplicates were received and need to be reconciled.
      /// </summary>
      public static StudyIntegrityReasonEnum Duplicate
      {
          get { return _Duplicate; }
      }

      #endregion

      #region Constructors
      public StudyIntegrityReasonEnum():base("StudyIntegrityReasonEnum")
      {}
      #endregion
      #region Public Members
      public override void SetEnum(short val)
      {
          ServerEnumHelper<StudyIntegrityReasonEnum, IStudyIntegrityReasonEnumBroker>.SetEnum(this, val);
      }
      static public List<StudyIntegrityReasonEnum> GetAll()
      {
          return ServerEnumHelper<StudyIntegrityReasonEnum, IStudyIntegrityReasonEnumBroker>.GetAll();
      }
      static public StudyIntegrityReasonEnum GetEnum(string lookup)
      {
          return ServerEnumHelper<StudyIntegrityReasonEnum, IStudyIntegrityReasonEnumBroker>.GetEnum(lookup);
      }
      #endregion
}
}
