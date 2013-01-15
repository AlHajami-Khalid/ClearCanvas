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
    using ClearCanvas.ImageServer.Enterprise;

   public class AlertUpdateColumns : EntityUpdateColumns
   {
       public AlertUpdateColumns()
       : base("Alert")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="Alert", ColumnName="InsertTime")]
        public DateTime InsertTime
        {
            set { SubParameters["InsertTime"] = new EntityUpdateColumn<DateTime>("InsertTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Alert", ColumnName="Component")]
        public String Component
        {
            set { SubParameters["Component"] = new EntityUpdateColumn<String>("Component", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Alert", ColumnName="TypeCode")]
        public Int32 TypeCode
        {
            set { SubParameters["TypeCode"] = new EntityUpdateColumn<Int32>("TypeCode", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Alert", ColumnName="Source")]
        public String Source
        {
            set { SubParameters["Source"] = new EntityUpdateColumn<String>("Source", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Alert", ColumnName="AlertLevelEnum")]
        public AlertLevelEnum AlertLevelEnum
        {
            set { SubParameters["AlertLevelEnum"] = new EntityUpdateColumn<AlertLevelEnum>("AlertLevelEnum", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Alert", ColumnName="AlertCategoryEnum")]
        public AlertCategoryEnum AlertCategoryEnum
        {
            set { SubParameters["AlertCategoryEnum"] = new EntityUpdateColumn<AlertCategoryEnum>("AlertCategoryEnum", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Alert", ColumnName="Content")]
        public XmlDocument Content
        {
            set { SubParameters["Content"] = new EntityUpdateColumn<XmlDocument>("Content", value); }
        }
    }
}
