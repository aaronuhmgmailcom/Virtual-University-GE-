﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'SysLog' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISysLog 
	{
		/// <summary>			
		/// LogId : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SysLog"</remarks>
		System.Int32 LogId { get; set; }
				
		
		
		/// <summary>
		/// LogClass : 
		/// </summary>
		System.String  LogClass  { get; set; }
		
		/// <summary>
		/// LogDescribe : 
		/// </summary>
		System.String  LogDescribe  { get; set; }
		
		/// <summary>
		/// UserID : 
		/// </summary>
		System.String  UserId  { get; set; }
		
		/// <summary>
		/// LogDate : 
		/// </summary>
		System.DateTime?  LogDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


