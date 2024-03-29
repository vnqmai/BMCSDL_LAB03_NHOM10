﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMCSDL_LAB03_NHOM.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSV")]
	public partial class QLSVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBANGDIEM(BANGDIEM instance);
    partial void UpdateBANGDIEM(BANGDIEM instance);
    partial void DeleteBANGDIEM(BANGDIEM instance);
    partial void InsertSINHVIEN(SINHVIEN instance);
    partial void UpdateSINHVIEN(SINHVIEN instance);
    partial void DeleteSINHVIEN(SINHVIEN instance);
    partial void InsertHOCPHAN(HOCPHAN instance);
    partial void UpdateHOCPHAN(HOCPHAN instance);
    partial void DeleteHOCPHAN(HOCPHAN instance);
    partial void InsertLOP(LOP instance);
    partial void UpdateLOP(LOP instance);
    partial void DeleteLOP(LOP instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    #endregion
		
		public QLSVDataContext() : 
				base(global::BMCSDL_LAB03_NHOM.Properties.Settings.Default.QLSVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BANGDIEM> BANGDIEMs
		{
			get
			{
				return this.GetTable<BANGDIEM>();
			}
		}
		
		public System.Data.Linq.Table<SINHVIEN> SINHVIENs
		{
			get
			{
				return this.GetTable<SINHVIEN>();
			}
		}
		
		public System.Data.Linq.Table<HOCPHAN> HOCPHANs
		{
			get
			{
				return this.GetTable<HOCPHAN>();
			}
		}
		
		public System.Data.Linq.Table<LOP> LOPs
		{
			get
			{
				return this.GetTable<LOP>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KIEMTRATAIKHOAN")]
		public int KIEMTRATAIKHOAN([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TENDN", DbType="NVarChar(100)")] string tENDN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MATKHAU", DbType="VarChar(100)")] string mATKHAU)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tENDN, mATKHAU);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UPDATESV")]
		public int UPDATESV([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MASV", DbType="NVarChar(20)")] string mASV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HOTEN", DbType="NVarChar(100)")] string hOTEN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NGAYSINH", DbType="DateTime")] System.Nullable<System.DateTime> nGAYSINH, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DIACHI", DbType="NVarChar(200)")] string dIACHI, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MALOP", DbType="VarChar(20)")] string mALOP, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TENDN", DbType="NVarChar(100)")] string tENDN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MATKHAU", DbType="VarChar(MAX)")] string mATKHAU)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), mASV, hOTEN, nGAYSINH, dIACHI, mALOP, tENDN, mATKHAU);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UPDATESV_KHONGMATKHAU")]
		public int UPDATESV_KHONGMATKHAU([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MASV", DbType="NVarChar(20)")] string mASV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HOTEN", DbType="NVarChar(100)")] string hOTEN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NGAYSINH", DbType="DateTime")] System.Nullable<System.DateTime> nGAYSINH, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DIACHI", DbType="NVarChar(200)")] string dIACHI, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MALOP", DbType="VarChar(20)")] string mALOP, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TENDN", DbType="NVarChar(100)")] string tENDN)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), mASV, hOTEN, nGAYSINH, dIACHI, mALOP, tENDN);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BANGDIEM")]
	public partial class BANGDIEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MASV;
		
		private string _MAHP;
		
		private System.Data.Linq.Binary _DIEMTHI;
		
		private EntityRef<SINHVIEN> _SINHVIEN;
		
		private EntityRef<HOCPHAN> _HOCPHAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMASVChanging(string value);
    partial void OnMASVChanged();
    partial void OnMAHPChanging(string value);
    partial void OnMAHPChanged();
    partial void OnDIEMTHIChanging(System.Data.Linq.Binary value);
    partial void OnDIEMTHIChanged();
    #endregion
		
		public BANGDIEM()
		{
			this._SINHVIEN = default(EntityRef<SINHVIEN>);
			this._HOCPHAN = default(EntityRef<HOCPHAN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASV", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MASV
		{
			get
			{
				return this._MASV;
			}
			set
			{
				if ((this._MASV != value))
				{
					if (this._SINHVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMASVChanging(value);
					this.SendPropertyChanging();
					this._MASV = value;
					this.SendPropertyChanged("MASV");
					this.OnMASVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHP", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHP
		{
			get
			{
				return this._MAHP;
			}
			set
			{
				if ((this._MAHP != value))
				{
					if (this._HOCPHAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAHPChanging(value);
					this.SendPropertyChanging();
					this._MAHP = value;
					this.SendPropertyChanged("MAHP");
					this.OnMAHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIEMTHI", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary DIEMTHI
		{
			get
			{
				return this._DIEMTHI;
			}
			set
			{
				if ((this._DIEMTHI != value))
				{
					this.OnDIEMTHIChanging(value);
					this.SendPropertyChanging();
					this._DIEMTHI = value;
					this.SendPropertyChanged("DIEMTHI");
					this.OnDIEMTHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SINHVIEN_BANGDIEM", Storage="_SINHVIEN", ThisKey="MASV", OtherKey="MASV", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public SINHVIEN SINHVIEN
		{
			get
			{
				return this._SINHVIEN.Entity;
			}
			set
			{
				SINHVIEN previousValue = this._SINHVIEN.Entity;
				if (((previousValue != value) 
							|| (this._SINHVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SINHVIEN.Entity = null;
						previousValue.BANGDIEMs.Remove(this);
					}
					this._SINHVIEN.Entity = value;
					if ((value != null))
					{
						value.BANGDIEMs.Add(this);
						this._MASV = value.MASV;
					}
					else
					{
						this._MASV = default(string);
					}
					this.SendPropertyChanged("SINHVIEN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOCPHAN_BANGDIEM", Storage="_HOCPHAN", ThisKey="MAHP", OtherKey="MAHP", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public HOCPHAN HOCPHAN
		{
			get
			{
				return this._HOCPHAN.Entity;
			}
			set
			{
				HOCPHAN previousValue = this._HOCPHAN.Entity;
				if (((previousValue != value) 
							|| (this._HOCPHAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOCPHAN.Entity = null;
						previousValue.BANGDIEMs.Remove(this);
					}
					this._HOCPHAN.Entity = value;
					if ((value != null))
					{
						value.BANGDIEMs.Add(this);
						this._MAHP = value.MAHP;
					}
					else
					{
						this._MAHP = default(string);
					}
					this.SendPropertyChanged("HOCPHAN");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SINHVIEN")]
	public partial class SINHVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MASV;
		
		private string _HOTEN;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _DIACHI;
		
		private string _MALOP;
		
		private string _TENDN;
		
		private System.Data.Linq.Binary _MATKHAU;
		
		private EntitySet<BANGDIEM> _BANGDIEMs;
		
		private EntityRef<LOP> _LOP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMASVChanging(string value);
    partial void OnMASVChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnMALOPChanging(string value);
    partial void OnMALOPChanged();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMATKHAUChanging(System.Data.Linq.Binary value);
    partial void OnMATKHAUChanged();
    #endregion
		
		public SINHVIEN()
		{
			this._BANGDIEMs = new EntitySet<BANGDIEM>(new Action<BANGDIEM>(this.attach_BANGDIEMs), new Action<BANGDIEM>(this.detach_BANGDIEMs));
			this._LOP = default(EntityRef<LOP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASV", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MASV
		{
			get
			{
				return this._MASV;
			}
			set
			{
				if ((this._MASV != value))
				{
					this.OnMASVChanging(value);
					this.SendPropertyChanging();
					this._MASV = value;
					this.SendPropertyChanged("MASV");
					this.OnMASVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(200)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOP", DbType="VarChar(20)")]
		public string MALOP
		{
			get
			{
				return this._MALOP;
			}
			set
			{
				if ((this._MALOP != value))
				{
					if (this._LOP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMALOPChanging(value);
					this.SendPropertyChanging();
					this._MALOP = value;
					this.SendPropertyChanged("MALOP");
					this.OnMALOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SINHVIEN_BANGDIEM", Storage="_BANGDIEMs", ThisKey="MASV", OtherKey="MASV")]
		public EntitySet<BANGDIEM> BANGDIEMs
		{
			get
			{
				return this._BANGDIEMs;
			}
			set
			{
				this._BANGDIEMs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOP_SINHVIEN", Storage="_LOP", ThisKey="MALOP", OtherKey="MALOP", IsForeignKey=true, DeleteRule="CASCADE")]
		public LOP LOP
		{
			get
			{
				return this._LOP.Entity;
			}
			set
			{
				LOP previousValue = this._LOP.Entity;
				if (((previousValue != value) 
							|| (this._LOP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOP.Entity = null;
						previousValue.SINHVIENs.Remove(this);
					}
					this._LOP.Entity = value;
					if ((value != null))
					{
						value.SINHVIENs.Add(this);
						this._MALOP = value.MALOP;
					}
					else
					{
						this._MALOP = default(string);
					}
					this.SendPropertyChanged("LOP");
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
		
		private void attach_BANGDIEMs(BANGDIEM entity)
		{
			this.SendPropertyChanging();
			entity.SINHVIEN = this;
		}
		
		private void detach_BANGDIEMs(BANGDIEM entity)
		{
			this.SendPropertyChanging();
			entity.SINHVIEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOCPHAN")]
	public partial class HOCPHAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAHP;
		
		private string _TENHP;
		
		private System.Nullable<int> _SOTC;
		
		private EntitySet<BANGDIEM> _BANGDIEMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAHPChanging(string value);
    partial void OnMAHPChanged();
    partial void OnTENHPChanging(string value);
    partial void OnTENHPChanged();
    partial void OnSOTCChanging(System.Nullable<int> value);
    partial void OnSOTCChanged();
    #endregion
		
		public HOCPHAN()
		{
			this._BANGDIEMs = new EntitySet<BANGDIEM>(new Action<BANGDIEM>(this.attach_BANGDIEMs), new Action<BANGDIEM>(this.detach_BANGDIEMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAHP", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAHP
		{
			get
			{
				return this._MAHP;
			}
			set
			{
				if ((this._MAHP != value))
				{
					this.OnMAHPChanging(value);
					this.SendPropertyChanging();
					this._MAHP = value;
					this.SendPropertyChanged("MAHP");
					this.OnMAHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENHP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TENHP
		{
			get
			{
				return this._TENHP;
			}
			set
			{
				if ((this._TENHP != value))
				{
					this.OnTENHPChanging(value);
					this.SendPropertyChanging();
					this._TENHP = value;
					this.SendPropertyChanged("TENHP");
					this.OnTENHPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOTC", DbType="Int")]
		public System.Nullable<int> SOTC
		{
			get
			{
				return this._SOTC;
			}
			set
			{
				if ((this._SOTC != value))
				{
					this.OnSOTCChanging(value);
					this.SendPropertyChanging();
					this._SOTC = value;
					this.SendPropertyChanged("SOTC");
					this.OnSOTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOCPHAN_BANGDIEM", Storage="_BANGDIEMs", ThisKey="MAHP", OtherKey="MAHP")]
		public EntitySet<BANGDIEM> BANGDIEMs
		{
			get
			{
				return this._BANGDIEMs;
			}
			set
			{
				this._BANGDIEMs.Assign(value);
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
		
		private void attach_BANGDIEMs(BANGDIEM entity)
		{
			this.SendPropertyChanging();
			entity.HOCPHAN = this;
		}
		
		private void detach_BANGDIEMs(BANGDIEM entity)
		{
			this.SendPropertyChanging();
			entity.HOCPHAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOP")]
	public partial class LOP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MALOP;
		
		private string _TENLOP;
		
		private string _MANV;
		
		private EntitySet<SINHVIEN> _SINHVIENs;
		
		private EntityRef<NHANVIEN> _NHANVIEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMALOPChanging(string value);
    partial void OnMALOPChanged();
    partial void OnTENLOPChanging(string value);
    partial void OnTENLOPChanged();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    #endregion
		
		public LOP()
		{
			this._SINHVIENs = new EntitySet<SINHVIEN>(new Action<SINHVIEN>(this.attach_SINHVIENs), new Action<SINHVIEN>(this.detach_SINHVIENs));
			this._NHANVIEN = default(EntityRef<NHANVIEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOP", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MALOP
		{
			get
			{
				return this._MALOP;
			}
			set
			{
				if ((this._MALOP != value))
				{
					this.OnMALOPChanging(value);
					this.SendPropertyChanging();
					this._MALOP = value;
					this.SendPropertyChanged("MALOP");
					this.OnMALOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TENLOP
		{
			get
			{
				return this._TENLOP;
			}
			set
			{
				if ((this._TENLOP != value))
				{
					this.OnTENLOPChanging(value);
					this.SendPropertyChanging();
					this._TENLOP = value;
					this.SendPropertyChanged("TENLOP");
					this.OnTENLOPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="VarChar(20)")]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					if (this._NHANVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOP_SINHVIEN", Storage="_SINHVIENs", ThisKey="MALOP", OtherKey="MALOP")]
		public EntitySet<SINHVIEN> SINHVIENs
		{
			get
			{
				return this._SINHVIENs;
			}
			set
			{
				this._SINHVIENs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_LOP", Storage="_NHANVIEN", ThisKey="MANV", OtherKey="MANV", IsForeignKey=true, DeleteRule="CASCADE")]
		public NHANVIEN NHANVIEN
		{
			get
			{
				return this._NHANVIEN.Entity;
			}
			set
			{
				NHANVIEN previousValue = this._NHANVIEN.Entity;
				if (((previousValue != value) 
							|| (this._NHANVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHANVIEN.Entity = null;
						previousValue.LOPs.Remove(this);
					}
					this._NHANVIEN.Entity = value;
					if ((value != null))
					{
						value.LOPs.Add(this);
						this._MANV = value.MANV;
					}
					else
					{
						this._MANV = default(string);
					}
					this.SendPropertyChanged("NHANVIEN");
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
		
		private void attach_SINHVIENs(SINHVIEN entity)
		{
			this.SendPropertyChanging();
			entity.LOP = this;
		}
		
		private void detach_SINHVIENs(SINHVIEN entity)
		{
			this.SendPropertyChanging();
			entity.LOP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private string _HOTEN;
		
		private string _EMAIL;
		
		private System.Data.Linq.Binary _LUONG;
		
		private string _TENDN;
		
		private System.Data.Linq.Binary _MATKHAU;
		
		private EntitySet<LOP> _LOPs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnLUONGChanging(System.Data.Linq.Binary value);
    partial void OnLUONGChanged();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMATKHAUChanging(System.Data.Linq.Binary value);
    partial void OnMATKHAUChanged();
    #endregion
		
		public NHANVIEN()
		{
			this._LOPs = new EntitySet<LOP>(new Action<LOP>(this.attach_LOPs), new Action<LOP>(this.detach_LOPs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(20)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LUONG", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary LUONG
		{
			get
			{
				return this._LUONG;
			}
			set
			{
				if ((this._LUONG != value))
				{
					this.OnLUONGChanging(value);
					this.SendPropertyChanging();
					this._LUONG = value;
					this.SendPropertyChanged("LUONG");
					this.OnLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_LOP", Storage="_LOPs", ThisKey="MANV", OtherKey="MANV")]
		public EntitySet<LOP> LOPs
		{
			get
			{
				return this._LOPs;
			}
			set
			{
				this._LOPs.Assign(value);
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
		
		private void attach_LOPs(LOP entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = this;
		}
		
		private void detach_LOPs(LOP entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = null;
		}
	}
}
#pragma warning restore 1591
