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
    public partial class WorkQueueTypeProperties: ServerEntity
    {
        #region Constructors
        public WorkQueueTypeProperties():base("WorkQueueTypeProperties")
        {}
        public WorkQueueTypeProperties(
             WorkQueueTypeEnum _workQueueTypeEnum_
            ,WorkQueuePriorityEnum _workQueuePriorityEnum_
            ,Boolean _memoryLimited_
            ,Boolean _alertFailedWorkQueue_
            ,Int32 _maxFailureCount_
            ,Int32 _processDelaySeconds_
            ,Int32 _failureDelaySeconds_
            ,Int32 _deleteDelaySeconds_
            ,Int32 _postponeDelaySeconds_
            ,Int32 _expireDelaySeconds_
            ,Int32 _maxBatchSize_
            ,Boolean _readLock_
            ,Boolean _writeLock_
            ,QueueStudyStateEnum _queueStudyStateEnum_
            ,Int16 _queueStudyStateOrder_
            ):base("WorkQueueTypeProperties")
        {
            WorkQueueTypeEnum = _workQueueTypeEnum_;
            WorkQueuePriorityEnum = _workQueuePriorityEnum_;
            MemoryLimited = _memoryLimited_;
            AlertFailedWorkQueue = _alertFailedWorkQueue_;
            MaxFailureCount = _maxFailureCount_;
            ProcessDelaySeconds = _processDelaySeconds_;
            FailureDelaySeconds = _failureDelaySeconds_;
            DeleteDelaySeconds = _deleteDelaySeconds_;
            PostponeDelaySeconds = _postponeDelaySeconds_;
            ExpireDelaySeconds = _expireDelaySeconds_;
            MaxBatchSize = _maxBatchSize_;
            ReadLock = _readLock_;
            WriteLock = _writeLock_;
            QueueStudyStateEnum = _queueStudyStateEnum_;
            QueueStudyStateOrder = _queueStudyStateOrder_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="WorkQueueTypeEnum")]
        public WorkQueueTypeEnum WorkQueueTypeEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="WorkQueuePriorityEnum")]
        public WorkQueuePriorityEnum WorkQueuePriorityEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="MemoryLimited")]
        public Boolean MemoryLimited
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="AlertFailedWorkQueue")]
        public Boolean AlertFailedWorkQueue
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="MaxFailureCount")]
        public Int32 MaxFailureCount
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="ProcessDelaySeconds")]
        public Int32 ProcessDelaySeconds
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="FailureDelaySeconds")]
        public Int32 FailureDelaySeconds
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="DeleteDelaySeconds")]
        public Int32 DeleteDelaySeconds
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="PostponeDelaySeconds")]
        public Int32 PostponeDelaySeconds
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="ExpireDelaySeconds")]
        public Int32 ExpireDelaySeconds
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="MaxBatchSize")]
        public Int32 MaxBatchSize
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="ReadLock")]
        public Boolean ReadLock
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="WriteLock")]
        public Boolean WriteLock
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="QueueStudyStateEnum")]
        public QueueStudyStateEnum QueueStudyStateEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="WorkQueueTypeProperties", ColumnName="QueueStudyStateOrder")]
        public Int16 QueueStudyStateOrder
        { get; set; }
        #endregion

        #region Static Methods
        static public WorkQueueTypeProperties Load(ServerEntityKey key)
        {
            using (var read = PersistentStoreRegistry.GetDefaultStore().OpenReadContext())
            {
                return Load(read, key);
            }
        }
        static public WorkQueueTypeProperties Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IWorkQueueTypePropertiesEntityBroker>();
            WorkQueueTypeProperties theObject = broker.Load(key);
            return theObject;
        }
        static public WorkQueueTypeProperties Insert(WorkQueueTypeProperties entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                WorkQueueTypeProperties newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public WorkQueueTypeProperties Insert(IUpdateContext update, WorkQueueTypeProperties entity)
        {
            var broker = update.GetBroker<IWorkQueueTypePropertiesEntityBroker>();
            var updateColumns = new WorkQueueTypePropertiesUpdateColumns();
            updateColumns.WorkQueueTypeEnum = entity.WorkQueueTypeEnum;
            updateColumns.WorkQueuePriorityEnum = entity.WorkQueuePriorityEnum;
            updateColumns.MemoryLimited = entity.MemoryLimited;
            updateColumns.AlertFailedWorkQueue = entity.AlertFailedWorkQueue;
            updateColumns.MaxFailureCount = entity.MaxFailureCount;
            updateColumns.ProcessDelaySeconds = entity.ProcessDelaySeconds;
            updateColumns.FailureDelaySeconds = entity.FailureDelaySeconds;
            updateColumns.DeleteDelaySeconds = entity.DeleteDelaySeconds;
            updateColumns.PostponeDelaySeconds = entity.PostponeDelaySeconds;
            updateColumns.ExpireDelaySeconds = entity.ExpireDelaySeconds;
            updateColumns.MaxBatchSize = entity.MaxBatchSize;
            updateColumns.ReadLock = entity.ReadLock;
            updateColumns.WriteLock = entity.WriteLock;
            updateColumns.QueueStudyStateEnum = entity.QueueStudyStateEnum;
            updateColumns.QueueStudyStateOrder = entity.QueueStudyStateOrder;
            WorkQueueTypeProperties newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
