﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsDatabase.Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StudentsDatabase")]
	public partial class StudentsDbContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCity(Entities.City instance);
    partial void UpdateCity(Entities.City instance);
    partial void DeleteCity(Entities.City instance);
    partial void InsertStudent(Entities.Student instance);
    partial void UpdateStudent(Entities.Student instance);
    partial void DeleteStudent(Entities.Student instance);
    #endregion
		
		public StudentsDbContext() : 
				base(global::Database.Properties.Settings.Default.StudentsDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDbContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDbContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDbContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentsDbContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Entities.City> Cities
		{
			get
			{
				return this.GetTable<Entities.City>();
			}
		}
		
		public System.Data.Linq.Table<Entities.Student> Students
		{
			get
			{
				return this.GetTable<Entities.Student>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddCity")]
		public int AddCity([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string cityName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cityName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddStudent")]
		public int AddStudent([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> city_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(11)")] string personalID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string phoneNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), city_id, firstName, lastName, personalID, phoneNumber, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteCity")]
		public int DeleteCity([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> city_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), city_id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteStudent")]
		public int DeleteStudent([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> student_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), student_id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateCity")]
		public int UpdateCity([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> city_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string newCityName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), city_id, newCityName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateStudent")]
		public int UpdateStudent([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> student_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> newCity_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string newFirstName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string newLastName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(11)")] string newPersonalID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string newPhoneNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string newEmail)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), student_id, newCity_id, newFirstName, newLastName, newPersonalID, newPhoneNumber, newEmail);
			return ((int)(result.ReturnValue));
		}
	}
}
namespace Entities
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.City")]
	public partial class City : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _City_id;
		
		private string _CityName;
		
		private EntitySet<Student> _Students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCity_idChanging(int value);
    partial void OnCity_idChanged();
    partial void OnCityNameChanging(string value);
    partial void OnCityNameChanged();
    #endregion
		
		public City()
		{
			this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int City_id
		{
			get
			{
				return this._City_id;
			}
			set
			{
				if ((this._City_id != value))
				{
					this.OnCity_idChanging(value);
					this.SendPropertyChanging();
					this._City_id = value;
					this.SendPropertyChanged("City_id");
					this.OnCity_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this.OnCityNameChanging(value);
					this.SendPropertyChanging();
					this._CityName = value;
					this.SendPropertyChanged("CityName");
					this.OnCityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Student", Storage="_Students", ThisKey="City_id", OtherKey="City_id")]
		public EntitySet<Student> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				this._Students.Assign(value);
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
		
		private void attach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.City = this;
		}
		
		private void detach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.City = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Student_id;
		
		private int _City_id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _PersonalID;
		
		private string _PhoneNumber;
		
		private string _Email;
		
		private EntityRef<City> _City;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudent_idChanging(int value);
    partial void OnStudent_idChanged();
    partial void OnCity_idChanging(int value);
    partial void OnCity_idChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnPersonalIDChanging(string value);
    partial void OnPersonalIDChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Student()
		{
			this._City = default(EntityRef<City>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Student_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Student_id
		{
			get
			{
				return this._Student_id;
			}
			set
			{
				if ((this._Student_id != value))
				{
					this.OnStudent_idChanging(value);
					this.SendPropertyChanging();
					this._Student_id = value;
					this.SendPropertyChanged("Student_id");
					this.OnStudent_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City_id", DbType="Int NOT NULL")]
		public int City_id
		{
			get
			{
				return this._City_id;
			}
			set
			{
				if ((this._City_id != value))
				{
					if (this._City.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCity_idChanging(value);
					this.SendPropertyChanging();
					this._City_id = value;
					this.SendPropertyChanged("City_id");
					this.OnCity_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonalID", DbType="NVarChar(11)")]
		public string PersonalID
		{
			get
			{
				return this._PersonalID;
			}
			set
			{
				if ((this._PersonalID != value))
				{
					this.OnPersonalIDChanging(value);
					this.SendPropertyChanging();
					this._PersonalID = value;
					this.SendPropertyChanged("PersonalID");
					this.OnPersonalIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(100)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Student", Storage="_City", ThisKey="City_id", OtherKey="City_id", IsForeignKey=true)]
		public City City
		{
			get
			{
				return this._City.Entity;
			}
			set
			{
				City previousValue = this._City.Entity;
				if (((previousValue != value) 
							|| (this._City.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._City.Entity = null;
						previousValue.Students.Remove(this);
					}
					this._City.Entity = value;
					if ((value != null))
					{
						value.Students.Add(this);
						this._City_id = value.City_id;
					}
					else
					{
						this._City_id = default(int);
					}
					this.SendPropertyChanged("City");
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
}
#pragma warning restore 1591