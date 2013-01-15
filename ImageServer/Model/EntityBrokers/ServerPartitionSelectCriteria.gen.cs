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

    public partial class ServerPartitionSelectCriteria : EntitySelectCriteria
    {
        public ServerPartitionSelectCriteria()
        : base("ServerPartition")
        {}
        public ServerPartitionSelectCriteria(ServerPartitionSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new ServerPartitionSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="Enabled")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="Description")]
        public ISearchCondition<String> Description
        {
            get
            {
              if (!SubCriteria.ContainsKey("Description"))
              {
                 SubCriteria["Description"] = new SearchCondition<String>("Description");
              }
              return (ISearchCondition<String>)SubCriteria["Description"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="AeTitle")]
        public ISearchCondition<String> AeTitle
        {
            get
            {
              if (!SubCriteria.ContainsKey("AeTitle"))
              {
                 SubCriteria["AeTitle"] = new SearchCondition<String>("AeTitle");
              }
              return (ISearchCondition<String>)SubCriteria["AeTitle"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="Port")]
        public ISearchCondition<Int32> Port
        {
            get
            {
              if (!SubCriteria.ContainsKey("Port"))
              {
                 SubCriteria["Port"] = new SearchCondition<Int32>("Port");
              }
              return (ISearchCondition<Int32>)SubCriteria["Port"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="PartitionFolder")]
        public ISearchCondition<String> PartitionFolder
        {
            get
            {
              if (!SubCriteria.ContainsKey("PartitionFolder"))
              {
                 SubCriteria["PartitionFolder"] = new SearchCondition<String>("PartitionFolder");
              }
              return (ISearchCondition<String>)SubCriteria["PartitionFolder"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="AcceptAnyDevice")]
        public ISearchCondition<Boolean> AcceptAnyDevice
        {
            get
            {
              if (!SubCriteria.ContainsKey("AcceptAnyDevice"))
              {
                 SubCriteria["AcceptAnyDevice"] = new SearchCondition<Boolean>("AcceptAnyDevice");
              }
              return (ISearchCondition<Boolean>)SubCriteria["AcceptAnyDevice"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="AuditDeleteStudy")]
        public ISearchCondition<Boolean> AuditDeleteStudy
        {
            get
            {
              if (!SubCriteria.ContainsKey("AuditDeleteStudy"))
              {
                 SubCriteria["AuditDeleteStudy"] = new SearchCondition<Boolean>("AuditDeleteStudy");
              }
              return (ISearchCondition<Boolean>)SubCriteria["AuditDeleteStudy"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="AutoInsertDevice")]
        public ISearchCondition<Boolean> AutoInsertDevice
        {
            get
            {
              if (!SubCriteria.ContainsKey("AutoInsertDevice"))
              {
                 SubCriteria["AutoInsertDevice"] = new SearchCondition<Boolean>("AutoInsertDevice");
              }
              return (ISearchCondition<Boolean>)SubCriteria["AutoInsertDevice"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="DefaultRemotePort")]
        public ISearchCondition<Int32> DefaultRemotePort
        {
            get
            {
              if (!SubCriteria.ContainsKey("DefaultRemotePort"))
              {
                 SubCriteria["DefaultRemotePort"] = new SearchCondition<Int32>("DefaultRemotePort");
              }
              return (ISearchCondition<Int32>)SubCriteria["DefaultRemotePort"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="StudyCount")]
        public ISearchCondition<Int32> StudyCount
        {
            get
            {
              if (!SubCriteria.ContainsKey("StudyCount"))
              {
                 SubCriteria["StudyCount"] = new SearchCondition<Int32>("StudyCount");
              }
              return (ISearchCondition<Int32>)SubCriteria["StudyCount"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="DuplicateSopPolicyEnum")]
        public ISearchCondition<DuplicateSopPolicyEnum> DuplicateSopPolicyEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("DuplicateSopPolicyEnum"))
              {
                 SubCriteria["DuplicateSopPolicyEnum"] = new SearchCondition<DuplicateSopPolicyEnum>("DuplicateSopPolicyEnum");
              }
              return (ISearchCondition<DuplicateSopPolicyEnum>)SubCriteria["DuplicateSopPolicyEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="MatchAccessionNumber")]
        public ISearchCondition<Boolean> MatchAccessionNumber
        {
            get
            {
              if (!SubCriteria.ContainsKey("MatchAccessionNumber"))
              {
                 SubCriteria["MatchAccessionNumber"] = new SearchCondition<Boolean>("MatchAccessionNumber");
              }
              return (ISearchCondition<Boolean>)SubCriteria["MatchAccessionNumber"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="MatchIssuerOfPatientId")]
        public ISearchCondition<Boolean> MatchIssuerOfPatientId
        {
            get
            {
              if (!SubCriteria.ContainsKey("MatchIssuerOfPatientId"))
              {
                 SubCriteria["MatchIssuerOfPatientId"] = new SearchCondition<Boolean>("MatchIssuerOfPatientId");
              }
              return (ISearchCondition<Boolean>)SubCriteria["MatchIssuerOfPatientId"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="MatchPatientId")]
        public ISearchCondition<Boolean> MatchPatientId
        {
            get
            {
              if (!SubCriteria.ContainsKey("MatchPatientId"))
              {
                 SubCriteria["MatchPatientId"] = new SearchCondition<Boolean>("MatchPatientId");
              }
              return (ISearchCondition<Boolean>)SubCriteria["MatchPatientId"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="MatchPatientsBirthDate")]
        public ISearchCondition<Boolean> MatchPatientsBirthDate
        {
            get
            {
              if (!SubCriteria.ContainsKey("MatchPatientsBirthDate"))
              {
                 SubCriteria["MatchPatientsBirthDate"] = new SearchCondition<Boolean>("MatchPatientsBirthDate");
              }
              return (ISearchCondition<Boolean>)SubCriteria["MatchPatientsBirthDate"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="MatchPatientsName")]
        public ISearchCondition<Boolean> MatchPatientsName
        {
            get
            {
              if (!SubCriteria.ContainsKey("MatchPatientsName"))
              {
                 SubCriteria["MatchPatientsName"] = new SearchCondition<Boolean>("MatchPatientsName");
              }
              return (ISearchCondition<Boolean>)SubCriteria["MatchPatientsName"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="MatchPatientsSex")]
        public ISearchCondition<Boolean> MatchPatientsSex
        {
            get
            {
              if (!SubCriteria.ContainsKey("MatchPatientsSex"))
              {
                 SubCriteria["MatchPatientsSex"] = new SearchCondition<Boolean>("MatchPatientsSex");
              }
              return (ISearchCondition<Boolean>)SubCriteria["MatchPatientsSex"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerPartition", ColumnName="AcceptLatestReport")]
        public ISearchCondition<Boolean> AcceptLatestReport
        {
            get
            {
              if (!SubCriteria.ContainsKey("AcceptLatestReport"))
              {
                 SubCriteria["AcceptLatestReport"] = new SearchCondition<Boolean>("AcceptLatestReport");
              }
              return (ISearchCondition<Boolean>)SubCriteria["AcceptLatestReport"];
            } 
        }
    }
}
