using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFPractice.Models
{
	[DataContract(Name = "Movie")]
	public class Movies
	{
		public int Id { get; set; }
		public string MovieName { get; set; }
	}
}