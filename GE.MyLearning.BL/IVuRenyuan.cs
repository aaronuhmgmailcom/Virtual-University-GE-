﻿using System;
using System.ComponentModel;

namespace GE.MyLearning.BL
{
	/// <summary>
	///		The data structure representation of the 'VU_renyuan' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IVuRenyuan 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "VU_renyuan"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// xingming : 
		/// </summary>
		System.String  Xingming  { get; set; }
		
		/// <summary>
		/// mima : 
		/// </summary>
		System.String  Mima  { get; set; }
		
		/// <summary>
		/// quanxian : 
		/// </summary>
		System.String  Quanxian  { get; set; }
		
		/// <summary>
		/// username : 
		/// </summary>
		System.String  Username  { get; set; }
		
		/// <summary>
		/// email : 
		/// </summary>
		System.String  Email  { get; set; }
		
		/// <summary>
		/// closed : 
		/// </summary>
		System.Int32?  Closed  { get; set; }
		
		/// <summary>
		/// headpic : 
		/// </summary>
		System.String  Headpic  { get; set; }
		
		/// <summary>
		/// nicename : 
		/// </summary>
		System.String  Nicename  { get; set; }
		
		/// <summary>
		/// bbsscore : 
		/// </summary>
		System.Decimal?  Bbsscore  { get; set; }
		
		/// <summary>
		/// tel : 
		/// </summary>
		System.String  Tel  { get; set; }
		
		/// <summary>
		/// title : 
		/// </summary>
		System.String  Title  { get; set; }
		
		/// <summary>
		/// team : 
		/// </summary>
		System.String  Team  { get; set; }
		
		/// <summary>
		/// team1 : 
		/// </summary>
		System.String  Team1  { get; set; }
		
		/// <summary>
		/// ClassID : 
		/// </summary>
		System.String  ClassId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


