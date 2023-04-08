﻿using System;
namespace PurpleBuzz.Models
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public bool SoftDelete { get; set; } = false;
	}
}