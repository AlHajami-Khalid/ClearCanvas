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

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Dicom;
    using ClearCanvas.ImageServer.Enterprise;

   public class StudyStorageUpdateColumns : EntityUpdateColumns
   {
       public StudyStorageUpdateColumns()
       : base("StudyStorage")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        {
            set { SubParameters["ServerPartitionKey"] = new EntityUpdateColumn<ServerEntityKey>("ServerPartitionKey", value); }
        }
       [DicomField(DicomTags.StudyInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="StudyInstanceUid")]
        public String StudyInstanceUid
        {
            set { SubParameters["StudyInstanceUid"] = new EntityUpdateColumn<String>("StudyInstanceUid", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="InsertTime")]
        public DateTime InsertTime
        {
            set { SubParameters["InsertTime"] = new EntityUpdateColumn<DateTime>("InsertTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="LastAccessedTime")]
        public DateTime LastAccessedTime
        {
            set { SubParameters["LastAccessedTime"] = new EntityUpdateColumn<DateTime>("LastAccessedTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="WriteLock")]
        public Boolean WriteLock
        {
            set { SubParameters["WriteLock"] = new EntityUpdateColumn<Boolean>("WriteLock", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="ReadLock")]
        public Int16 ReadLock
        {
            set { SubParameters["ReadLock"] = new EntityUpdateColumn<Int16>("ReadLock", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="StudyStatusEnum")]
        public StudyStatusEnum StudyStatusEnum
        {
            set { SubParameters["StudyStatusEnum"] = new EntityUpdateColumn<StudyStatusEnum>("StudyStatusEnum", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyStorage", ColumnName="QueueStudyStateEnum")]
        public QueueStudyStateEnum QueueStudyStateEnum
        {
            set { SubParameters["QueueStudyStateEnum"] = new EntityUpdateColumn<QueueStudyStateEnum>("QueueStudyStateEnum", value); }
        }
    }
}
