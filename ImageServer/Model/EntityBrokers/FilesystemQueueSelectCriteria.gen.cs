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
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;

    public partial class FilesystemQueueSelectCriteria : EntitySelectCriteria
    {
        public FilesystemQueueSelectCriteria()
        : base("FilesystemQueue")
        {}
        public FilesystemQueueSelectCriteria(FilesystemQueueSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new FilesystemQueueSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="FilesystemQueue", ColumnName="FilesystemQueueTypeEnum")]
        public ISearchCondition<FilesystemQueueTypeEnum> FilesystemQueueTypeEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("FilesystemQueueTypeEnum"))
              {
                 SubCriteria["FilesystemQueueTypeEnum"] = new SearchCondition<FilesystemQueueTypeEnum>("FilesystemQueueTypeEnum");
              }
              return (ISearchCondition<FilesystemQueueTypeEnum>)SubCriteria["FilesystemQueueTypeEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="FilesystemQueue", ColumnName="StudyStorageGUID")]
        public ISearchCondition<ServerEntityKey> StudyStorageKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("StudyStorageKey"))
              {
                 SubCriteria["StudyStorageKey"] = new SearchCondition<ServerEntityKey>("StudyStorageKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["StudyStorageKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="FilesystemQueue", ColumnName="FilesystemGUID")]
        public ISearchCondition<ServerEntityKey> FilesystemKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("FilesystemKey"))
              {
                 SubCriteria["FilesystemKey"] = new SearchCondition<ServerEntityKey>("FilesystemKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["FilesystemKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="FilesystemQueue", ColumnName="ScheduledTime")]
        public ISearchCondition<DateTime> ScheduledTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("ScheduledTime"))
              {
                 SubCriteria["ScheduledTime"] = new SearchCondition<DateTime>("ScheduledTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["ScheduledTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="FilesystemQueue", ColumnName="SeriesInstanceUid")]
        public ISearchCondition<String> SeriesInstanceUid
        {
            get
            {
              if (!SubCriteria.ContainsKey("SeriesInstanceUid"))
              {
                 SubCriteria["SeriesInstanceUid"] = new SearchCondition<String>("SeriesInstanceUid");
              }
              return (ISearchCondition<String>)SubCriteria["SeriesInstanceUid"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="FilesystemQueue", ColumnName="QueueXml")]
        public ISearchCondition<XmlDocument> QueueXml
        {
            get
            {
              if (!SubCriteria.ContainsKey("QueueXml"))
              {
                 SubCriteria["QueueXml"] = new SearchCondition<XmlDocument>("QueueXml");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["QueueXml"];
            } 
        }
    }
}
