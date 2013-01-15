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

    public partial class StudyHistorySelectCriteria : EntitySelectCriteria
    {
        public StudyHistorySelectCriteria()
        : base("StudyHistory")
        {}
        public StudyHistorySelectCriteria(StudyHistorySelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new StudyHistorySelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="InsertTime")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyStorageGUID")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyHistoryTypeEnum")]
        public ISearchCondition<StudyHistoryTypeEnum> StudyHistoryTypeEnum
        {
            get
            {
              if (!SubCriteria.ContainsKey("StudyHistoryTypeEnum"))
              {
                 SubCriteria["StudyHistoryTypeEnum"] = new SearchCondition<StudyHistoryTypeEnum>("StudyHistoryTypeEnum");
              }
              return (ISearchCondition<StudyHistoryTypeEnum>)SubCriteria["StudyHistoryTypeEnum"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="StudyData")]
        public ISearchCondition<XmlDocument> StudyData
        {
            get
            {
              if (!SubCriteria.ContainsKey("StudyData"))
              {
                 SubCriteria["StudyData"] = new SearchCondition<XmlDocument>("StudyData");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["StudyData"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="ChangeDescription")]
        public ISearchCondition<XmlDocument> ChangeDescription
        {
            get
            {
              if (!SubCriteria.ContainsKey("ChangeDescription"))
              {
                 SubCriteria["ChangeDescription"] = new SearchCondition<XmlDocument>("ChangeDescription");
              }
              return (ISearchCondition<XmlDocument>)SubCriteria["ChangeDescription"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyHistory", ColumnName="DestStudyStorageGUID")]
        public ISearchCondition<ServerEntityKey> DestStudyStorageKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("DestStudyStorageKey"))
              {
                 SubCriteria["DestStudyStorageKey"] = new SearchCondition<ServerEntityKey>("DestStudyStorageKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["DestStudyStorageKey"];
            } 
        }
    }
}
