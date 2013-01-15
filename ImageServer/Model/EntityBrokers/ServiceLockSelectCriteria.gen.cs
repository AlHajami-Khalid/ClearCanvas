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

    public partial class ServiceLockSelectCriteria : EntitySelectCriteria
    {
        public ServiceLockSelectCriteria()
        : base("ServiceLock")
        {}
        public ServiceLockSelectCriteria(ServiceLockSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new ServiceLockSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="ServiceLockTypeEnum")]
        public ISearchCondition<ServiceLockTypeEnum> ServiceLockTypeEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("ServiceLockTypeEnum"))
              {
                 SubCriteria["ServiceLockTypeEnum"] = new SearchCondition<ServiceLockTypeEnum>("ServiceLockTypeEnum");
              }
              return (ISearchCondition<ServiceLockTypeEnum>)SubCriteria["ServiceLockTypeEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="Lock")]
        public ISearchCondition<Boolean> Lock
        {
            get
            {
              if (!SubCriteria.ContainsKey("Lock"))
              {
                 SubCriteria["Lock"] = new SearchCondition<Boolean>("Lock");
              }
              return (ISearchCondition<Boolean>)SubCriteria["Lock"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="ScheduledTime")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="Enabled")]
        public ISearchCondition<Boolean> Enabled
        {
            get
            {
              if (!SubCriteria.ContainsKey("Enabled"))
              {
                 SubCriteria["Enabled"] = new SearchCondition<Boolean>("Enabled");
              }
              return (ISearchCondition<Boolean>)SubCriteria["Enabled"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="State")]
        public ISearchCondition<XmlDocument> State
        {
            get
            {
              if (!SubCriteria.ContainsKey("State"))
              {
                 SubCriteria["State"] = new SearchCondition<XmlDocument>("State");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["State"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="FilesystemGUID")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="ServiceLock", ColumnName="ProcessorId")]
        public ISearchCondition<String> ProcessorId
        {
            get
            {
              if (!SubCriteria.ContainsKey("ProcessorId"))
              {
                 SubCriteria["ProcessorId"] = new SearchCondition<String>("ProcessorId");
              }
              return (ISearchCondition<String>)SubCriteria["ProcessorId"];
            } 
        }
    }
}
