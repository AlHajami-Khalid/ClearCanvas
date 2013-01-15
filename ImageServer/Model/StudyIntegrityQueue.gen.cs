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
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class StudyIntegrityQueue: ServerEntity
    {
        #region Constructors
        public StudyIntegrityQueue():base("StudyIntegrityQueue")
        {}
        public StudyIntegrityQueue(
             ServerEntityKey _serverPartitionKey_
            ,ServerEntityKey _studyStorageKey_
            ,DateTime _insertTime_
            ,XmlDocument _studyData_
            ,StudyIntegrityReasonEnum _studyIntegrityReasonEnum_
            ,String _groupID_
            ,XmlDocument _details_
            ,String _description_
            ):base("StudyIntegrityQueue")
        {
            ServerPartitionKey = _serverPartitionKey_;
            StudyStorageKey = _studyStorageKey_;
            InsertTime = _insertTime_;
            StudyData = _studyData_;
            StudyIntegrityReasonEnum = _studyIntegrityReasonEnum_;
            GroupID = _groupID_;
            Details = _details_;
            Description = _description_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="StudyStorageGUID")]
        public ServerEntityKey StudyStorageKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="InsertTime")]
        public DateTime InsertTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="StudyData")]
        public XmlDocument StudyData
        { get { return _StudyData; } set { _StudyData = value; } }
        [NonSerialized]
        private XmlDocument _StudyData;
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="StudyIntegrityReasonEnum")]
        public StudyIntegrityReasonEnum StudyIntegrityReasonEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="GroupID")]
        public String GroupID
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="Details")]
        public XmlDocument Details
        { get { return _Details; } set { _Details = value; } }
        [NonSerialized]
        private XmlDocument _Details;
        [EntityFieldDatabaseMappingAttribute(TableName="StudyIntegrityQueue", ColumnName="Description")]
        public String Description
        { get; set; }
        #endregion

        #region Static Methods
        static public StudyIntegrityQueue Load(ServerEntityKey key)
        {
            using (var read = PersistentStoreRegistry.GetDefaultStore().OpenReadContext())
            {
                return Load(read, key);
            }
        }
        static public StudyIntegrityQueue Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IStudyIntegrityQueueEntityBroker>();
            StudyIntegrityQueue theObject = broker.Load(key);
            return theObject;
        }
        static public StudyIntegrityQueue Insert(StudyIntegrityQueue entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                StudyIntegrityQueue newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public StudyIntegrityQueue Insert(IUpdateContext update, StudyIntegrityQueue entity)
        {
            var broker = update.GetBroker<IStudyIntegrityQueueEntityBroker>();
            var updateColumns = new StudyIntegrityQueueUpdateColumns();
            updateColumns.ServerPartitionKey = entity.ServerPartitionKey;
            updateColumns.StudyStorageKey = entity.StudyStorageKey;
            updateColumns.InsertTime = entity.InsertTime;
            updateColumns.StudyData = entity.StudyData;
            updateColumns.StudyIntegrityReasonEnum = entity.StudyIntegrityReasonEnum;
            updateColumns.GroupID = entity.GroupID;
            updateColumns.Details = entity.Details;
            updateColumns.Description = entity.Description;
            StudyIntegrityQueue newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
