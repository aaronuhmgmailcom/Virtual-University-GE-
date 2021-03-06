﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwUserGroup.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace GE.MyLearning.BL
{
	///<summary>
	/// An object representation of the 'VW_UserGroup' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VwUserGroupBase")]
	public abstract partial class VwUserGroupBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// GroupID : 
		/// </summary>
		private System.String		  _groupId = string.Empty;
		
		/// <summary>
		/// GroupName : 
		/// </summary>
		private System.String		  _groupName = string.Empty;
		
		/// <summary>
		/// Description : 
		/// </summary>
		private System.String		  _description = null;
		
		/// <summary>
		/// GroupStatus : 
		/// </summary>
		private System.Int32		  _groupStatus = (int)0;
		
		/// <summary>
		/// LeaderUserID : 
		/// </summary>
		private System.String		  _leaderUserId = string.Empty;
		
		/// <summary>
		/// UserID : 
		/// </summary>
		private System.String		  _userId = string.Empty;
		
		/// <summary>
		/// UserName : 
		/// </summary>
		private System.String		  _userName = null;
		
		/// <summary>
		/// UserCNName : 
		/// </summary>
		private System.String		  _userCnName = string.Empty;
		
		/// <summary>
		/// Email : 
		/// </summary>
		private System.String		  _email = string.Empty;
		
		/// <summary>
		/// FEBadgeID : 
		/// </summary>
		private System.String		  _feBadgeId = string.Empty;
		
		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;
		
		/// <summary>
		/// Suppresses Entity Events from Firing, 
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized] 
		private bool suppressEntityEvents = false;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="VwUserGroupBase"/> instance.
		///</summary>
		public VwUserGroupBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VwUserGroupBase"/> instance.
		///</summary>
		///<param name="_groupId"></param>
		///<param name="_groupName"></param>
		///<param name="_description"></param>
		///<param name="_groupStatus"></param>
		///<param name="_leaderUserId"></param>
		///<param name="_userId"></param>
		///<param name="_userName"></param>
		///<param name="_userCnName"></param>
		///<param name="_email"></param>
		///<param name="_feBadgeId"></param>
		public VwUserGroupBase(System.String _groupId, System.String _groupName, System.String _description, System.Int32 _groupStatus, System.String _leaderUserId, System.String _userId, System.String _userName, System.String _userCnName, System.String _email, System.String _feBadgeId)
		{
			this._groupId = _groupId;
			this._groupName = _groupName;
			this._description = _description;
			this._groupStatus = _groupStatus;
			this._leaderUserId = _leaderUserId;
			this._userId = _userId;
			this._userName = _userName;
			this._userCnName = _userCnName;
			this._email = _email;
			this._feBadgeId = _feBadgeId;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VwUserGroup"/> instance.
		///</summary>
		///<param name="_groupId"></param>
		///<param name="_groupName"></param>
		///<param name="_description"></param>
		///<param name="_groupStatus"></param>
		///<param name="_leaderUserId"></param>
		///<param name="_userId"></param>
		///<param name="_userName"></param>
		///<param name="_userCnName"></param>
		///<param name="_email"></param>
		///<param name="_feBadgeId"></param>
		public static VwUserGroup CreateVwUserGroup(System.String _groupId, System.String _groupName, System.String _description, System.Int32 _groupStatus, System.String _leaderUserId, System.String _userId, System.String _userName, System.String _userCnName, System.String _email, System.String _feBadgeId)
		{
			VwUserGroup newVwUserGroup = new VwUserGroup();
			newVwUserGroup.GroupId = _groupId;
			newVwUserGroup.GroupName = _groupName;
			newVwUserGroup.Description = _description;
			newVwUserGroup.GroupStatus = _groupStatus;
			newVwUserGroup.LeaderUserId = _leaderUserId;
			newVwUserGroup.UserId = _userId;
			newVwUserGroup.UserName = _userName;
			newVwUserGroup.UserCnName = _userCnName;
			newVwUserGroup.Email = _email;
			newVwUserGroup.FeBadgeId = _feBadgeId;
			return newVwUserGroup;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the GroupID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String GroupId
		{
			get
			{
				return this._groupId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "GroupId does not allow null values.");
				if (_groupId == value)
					return;
					
				this._groupId = value;
				this._isDirty = true;
				
				OnPropertyChanged("GroupId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GroupName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String GroupName
		{
			get
			{
				return this._groupName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "GroupName does not allow null values.");
				if (_groupName == value)
					return;
					
				this._groupName = value;
				this._isDirty = true;
				
				OnPropertyChanged("GroupName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Description property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Description
		{
			get
			{
				return this._description; 
			}
			set
			{
				if (_description == value)
					return;
					
				this._description = value;
				this._isDirty = true;
				
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GroupStatus property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 GroupStatus
		{
			get
			{
				return this._groupStatus; 
			}
			set
			{
				if (_groupStatus == value)
					return;
					
				this._groupStatus = value;
				this._isDirty = true;
				
				OnPropertyChanged("GroupStatus");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the LeaderUserID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String LeaderUserId
		{
			get
			{
				return this._leaderUserId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "LeaderUserId does not allow null values.");
				if (_leaderUserId == value)
					return;
					
				this._leaderUserId = value;
				this._isDirty = true;
				
				OnPropertyChanged("LeaderUserId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the UserID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String UserId
		{
			get
			{
				return this._userId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "UserId does not allow null values.");
				if (_userId == value)
					return;
					
				this._userId = value;
				this._isDirty = true;
				
				OnPropertyChanged("UserId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the UserName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String UserName
		{
			get
			{
				return this._userName; 
			}
			set
			{
				if (_userName == value)
					return;
					
				this._userName = value;
				this._isDirty = true;
				
				OnPropertyChanged("UserName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the UserCNName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String UserCnName
		{
			get
			{
				return this._userCnName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "UserCnName does not allow null values.");
				if (_userCnName == value)
					return;
					
				this._userCnName = value;
				this._isDirty = true;
				
				OnPropertyChanged("UserCnName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Email property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Email
		{
			get
			{
				return this._email; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "Email does not allow null values.");
				if (_email == value)
					return;
					
				this._email = value;
				this._isDirty = true;
				
				OnPropertyChanged("Email");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the FEBadgeID property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String FeBadgeId
		{
			get
			{
				return this._feBadgeId; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "FeBadgeId does not allow null values.");
				if (_feBadgeId == value)
					return;
					
				this._feBadgeId = value;
				this._isDirty = true;
				
				OnPropertyChanged("FeBadgeId");
			}
		}
		
		
		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;
		
				this._tag = value;
			}
		}
	
		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}
		

		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "VW_UserGroup"; }
		}

		
		#endregion
		
		#region Methods	
		
		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}
		
		
		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}
		
		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed VwUserGroupBase Entity 
		///</summary>
		public virtual VwUserGroupBase Copy()
		{
			//shallow copy entity
			VwUserGroup copy = new VwUserGroup();
				copy.GroupId = this.GroupId;
				copy.GroupName = this.GroupName;
				copy.Description = this.Description;
				copy.GroupStatus = this.GroupStatus;
				copy.LeaderUserId = this.LeaderUserId;
				copy.UserId = this.UserId;
				copy.UserName = this.UserName;
				copy.UserCnName = this.UserCnName;
				copy.Email = this.Email;
				copy.FeBadgeId = this.FeBadgeId;
			copy.AcceptChanges();
			return (VwUserGroup)copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion
		
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="VwUserGroupBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VwUserGroupBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VwUserGroupBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VwUserGroupBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VwUserGroupBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VwUserGroupBase Object1, VwUserGroupBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.GroupId != Object2.GroupId)
				equal = false;
			if (Object1.GroupName != Object2.GroupName)
				equal = false;
			if (Object1.Description != null && Object2.Description != null )
			{
				if (Object1.Description != Object2.Description)
					equal = false;
			}
			else if (Object1.Description == null ^ Object1.Description == null )
			{
				equal = false;
			}
			if (Object1.GroupStatus != Object2.GroupStatus)
				equal = false;
			if (Object1.LeaderUserId != Object2.LeaderUserId)
				equal = false;
			if (Object1.UserId != Object2.UserId)
				equal = false;
			if (Object1.UserName != null && Object2.UserName != null )
			{
				if (Object1.UserName != Object2.UserName)
					equal = false;
			}
			else if (Object1.UserName == null ^ Object1.UserName == null )
			{
				equal = false;
			}
			if (Object1.UserCnName != Object2.UserCnName)
				equal = false;
			if (Object1.Email != Object2.Email)
				equal = false;
			if (Object1.FeBadgeId != Object2.FeBadgeId)
				equal = false;
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	
		#endregion
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
		
		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(VwUserGroup entity, string propertyName)
		{
			switch (propertyName)
			{
				case "GroupId":
					return entity.GroupId;
				case "GroupName":
					return entity.GroupName;
				case "Description":
					return entity.Description;
				case "GroupStatus":
					return entity.GroupStatus;
				case "LeaderUserId":
					return entity.LeaderUserId;
				case "UserId":
					return entity.UserId;
				case "UserName":
					return entity.UserName;
				case "UserCnName":
					return entity.UserCnName;
				case "Email":
					return entity.Email;
				case "FeBadgeId":
					return entity.FeBadgeId;
			}
			return null;
		}
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{			
			return GetPropertyValueByName(this as VwUserGroup, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{11}{10}- GroupId: {0}{10}- GroupName: {1}{10}- Description: {2}{10}- GroupStatus: {3}{10}- LeaderUserId: {4}{10}- UserId: {5}{10}- UserName: {6}{10}- UserCnName: {7}{10}- Email: {8}{10}- FeBadgeId: {9}{10}", 
				this.GroupId,
				this.GroupName,
				(this.Description == null) ? string.Empty : this.Description.ToString(),
			     
				this.GroupStatus,
				this.LeaderUserId,
				this.UserId,
				(this.UserName == null) ? string.Empty : this.UserName.ToString(),
			     
				this.UserCnName,
				this.Email,
				this.FeBadgeId,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VwUserGroup columns.
	/// </summary>
	[Serializable]
	public enum VwUserGroupColumn
	{
		/// <summary>
		/// GroupID : 
		/// </summary>
		[EnumTextValue("GroupID")]
		[ColumnEnum("GroupID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		GroupId,
		/// <summary>
		/// GroupName : 
		/// </summary>
		[EnumTextValue("GroupName")]
		[ColumnEnum("GroupName", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 50)]
		GroupName,
		/// <summary>
		/// Description : 
		/// </summary>
		[EnumTextValue("Description")]
		[ColumnEnum("Description", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 500)]
		Description,
		/// <summary>
		/// GroupStatus : 
		/// </summary>
		[EnumTextValue("GroupStatus")]
		[ColumnEnum("GroupStatus", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		GroupStatus,
		/// <summary>
		/// LeaderUserID : 
		/// </summary>
		[EnumTextValue("LeaderUserID")]
		[ColumnEnum("LeaderUserID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		LeaderUserId,
		/// <summary>
		/// UserID : 
		/// </summary>
		[EnumTextValue("UserID")]
		[ColumnEnum("UserID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		UserId,
		/// <summary>
		/// UserName : 
		/// </summary>
		[EnumTextValue("UserName")]
		[ColumnEnum("UserName", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		UserName,
		/// <summary>
		/// UserCNName : 
		/// </summary>
		[EnumTextValue("UserCNName")]
		[ColumnEnum("UserCNName", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		UserCnName,
		/// <summary>
		/// Email : 
		/// </summary>
		[EnumTextValue("Email")]
		[ColumnEnum("Email", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 50)]
		Email,
		/// <summary>
		/// FEBadgeID : 
		/// </summary>
		[EnumTextValue("FEBadgeID")]
		[ColumnEnum("FEBadgeID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		FeBadgeId
	}//End enum

} // end namespace
