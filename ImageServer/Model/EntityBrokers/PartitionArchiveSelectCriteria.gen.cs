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

    public partial class PartitionArchiveSelectCriteria : EntitySelectCriteria
    {
        public PartitionArchiveSelectCriteria()
        : base("PartitionArchive")
        {}
        public PartitionArchiveSelectCriteria(PartitionArchiveSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new PartitionArchiveSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ServerPartitionGUID")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ArchiveTypeEnum")]
        public ISearchCondition<ArchiveTypeEnum> ArchiveTypeEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("ArchiveTypeEnum"))
              {
                 SubCriteria["ArchiveTypeEnum"] = new SearchCondition<ArchiveTypeEnum>("ArchiveTypeEnum");
              }
              return (ISearchCondition<ArchiveTypeEnum>)SubCriteria["ArchiveTypeEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="Description")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="Enabled")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ReadOnly")]
        public ISearchCondition<Boolean> ReadOnly
        {
            get
            {
              if (!SubCriteria.ContainsKey("ReadOnly"))
              {
                 SubCriteria["ReadOnly"] = new SearchCondition<Boolean>("ReadOnly");
              }
              return (ISearchCondition<Boolean>)SubCriteria["ReadOnly"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ArchiveDelayHours")]
        public ISearchCondition<Int32> ArchiveDelayHours
        {
            get
            {
              if (!SubCriteria.ContainsKey("ArchiveDelayHours"))
              {
                 SubCriteria["ArchiveDelayHours"] = new SearchCondition<Int32>("ArchiveDelayHours");
              }
              return (ISearchCondition<Int32>)SubCriteria["ArchiveDelayHours"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="PartitionArchive", ColumnName="ConfigurationXml")]
        public ISearchCondition<XmlDocument> ConfigurationXml
        {
            get
            {
              if (!SubCriteria.ContainsKey("ConfigurationXml"))
              {
                 SubCriteria["ConfigurationXml"] = new SearchCondition<XmlDocument>("ConfigurationXml");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["ConfigurationXml"];
            } 
        }
    }
}
