﻿
/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file UserGroup.cs instead.
*/

#region using directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;

using GE.MyLearning.BL.Validation;
#endregion

namespace GE.MyLearning.BL
{
	///<summary>
	/// An object representation of the 'UserGroup' table. [No description found the database]	
	///</summary>
	[Serializable]
	[DataObject, CLSCompliant(true)]
	public abstract partial class UserGroupBase : EntityBase, IUserGroup, IEntityId<UserGroupKey>, System.IComparable, System.ICloneable, ICloneableEx, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private UserGroupEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private UserGroupEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private UserGroupEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<UserGroup> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event UserGroupEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event UserGroupEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="UserGroupBase"/> instance.
		///</summary>
		public UserGroupBase()
		{
			this.entityData = new UserGroupEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="UserGroupBase"/> instance.
		///</summary>
		///<param name="_groupId"></param>
		///<param name="_userId"></param>
		public UserGroupBase(System.String _groupId, System.String _userId)
		{
			this.entityData = new UserGroupEntityData();
			this.backupData = null;

			this.GroupId = _groupId;
			this.UserId = _userId;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="UserGroup"/> instance.
		///</summary>
		///<param name="_groupId"></param>
		///<param name="_userId"></param>
		public static UserGroup CreateUserGroup(System.String _groupId, System.String _userId)
		{
			UserGroup newUserGroup = new UserGroup();
			newUserGroup.GroupId = _groupId;
			newUserGroup.UserId = _userId;
			return newUserGroup;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the GroupId property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[NotNullValidator(MessageTemplate="Property does not allow null values.", Tag="GroupID")]
		[ValidatorComposition(CompositionType.And, Tag="GroupID")]

		[StringLengthValidator(20, MessageTemplate="Maximum length has been exceeded.", Tag="GroupID")]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 20)]
		public virtual System.String GroupId
		{
			get
			{
				return this.entityData.GroupId; 
			}
			
			set
			{
				if (this.entityData.GroupId == value)
					return;
					
				OnColumnChanging(UserGroupColumn.GroupId, this.entityData.GroupId);
				this.entityData.GroupId = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(UserGroupColumn.GroupId, this.entityData.GroupId);
				OnPropertyChanged("GroupId");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the UserId property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[NotNullValidator(MessageTemplate="Property does not allow null values.", Tag="UserID")]
		[ValidatorComposition(CompositionType.And, Tag="UserID")]

		[StringLengthValidator(20, MessageTemplate="Maximum length has been exceeded.", Tag="UserID")]
		[DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 20)]
		public virtual System.String UserId
		{
			get
			{
				return this.entityData.UserId; 
			}
			
			set
			{
				if (this.entityData.UserId == value)
					return;
					
				OnColumnChanging(UserGroupColumn.UserId, this.entityData.UserId);
				this.entityData.UserId = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(UserGroupColumn.UserId, this.entityData.UserId);
				OnPropertyChanged("UserId");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the AutoId property. 
		///		
		/// </summary>
		/// <value>This type is int.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>




		[ReadOnlyAttribute(false)/*, XmlIgnoreAttribute()*/, DescriptionAttribute(@""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, true, false)]
		public virtual System.Int32 AutoId
		{
			get
			{
				return this.entityData.AutoId; 
			}
			
			set
			{
				if (this.entityData.AutoId == value)
					return;
					
				OnColumnChanging(UserGroupColumn.AutoId, this.entityData.AutoId);
				this.entityData.AutoId = value;
				this.EntityId.AutoId = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(UserGroupColumn.AutoId, this.entityData.AutoId);
				OnPropertyChanged("AutoId");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
		#endregion Children Collections
		
		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "UserGroup"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"GroupID", "UserID", "AutoID"};
			}
		}
		#endregion 
		
		#region IEditableObject
		
		#region  CancelAddNew Event
		/// <summary>
        /// The delegate for the CancelAddNew event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public delegate void CancelAddNewEventHandler(object sender, EventArgs e);
    
    	/// <summary>
		/// The CancelAddNew event.
		/// </summary>
		[field:NonSerialized]
		public event CancelAddNewEventHandler CancelAddNew ;

		/// <summary>
        /// Called when [cancel add new].
        /// </summary>
        public void OnCancelAddNew()
        {    
			if (!SuppressEntityEvents)
			{
	            CancelAddNewEventHandler handler = CancelAddNew ;
            	if (handler != null)
	            {    
    	            handler(this, EventArgs.Empty) ;
        	    }
	        }
        }
		#endregion 
		
		/// <summary>
		/// Begins an edit on an object.
		/// </summary>
		void IEditableObject.BeginEdit() 
	    {
	        //Console.WriteLine("Start BeginEdit");
	        if (!inTxn) 
	        {
	            this.backupData = this.entityData.Clone() as UserGroupEntityData;
	            inTxn = true;
	            //Console.WriteLine("BeginEdit");
	        }
	        //Console.WriteLine("End BeginEdit");
	    }
	
		/// <summary>
		/// Discards changes since the last <c>BeginEdit</c> call.
		/// </summary>
	    void IEditableObject.CancelEdit() 
	    {
	        //Console.WriteLine("Start CancelEdit");
	        if (this.inTxn) 
	        {
	            this.entityData = this.backupData;
	            this.backupData = null;
				this.inTxn = false;

				if (this.bindingIsNew)
	        	//if (this.EntityState == EntityState.Added)
	        	{
					if (this.parentCollection != null)
						this.parentCollection.Remove( (UserGroup) this ) ;
				}	            
	        }
	        //Console.WriteLine("End CancelEdit");
	    }
	
		/// <summary>
		/// Pushes changes since the last <c>BeginEdit</c> or <c>IBindingList.AddNew</c> call into the underlying object.
		/// </summary>
	    void IEditableObject.EndEdit() 
	    {
	        //Console.WriteLine("Start EndEdit" + this.custData.id + this.custData.lastName);
	        if (this.inTxn) 
	        {
	            this.backupData = null;
				if (this.IsDirty) 
				{
					if (this.bindingIsNew) {
						this.EntityState = EntityState.Added;
						this.bindingIsNew = false ;
					}
					else
						if (this.EntityState == EntityState.Unchanged) 
							this.EntityState = EntityState.Changed ;
				}

				this.bindingIsNew = false ;
	            this.inTxn = false;	            
	        }
	        //Console.WriteLine("End EndEdit");
	    }
	    
	    /// <summary>
        /// Gets or sets the parent collection of this current entity, if available.
        /// </summary>
        /// <value>The parent collection.</value>
	    [XmlIgnore]
		[Browsable(false)]
	    public override object ParentCollection
	    {
	        get 
	        {
	            return this.parentCollection;
	        }
	        set 
	        {
	            this.parentCollection = value as TList<UserGroup>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as UserGroup);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed UserGroup Entity 
		///</summary>
		protected virtual UserGroup Copy(IDictionary existingCopies)
		{
			if (existingCopies == null)
			{
				// This is the root of the tree to be copied!
				existingCopies = new Hashtable();
			}

			//shallow copy entity
			UserGroup copy = new UserGroup();
			existingCopies.Add(this, copy);
			copy.SuppressEntityEvents = true;
				copy.GroupId = this.GroupId;
				copy.UserId = this.UserId;
				copy.AutoId = this.AutoId;
			
		
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}		
		
		
		
		///<summary>
		///  Returns a Typed UserGroup Entity 
		///</summary>
		public virtual UserGroup Copy()
		{
			return this.Copy(null);	
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone()
		{
			return this.Copy(null);
		}
		
		///<summary>
		/// ICloneableEx.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone(IDictionary existingCopies)
		{
			return this.Copy(existingCopies);
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x == null)
				return null;
				
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x, IDictionary existingCopies)
		{
			if (x == null)
				return null;
			
			if (x is ICloneableEx)
			{
				// Return a deep copy of the object
				return ((ICloneableEx)x).Clone(existingCopies);
			}
			else if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable or IClonableEx Interface.");
		}
		
		
		///<summary>
		///  Returns a Typed UserGroup Entity which is a deep copy of the current entity.
		///</summary>
		public virtual UserGroup DeepCopy()
		{
			return EntityHelper.Clone<UserGroup>(this as UserGroup);	
		}
		#endregion
		
		#region Methods	
			
		///<summary>
		/// Revert all changes and restore original values.
		///</summary>
		public override void CancelChanges()
		{
			IEditableObject obj = (IEditableObject) this;
			obj.CancelEdit();

			this.entityData = null;
			if (this._originalData != null)
			{
				this.entityData = this._originalData.Clone() as UserGroupEntityData;
			}
			else
			{
				//Since this had no _originalData, then just reset the entityData with a new one.  entityData cannot be null.
				this.entityData = new UserGroupEntityData();
			}
		}	
		
		/// <summary>
		/// Accepts the changes made to this object.
		/// </summary>
		/// <remarks>
		/// After calling this method, properties: IsDirty, IsNew are false. IsDeleted flag remains unchanged as it is handled by the parent List.
		/// </remarks>
		public override void AcceptChanges()
		{
			base.AcceptChanges();

			// we keep of the original version of the data
			this._originalData = null;
			this._originalData = this.entityData.Clone() as UserGroupEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(UserGroupColumn column)
		{
			switch(column)
			{
					case UserGroupColumn.GroupId:
					return entityData.GroupId != _originalData.GroupId;
					case UserGroupColumn.UserId:
					return entityData.UserId != _originalData.UserId;
					case UserGroupColumn.AutoId:
					return entityData.AutoId != _originalData.AutoId;
			
				default:
					return false;
			}
		}
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="columnName">The column name.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public override bool IsPropertyChanged(string columnName)
		{
			return 	IsPropertyChanged(EntityHelper.GetEnumValue< UserGroupColumn >(columnName));
		}
		
		/// <summary>
		/// Determines whether the data has changed from original.
		/// </summary>
		/// <returns>
		/// 	<c>true</c> if data has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool HasDataChanged()
		{
			bool result = false;
			result = result || entityData.GroupId != _originalData.GroupId;
			result = result || entityData.UserId != _originalData.UserId;
			result = result || entityData.AutoId != _originalData.AutoId;
			return result;
		}	
		
		///<summary>
		///  Returns a UserGroup Entity with the original data.
		///</summary>
		public UserGroup GetOriginalEntity()
		{
			if (_originalData != null)
				return CreateUserGroup(
				_originalData.GroupId,
				_originalData.UserId
				);
				
			return (UserGroup)this.Clone();
		}
		#endregion
	
	#region Value Semantics Instance Equality
        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object using value semantics.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="UserGroupBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			// Cast exception if Object1 is null or DbNull
			if (Object1 != null && Object1 != DBNull.Value && Object1 is UserGroupBase)
				return ValueEquals(this, (UserGroupBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="UserGroupBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.GroupId.GetHashCode() ^ 
					this.UserId.GetHashCode() ^ 
					this.AutoId.GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object using value semantics.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="UserGroupBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(UserGroupBase toObject)
		{
			if (toObject == null)
				return false;
			return ValueEquals(this, toObject);
		}
		#endregion
		
		///<summary>
		/// Determines whether the specified <see cref="UserGroupBase"/> instances are considered equal using value semantics.
		///</summary>
		///<param name="Object1">The first <see cref="UserGroupBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="UserGroupBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool ValueEquals(UserGroupBase Object1, UserGroupBase Object2)
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
			if (Object1.UserId != Object2.UserId)
				equal = false;
			if (Object1.AutoId != Object2.AutoId)
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((UserGroupBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static UserGroupComparer GetComparer()
        {
            return new UserGroupComparer();
        }
        */

        // Comparer delegates back to UserGroup
        // Employee uses the integer's default
        // CompareTo method
        /*
        public int CompareTo(Item rhs)
        {
            return this.Id.CompareTo(rhs.Id);
        }
        */

/*
        // Special implementation to be called by custom comparer
        public int CompareTo(UserGroup rhs, UserGroupColumn which)
        {
            switch (which)
            {
            	
            	
            	case UserGroupColumn.GroupId:
            		return this.GroupId.CompareTo(rhs.GroupId);
            		
            		                 
            	
            	
            	case UserGroupColumn.UserId:
            		return this.UserId.CompareTo(rhs.UserId);
            		
            		                 
            	
            	
            	case UserGroupColumn.AutoId:
            		return this.AutoId.CompareTo(rhs.AutoId);
            		
            		                 
            }
            return 0;
        }
        */
	
		#endregion
		
		#region IComponent Members
		
		private ISite _site = null;

		/// <summary>
		/// Gets or Sets the site where this data is located.
		/// </summary>
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public ISite Site
		{
			get{ return this._site; }
			set{ this._site = value; }
		}

		#endregion

		#region IDisposable Members
		
		/// <summary>
		/// Notify those that care when we dispose.
		/// </summary>
		[field:NonSerialized]
		public event System.EventHandler Disposed;

		/// <summary>
		/// Clean up. Nothing here though.
		/// </summary>
		public virtual void Dispose()
		{
			this.parentCollection = null;
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Clean up.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				EventHandler handler = Disposed;
				if (handler != null)
					handler(this, EventArgs.Empty);
			}
		}
		
		#endregion
				
		#region IEntityKey<UserGroupKey> Members
		
		// member variable for the EntityId property
		private UserGroupKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual UserGroupKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new UserGroupKey(this);
				}

				return _entityId;
			}
			set
			{
				if ( value != null )
				{
					value.Entity = this;
				}
				
				_entityId = value;
			}
		}
		
		#endregion
		
		#region EntityState
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false) , XmlIgnoreAttribute()]
		public override EntityState EntityState 
		{ 
			get{ return entityData.EntityState;	 } 
			set{ entityData.EntityState = value; } 
		}
		#endregion 
		
		#region EntityTrackingKey
		///<summary>
		/// Provides the tracking key for the <see cref="EntityLocator"/>
		///</summary>
		[XmlIgnore]
		public override string EntityTrackingKey
		{
			get
			{
				if(entityTrackingKey == null)
					entityTrackingKey = new System.Text.StringBuilder("UserGroup")
					.Append("|").Append( this.AutoId.ToString()).ToString();
				return entityTrackingKey;
			}
			set
		    {
		        if (value != null)
                    entityTrackingKey = value;
		    }
		}
		#endregion 
		
		#region ToString Method
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{4}{3}- GroupId: {0}{3}- UserId: {1}{3}- AutoId: {2}{3}{5}", 
				this.GroupId,
				this.UserId,
				this.AutoId,
				System.Environment.NewLine, 
				this.GetType(),
				this.Error.Length == 0 ? string.Empty : string.Format("- Error: {0}\n",this.Error));
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'UserGroup' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class UserGroupEntityData : ICloneable, ICloneableEx
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
		/// <summary>			
		/// AutoID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "UserGroup"</remarks>
		public System.Int32 AutoId;
			
		#endregion
		
		#region Non Primary key(s)
		
		
		/// <summary>
		/// GroupID : 
		/// </summary>
		public System.String		  GroupId = string.Empty;
		
		/// <summary>
		/// UserID : 
		/// </summary>
		public System.String		  UserId = string.Empty;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
		#endregion Variable Declarations
	
		#region Data Properties

		#endregion Data Properties
		
		#region Clone Method

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public Object Clone()
		{
			UserGroupEntityData _tmp = new UserGroupEntityData();
						
			_tmp.AutoId = this.AutoId;
			
			_tmp.GroupId = this.GroupId;
			_tmp.UserId = this.UserId;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public object Clone(IDictionary existingCopies)
		{
			if (existingCopies == null)
				existingCopies = new Hashtable();
				
			UserGroupEntityData _tmp = new UserGroupEntityData();
						
			_tmp.AutoId = this.AutoId;
			
			_tmp.GroupId = this.GroupId;
			_tmp.UserId = this.UserId;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		#endregion Clone Method
		
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public EntityState	EntityState
		{
			get { return currentEntityState;  }
			set { currentEntityState = value; }
		}
	
	}//End struct











		#endregion
		
				
		
		#region Events trigger
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="UserGroupColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanging(UserGroupColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="UserGroupColumn"/> which has raised the event.</param>
		public virtual void OnColumnChanged(UserGroupColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="UserGroupColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanging(UserGroupColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
				EntityManager.StopTracking(entityTrackingKey);
				
			if (!SuppressEntityEvents)
			{
				UserGroupEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new UserGroupEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="UserGroupColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public virtual void OnColumnChanged(UserGroupColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				UserGroupEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new UserGroupEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region UserGroupEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="UserGroup"/> object.
	/// </remarks>
	public class UserGroupEventArgs : System.EventArgs
	{
		private UserGroupColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the UserGroupEventArgs class.
		///</summary>
		public UserGroupEventArgs(UserGroupColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the UserGroupEventArgs class.
		///</summary>
		public UserGroupEventArgs(UserGroupColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The UserGroupColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="UserGroupColumn" />
		public UserGroupColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all UserGroup related events.
	///</summary>
	public delegate void UserGroupEventHandler(object sender, UserGroupEventArgs e);
	
	#region UserGroupComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class UserGroupComparer : System.Collections.Generic.IComparer<UserGroup>
	{
		UserGroupColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:UserGroupComparer"/> class.
        /// </summary>
		public UserGroupComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:UserGroupComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public UserGroupComparer(UserGroupColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <c cref="UserGroup"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <c cref="UserGroup"/> to compare.</param>
        /// <param name="b">The second <c>UserGroup</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(UserGroup a, UserGroup b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(UserGroup entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(UserGroup a, UserGroup b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public UserGroupColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region UserGroupKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="UserGroup"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class UserGroupKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the UserGroupKey class.
		/// </summary>
		public UserGroupKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the UserGroupKey class.
		/// </summary>
		public UserGroupKey(UserGroupBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.AutoId = entity.AutoId;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the UserGroupKey class.
		/// </summary>
		public UserGroupKey(System.Int32 _autoId)
		{
			#region Init Properties

			this.AutoId = _autoId;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private UserGroupBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public UserGroupBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the AutoId property
		private System.Int32 _autoId;
		
		/// <summary>
		/// Gets or sets the AutoId property.
		/// </summary>
		public System.Int32 AutoId
		{
			get { return _autoId; }
			set
			{
				if ( this.Entity != null )
					this.Entity.AutoId = value;
				
				_autoId = value;
			}
		}
		
		#endregion

		#region Methods
		
		/// <summary>
		/// Reads values from the supplied <see cref="IDictionary"/> object into
		/// properties of the current object.
		/// </summary>
		/// <param name="values">An <see cref="IDictionary"/> instance that contains
		/// the key/value pairs to be used as property values.</param>
		public override void Load(IDictionary values)
		{
			#region Init Properties

			if ( values != null )
			{
				AutoId = ( values["AutoId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["AutoId"], typeof(System.Int32)) : (int)0;
			}

			#endregion
		}

		/// <summary>
		/// Creates a new <see cref="IDictionary"/> object and populates it
		/// with the property values of the current object.
		/// </summary>
		/// <returns>A collection of name/value pairs.</returns>
		public override IDictionary ToDictionary()
		{
			IDictionary values = new Hashtable();

			#region Init Dictionary

			values.Add("AutoId", AutoId);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("AutoId: {0}{1}",
								AutoId,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region UserGroupColumn Enum
	
	/// <summary>
	/// Enumerate the UserGroup columns.
	/// </summary>
	[Serializable]
	public enum UserGroupColumn : int
	{
		/// <summary>
		/// GroupId : 
		/// </summary>
		[EnumTextValue("GroupID")]
		[ColumnEnum("GroupID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		GroupId = 1,
		/// <summary>
		/// UserId : 
		/// </summary>
		[EnumTextValue("UserID")]
		[ColumnEnum("UserID", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		UserId = 2,
		/// <summary>
		/// AutoId : 
		/// </summary>
		[EnumTextValue("AutoID")]
		[ColumnEnum("AutoID", typeof(System.Int32), System.Data.DbType.Int32, true, true, false)]
		AutoId = 3
	}//End enum

	#endregion UserGroupColumn Enum

} // end namespace