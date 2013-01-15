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

    public partial class PatientSelectCriteria : EntitySelectCriteria
    {
        public PatientSelectCriteria()
        : base("Patient")
        {}
        public PatientSelectCriteria(PatientSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new PatientSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="ServerPartitionGUID")]
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
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="NumberOfPatientRelatedStudies")]
        public ISearchCondition<Int32> NumberOfPatientRelatedStudies
        {
            get
            {
              if (!SubCriteria.ContainsKey("NumberOfPatientRelatedStudies"))
              {
                 SubCriteria["NumberOfPatientRelatedStudies"] = new SearchCondition<Int32>("NumberOfPatientRelatedStudies");
              }
              return (ISearchCondition<Int32>)SubCriteria["NumberOfPatientRelatedStudies"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="NumberOfPatientRelatedSeries")]
        public ISearchCondition<Int32> NumberOfPatientRelatedSeries
        {
            get
            {
              if (!SubCriteria.ContainsKey("NumberOfPatientRelatedSeries"))
              {
                 SubCriteria["NumberOfPatientRelatedSeries"] = new SearchCondition<Int32>("NumberOfPatientRelatedSeries");
              }
              return (ISearchCondition<Int32>)SubCriteria["NumberOfPatientRelatedSeries"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="NumberOfPatientRelatedInstances")]
        public ISearchCondition<Int32> NumberOfPatientRelatedInstances
        {
            get
            {
              if (!SubCriteria.ContainsKey("NumberOfPatientRelatedInstances"))
              {
                 SubCriteria["NumberOfPatientRelatedInstances"] = new SearchCondition<Int32>("NumberOfPatientRelatedInstances");
              }
              return (ISearchCondition<Int32>)SubCriteria["NumberOfPatientRelatedInstances"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="SpecificCharacterSet")]
        public ISearchCondition<String> SpecificCharacterSet
        {
            get
            {
              if (!SubCriteria.ContainsKey("SpecificCharacterSet"))
              {
                 SubCriteria["SpecificCharacterSet"] = new SearchCondition<String>("SpecificCharacterSet");
              }
              return (ISearchCondition<String>)SubCriteria["SpecificCharacterSet"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="PatientsName")]
        public ISearchCondition<String> PatientsName
        {
            get
            {
              if (!SubCriteria.ContainsKey("PatientsName"))
              {
                 SubCriteria["PatientsName"] = new SearchCondition<String>("PatientsName");
              }
              return (ISearchCondition<String>)SubCriteria["PatientsName"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="PatientId")]
        public ISearchCondition<String> PatientId
        {
            get
            {
              if (!SubCriteria.ContainsKey("PatientId"))
              {
                 SubCriteria["PatientId"] = new SearchCondition<String>("PatientId");
              }
              return (ISearchCondition<String>)SubCriteria["PatientId"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Patient", ColumnName="IssuerOfPatientId")]
        public ISearchCondition<String> IssuerOfPatientId
        {
            get
            {
              if (!SubCriteria.ContainsKey("IssuerOfPatientId"))
              {
                 SubCriteria["IssuerOfPatientId"] = new SearchCondition<String>("IssuerOfPatientId");
              }
              return (ISearchCondition<String>)SubCriteria["IssuerOfPatientId"];
            } 
        }
    }
}
