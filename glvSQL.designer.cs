﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1
{
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Data;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.ComponentModel;
    using System;
    
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="glvSQL")]
    public partial class glvSQLDataContext : System.Data.Linq.DataContext
    {
        
        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
        
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
        
        public glvSQLDataContext() : 
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["glvSQLConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
        
        public glvSQLDataContext(string connection) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public glvSQLDataContext(System.Data.IDbConnection connection) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public glvSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public glvSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public System.Data.Linq.Table<glvSQL> glvSQLs
        {
            get
            {
                return this.GetTable<glvSQL>();
            }
        }
    }
    
    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.glvSQL")]
    public partial class glvSQL
    {
        
        private string _Title;
        
        private string _ImgSource;
        
        private string _Description;
        
        private string _Link;
        
        private string _Category;
        
        private string _SubCategory;
        
        private string _Company;
        
        private string _Year;
        
        private System.Guid _ID;
        
        public glvSQL()
        {
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                if ((this._Title != value))
                {
                    this._Title = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImgSource", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
        public string ImgSource
        {
            get
            {
                return this._ImgSource;
            }
            set
            {
                if ((this._ImgSource != value))
                {
                    this._ImgSource = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this._Description = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="NVarChar(100)")]
        public string Link
        {
            get
            {
                return this._Link;
            }
            set
            {
                if ((this._Link != value))
                {
                    this._Link = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
        public string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                if ((this._Category != value))
                {
                    this._Category = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubCategory", DbType="NVarChar(50)")]
        public string SubCategory
        {
            get
            {
                return this._SubCategory;
            }
            set
            {
                if ((this._SubCategory != value))
                {
                    this._SubCategory = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="NVarChar(50)")]
        public string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                if ((this._Company != value))
                {
                    this._Company = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="NVarChar(5)")]
        public string Year
        {
            get
            {
                return this._Year;
            }
            set
            {
                if ((this._Year != value))
                {
                    this._Year = value;
                }
            }
        }
        
        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL")]
        public System.Guid ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                }
            }
        }
    }
}
#pragma warning restore 1591
