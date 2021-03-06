﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'Degrees' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IDegrees 
	{
		/// <summary>			
		/// DegreeId : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Degrees"</remarks>
		System.Int32 DegreeId { get; set; }
				
		
		
		/// <summary>
		/// DegreeName : 
		/// </summary>
		System.String  DegreeName  { get; set; }
		
		/// <summary>
		/// InstituteId : 
		/// </summary>
		System.String  InstituteId  { get; set; }
		
		/// <summary>
		/// Description : 
		/// </summary>
		System.String  Description  { get; set; }
		
		/// <summary>
		/// Credithour : 
		/// </summary>
		System.Int32?  Credithour  { get; set; }
		
		/// <summary>
		/// Createtime : 
		/// </summary>
		System.DateTime?  Createtime  { get; set; }
		
		/// <summary>
		/// CreateUserId : 
		/// </summary>
		System.String  CreateUserId  { get; set; }
		
		/// <summary>
		/// Status : 
		/// </summary>
		System.Int32?  Status  { get; set; }
		
		/// <summary>
		/// ToApply : 
		/// </summary>
		System.Int32?  ToApply  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


