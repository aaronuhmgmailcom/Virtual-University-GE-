﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'UserGroup' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IUserGroup 
	{
		/// <summary>			
		/// AutoID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "UserGroup"</remarks>
		System.Int32 AutoId { get; set; }
				
		
		
		/// <summary>
		/// GroupID : 
		/// </summary>
		System.String  GroupId  { get; set; }
		
		/// <summary>
		/// UserID : 
		/// </summary>
		System.String  UserId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

