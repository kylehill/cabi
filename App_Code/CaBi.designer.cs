﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CapitalBikeshare")]
public partial class CaBiDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertPulledStation(PulledStation instance);
  partial void UpdatePulledStation(PulledStation instance);
  partial void DeletePulledStation(PulledStation instance);
  partial void InsertPull(Pull instance);
  partial void UpdatePull(Pull instance);
  partial void DeletePull(Pull instance);
  partial void InsertPullResult(PullResult instance);
  partial void UpdatePullResult(PullResult instance);
  partial void DeletePullResult(PullResult instance);
  #endregion
	
	public CaBiDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CapitalBikeshareConnectionString1"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CaBiDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CaBiDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CaBiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CaBiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<PulledStation> PulledStations
	{
		get
		{
			return this.GetTable<PulledStation>();
		}
	}
	
	public System.Data.Linq.Table<Pull> Pulls
	{
		get
		{
			return this.GetTable<Pull>();
		}
	}
	
	public System.Data.Linq.Table<PullResult> PullResults
	{
		get
		{
			return this.GetTable<PullResult>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="kylehill.Stations")]
public partial class PulledStation : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _StationID;
	
	private string _StationName;
	
	private System.Nullable<double> _Latitude;
	
	private System.Nullable<double> _Longitude;
	
	private System.Nullable<bool> _Installed;
	
	private System.Nullable<bool> _Locked;
	
	private System.Nullable<bool> _Temporary;
	
	private string _InstallDateSignature;
	
	private string _RemovalDateSignature;
	
	private System.Nullable<int> _Docked;
	
	private System.Nullable<int> _Empty;
	
	private EntitySet<PullResult> _PullResults;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStationIDChanging(int value);
    partial void OnStationIDChanged();
    partial void OnStationNameChanging(string value);
    partial void OnStationNameChanged();
    partial void OnLatitudeChanging(System.Nullable<double> value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(System.Nullable<double> value);
    partial void OnLongitudeChanged();
    partial void OnInstalledChanging(System.Nullable<bool> value);
    partial void OnInstalledChanged();
    partial void OnLockedChanging(System.Nullable<bool> value);
    partial void OnLockedChanged();
    partial void OnTemporaryChanging(System.Nullable<bool> value);
    partial void OnTemporaryChanged();
    partial void OnInstallDateSignatureChanging(string value);
    partial void OnInstallDateSignatureChanged();
    partial void OnRemovalDateSignatureChanging(string value);
    partial void OnRemovalDateSignatureChanged();
    partial void OnDockedChanging(System.Nullable<int> value);
    partial void OnDockedChanged();
    partial void OnEmptyChanging(System.Nullable<int> value);
    partial void OnEmptyChanged();
    #endregion
	
	public PulledStation()
	{
		this._PullResults = new EntitySet<PullResult>(new Action<PullResult>(this.attach_PullResults), new Action<PullResult>(this.detach_PullResults));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int StationID
	{
		get
		{
			return this._StationID;
		}
		set
		{
			if ((this._StationID != value))
			{
				this.OnStationIDChanging(value);
				this.SendPropertyChanging();
				this._StationID = value;
				this.SendPropertyChanged("StationID");
				this.OnStationIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
	public string StationName
	{
		get
		{
			return this._StationName;
		}
		set
		{
			if ((this._StationName != value))
			{
				this.OnStationNameChanging(value);
				this.SendPropertyChanging();
				this._StationName = value;
				this.SendPropertyChanged("StationName");
				this.OnStationNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float")]
	public System.Nullable<double> Latitude
	{
		get
		{
			return this._Latitude;
		}
		set
		{
			if ((this._Latitude != value))
			{
				this.OnLatitudeChanging(value);
				this.SendPropertyChanging();
				this._Latitude = value;
				this.SendPropertyChanged("Latitude");
				this.OnLatitudeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Float")]
	public System.Nullable<double> Longitude
	{
		get
		{
			return this._Longitude;
		}
		set
		{
			if ((this._Longitude != value))
			{
				this.OnLongitudeChanging(value);
				this.SendPropertyChanging();
				this._Longitude = value;
				this.SendPropertyChanged("Longitude");
				this.OnLongitudeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Installed", DbType="Bit")]
	public System.Nullable<bool> Installed
	{
		get
		{
			return this._Installed;
		}
		set
		{
			if ((this._Installed != value))
			{
				this.OnInstalledChanging(value);
				this.SendPropertyChanging();
				this._Installed = value;
				this.SendPropertyChanged("Installed");
				this.OnInstalledChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locked", DbType="Bit")]
	public System.Nullable<bool> Locked
	{
		get
		{
			return this._Locked;
		}
		set
		{
			if ((this._Locked != value))
			{
				this.OnLockedChanging(value);
				this.SendPropertyChanging();
				this._Locked = value;
				this.SendPropertyChanged("Locked");
				this.OnLockedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Temporary", DbType="Bit")]
	public System.Nullable<bool> Temporary
	{
		get
		{
			return this._Temporary;
		}
		set
		{
			if ((this._Temporary != value))
			{
				this.OnTemporaryChanging(value);
				this.SendPropertyChanging();
				this._Temporary = value;
				this.SendPropertyChanged("Temporary");
				this.OnTemporaryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstallDateSignature", DbType="VarChar(50)")]
	public string InstallDateSignature
	{
		get
		{
			return this._InstallDateSignature;
		}
		set
		{
			if ((this._InstallDateSignature != value))
			{
				this.OnInstallDateSignatureChanging(value);
				this.SendPropertyChanging();
				this._InstallDateSignature = value;
				this.SendPropertyChanged("InstallDateSignature");
				this.OnInstallDateSignatureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RemovalDateSignature", DbType="VarChar(50)")]
	public string RemovalDateSignature
	{
		get
		{
			return this._RemovalDateSignature;
		}
		set
		{
			if ((this._RemovalDateSignature != value))
			{
				this.OnRemovalDateSignatureChanging(value);
				this.SendPropertyChanging();
				this._RemovalDateSignature = value;
				this.SendPropertyChanged("RemovalDateSignature");
				this.OnRemovalDateSignatureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Docked", DbType="Int")]
	public System.Nullable<int> Docked
	{
		get
		{
			return this._Docked;
		}
		set
		{
			if ((this._Docked != value))
			{
				this.OnDockedChanging(value);
				this.SendPropertyChanging();
				this._Docked = value;
				this.SendPropertyChanged("Docked");
				this.OnDockedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empty", DbType="Int")]
	public System.Nullable<int> Empty
	{
		get
		{
			return this._Empty;
		}
		set
		{
			if ((this._Empty != value))
			{
				this.OnEmptyChanging(value);
				this.SendPropertyChanging();
				this._Empty = value;
				this.SendPropertyChanged("Empty");
				this.OnEmptyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PulledStation_PullResult", Storage="_PullResults", ThisKey="StationID", OtherKey="StationID")]
	public EntitySet<PullResult> PullResults
	{
		get
		{
			return this._PullResults;
		}
		set
		{
			this._PullResults.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PullResults(PullResult entity)
	{
		this.SendPropertyChanging();
		entity.PulledStation = this;
	}
	
	private void detach_PullResults(PullResult entity)
	{
		this.SendPropertyChanging();
		entity.PulledStation = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="kylehill.Pulls")]
public partial class Pull : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PullID;
	
	private string _DateSignature;
	
	private System.DateTime _PullDate;
	
	private EntitySet<PullResult> _PullResults;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPullIDChanging(int value);
    partial void OnPullIDChanged();
    partial void OnDateSignatureChanging(string value);
    partial void OnDateSignatureChanged();
    partial void OnPullDateChanging(System.DateTime value);
    partial void OnPullDateChanged();
    #endregion
	
	public Pull()
	{
		this._PullResults = new EntitySet<PullResult>(new Action<PullResult>(this.attach_PullResults), new Action<PullResult>(this.detach_PullResults));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PullID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PullID
	{
		get
		{
			return this._PullID;
		}
		set
		{
			if ((this._PullID != value))
			{
				this.OnPullIDChanging(value);
				this.SendPropertyChanging();
				this._PullID = value;
				this.SendPropertyChanged("PullID");
				this.OnPullIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateSignature", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string DateSignature
	{
		get
		{
			return this._DateSignature;
		}
		set
		{
			if ((this._DateSignature != value))
			{
				this.OnDateSignatureChanging(value);
				this.SendPropertyChanging();
				this._DateSignature = value;
				this.SendPropertyChanged("DateSignature");
				this.OnDateSignatureChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PullDate", DbType="DateTime NOT NULL")]
	public System.DateTime PullDate
	{
		get
		{
			return this._PullDate;
		}
		set
		{
			if ((this._PullDate != value))
			{
				this.OnPullDateChanging(value);
				this.SendPropertyChanging();
				this._PullDate = value;
				this.SendPropertyChanged("PullDate");
				this.OnPullDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pull_PullResult", Storage="_PullResults", ThisKey="PullID", OtherKey="PullID")]
	public EntitySet<PullResult> PullResults
	{
		get
		{
			return this._PullResults;
		}
		set
		{
			this._PullResults.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_PullResults(PullResult entity)
	{
		this.SendPropertyChanging();
		entity.Pull = this;
	}
	
	private void detach_PullResults(PullResult entity)
	{
		this.SendPropertyChanging();
		entity.Pull = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="kylehill.PullResults")]
public partial class PullResult : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PullResultID;
	
	private int _PullID;
	
	private int _StationID;
	
	private bool _Installed;
	
	private bool _Locked;
	
	private bool _Temporary;
	
	private int _Docked;
	
	private int _Empty;
	
	private EntityRef<Pull> _Pull;
	
	private EntityRef<PulledStation> _PulledStation;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPullResultIDChanging(int value);
    partial void OnPullResultIDChanged();
    partial void OnPullIDChanging(int value);
    partial void OnPullIDChanged();
    partial void OnStationIDChanging(int value);
    partial void OnStationIDChanged();
    partial void OnInstalledChanging(bool value);
    partial void OnInstalledChanged();
    partial void OnLockedChanging(bool value);
    partial void OnLockedChanged();
    partial void OnTemporaryChanging(bool value);
    partial void OnTemporaryChanged();
    partial void OnDockedChanging(int value);
    partial void OnDockedChanged();
    partial void OnEmptyChanging(int value);
    partial void OnEmptyChanged();
    #endregion
	
	public PullResult()
	{
		this._Pull = default(EntityRef<Pull>);
		this._PulledStation = default(EntityRef<PulledStation>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PullResultID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PullResultID
	{
		get
		{
			return this._PullResultID;
		}
		set
		{
			if ((this._PullResultID != value))
			{
				this.OnPullResultIDChanging(value);
				this.SendPropertyChanging();
				this._PullResultID = value;
				this.SendPropertyChanged("PullResultID");
				this.OnPullResultIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PullID", DbType="Int NOT NULL")]
	public int PullID
	{
		get
		{
			return this._PullID;
		}
		set
		{
			if ((this._PullID != value))
			{
				if (this._Pull.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPullIDChanging(value);
				this.SendPropertyChanging();
				this._PullID = value;
				this.SendPropertyChanged("PullID");
				this.OnPullIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationID", DbType="Int NOT NULL")]
	public int StationID
	{
		get
		{
			return this._StationID;
		}
		set
		{
			if ((this._StationID != value))
			{
				if (this._PulledStation.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnStationIDChanging(value);
				this.SendPropertyChanging();
				this._StationID = value;
				this.SendPropertyChanged("StationID");
				this.OnStationIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Installed", DbType="Bit NOT NULL")]
	public bool Installed
	{
		get
		{
			return this._Installed;
		}
		set
		{
			if ((this._Installed != value))
			{
				this.OnInstalledChanging(value);
				this.SendPropertyChanging();
				this._Installed = value;
				this.SendPropertyChanged("Installed");
				this.OnInstalledChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locked", DbType="Bit NOT NULL")]
	public bool Locked
	{
		get
		{
			return this._Locked;
		}
		set
		{
			if ((this._Locked != value))
			{
				this.OnLockedChanging(value);
				this.SendPropertyChanging();
				this._Locked = value;
				this.SendPropertyChanged("Locked");
				this.OnLockedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Temporary", DbType="Bit NOT NULL")]
	public bool Temporary
	{
		get
		{
			return this._Temporary;
		}
		set
		{
			if ((this._Temporary != value))
			{
				this.OnTemporaryChanging(value);
				this.SendPropertyChanging();
				this._Temporary = value;
				this.SendPropertyChanged("Temporary");
				this.OnTemporaryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Docked", DbType="Int NOT NULL")]
	public int Docked
	{
		get
		{
			return this._Docked;
		}
		set
		{
			if ((this._Docked != value))
			{
				this.OnDockedChanging(value);
				this.SendPropertyChanging();
				this._Docked = value;
				this.SendPropertyChanged("Docked");
				this.OnDockedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empty", DbType="Int NOT NULL")]
	public int Empty
	{
		get
		{
			return this._Empty;
		}
		set
		{
			if ((this._Empty != value))
			{
				this.OnEmptyChanging(value);
				this.SendPropertyChanging();
				this._Empty = value;
				this.SendPropertyChanged("Empty");
				this.OnEmptyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pull_PullResult", Storage="_Pull", ThisKey="PullID", OtherKey="PullID", IsForeignKey=true)]
	public Pull Pull
	{
		get
		{
			return this._Pull.Entity;
		}
		set
		{
			Pull previousValue = this._Pull.Entity;
			if (((previousValue != value) 
						|| (this._Pull.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Pull.Entity = null;
					previousValue.PullResults.Remove(this);
				}
				this._Pull.Entity = value;
				if ((value != null))
				{
					value.PullResults.Add(this);
					this._PullID = value.PullID;
				}
				else
				{
					this._PullID = default(int);
				}
				this.SendPropertyChanged("Pull");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PulledStation_PullResult", Storage="_PulledStation", ThisKey="StationID", OtherKey="StationID", IsForeignKey=true)]
	public PulledStation PulledStation
	{
		get
		{
			return this._PulledStation.Entity;
		}
		set
		{
			PulledStation previousValue = this._PulledStation.Entity;
			if (((previousValue != value) 
						|| (this._PulledStation.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._PulledStation.Entity = null;
					previousValue.PullResults.Remove(this);
				}
				this._PulledStation.Entity = value;
				if ((value != null))
				{
					value.PullResults.Add(this);
					this._StationID = value.StationID;
				}
				else
				{
					this._StationID = default(int);
				}
				this.SendPropertyChanged("PulledStation");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591