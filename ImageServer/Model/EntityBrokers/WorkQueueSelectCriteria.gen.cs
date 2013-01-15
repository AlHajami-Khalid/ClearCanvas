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

    public partial class WorkQueueSelectCriteria : EntitySelectCriteria
    {
        public WorkQueueSelectCriteria()
        : base("WorkQueue")
        {}
        public WorkQueueSelectCriteria(WorkQueueSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new WorkQueueSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ServerPartitionGUID")]
        public ISearchCondition<ServerEntityKey> ServerPartitionKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("ServerPartitionKey"))
              {
                 SubCriteria["ServerPartitionKey"] = new SearchCondition<ServerEntityKey>("ServerPartitionKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["ServerPartitionKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="StudyStorageGUID")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="WorkQueueTypeEnum")]
        public ISearchCondition<WorkQueueTypeEnum> WorkQueueTypeEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("WorkQueueTypeEnum"))
              {
                 SubCriteria["WorkQueueTypeEnum"] = new SearchCondition<WorkQueueTypeEnum>("WorkQueueTypeEnum");
              }
              return (ISearchCondition<WorkQueueTypeEnum>)SubCriteria["WorkQueueTypeEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="WorkQueueStatusEnum")]
        public ISearchCondition<WorkQueueStatusEnum> WorkQueueStatusEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("WorkQueueStatusEnum"))
              {
                 SubCriteria["WorkQueueStatusEnum"] = new SearchCondition<WorkQueueStatusEnum>("WorkQueueStatusEnum");
              }
              return (ISearchCondition<WorkQueueStatusEnum>)SubCriteria["WorkQueueStatusEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="WorkQueuePriorityEnum")]
        public ISearchCondition<WorkQueuePriorityEnum> WorkQueuePriorityEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("WorkQueuePriorityEnum"))
              {
                 SubCriteria["WorkQueuePriorityEnum"] = new SearchCondition<WorkQueuePriorityEnum>("WorkQueuePriorityEnum");
              }
              return (ISearchCondition<WorkQueuePriorityEnum>)SubCriteria["WorkQueuePriorityEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ScheduledTime")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="InsertTime")]
        public ISearchCondition<DateTime> InsertTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("InsertTime"))
              {
                 SubCriteria["InsertTime"] = new SearchCondition<DateTime>("InsertTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["InsertTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="FailureCount")]
        public ISearchCondition<Int32> FailureCount
        {
            get
            {
              if (!SubCriteria.ContainsKey("FailureCount"))
              {
                 SubCriteria["FailureCount"] = new SearchCondition<Int32>("FailureCount");
              }
              return (ISearchCondition<Int32>)SubCriteria["FailureCount"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="FailureDescription")]
        public ISearchCondition<String> FailureDescription
        {
            get
            {
              if (!SubCriteria.ContainsKey("FailureDescription"))
              {
                 SubCriteria["FailureDescription"] = new SearchCondition<String>("FailureDescription");
              }
              return (ISearchCondition<String>)SubCriteria["FailureDescription"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="Data")]
        public ISearchCondition<XmlDocument> Data
        {
            get
            {
              if (!SubCriteria.ContainsKey("Data"))
              {
                 SubCriteria["Data"] = new SearchCondition<XmlDocument>("Data");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["Data"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="LastUpdatedTime")]
        public ISearchCondition<DateTime> LastUpdatedTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("LastUpdatedTime"))
              {
                 SubCriteria["LastUpdatedTime"] = new SearchCondition<DateTime>("LastUpdatedTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["LastUpdatedTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ProcessorID")]
        public ISearchCondition<String> ProcessorID
        {
            get
            {
              if (!SubCriteria.ContainsKey("ProcessorID"))
              {
                 SubCriteria["ProcessorID"] = new SearchCondition<String>("ProcessorID");
              }
              return (ISearchCondition<String>)SubCriteria["ProcessorID"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="GroupID")]
        public ISearchCondition<String> GroupID
        {
            get
            {
              if (!SubCriteria.ContainsKey("GroupID"))
              {
                 SubCriteria["GroupID"] = new SearchCondition<String>("GroupID");
              }
              return (ISearchCondition<String>)SubCriteria["GroupID"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="ExpirationTime")]
        public ISearchCondition<DateTime> ExpirationTime
        {
            get
            {
              if (!SubCriteria.ContainsKey("ExpirationTime"))
              {
                 SubCriteria["ExpirationTime"] = new SearchCondition<DateTime>("ExpirationTime");
              }
              return (ISearchCondition<DateTime>)SubCriteria["ExpirationTime"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="DeviceGUID")]
        public ISearchCondition<ServerEntityKey> DeviceKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("DeviceKey"))
              {
                 SubCriteria["DeviceKey"] = new SearchCondition<ServerEntityKey>("DeviceKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["DeviceKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueue", ColumnName="StudyHistoryGUID")]
        public ISearchCondition<ServerEntityKey> StudyHistoryKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("StudyHistoryKey"))
              {
                 SubCriteria["StudyHistoryKey"] = new SearchCondition<ServerEntityKey>("StudyHistoryKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["StudyHistoryKey"];
            } 
        }
    }
}
