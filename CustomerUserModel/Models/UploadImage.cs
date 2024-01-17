using Microsoft.Extensions.FileProviders;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace CustomerUserModel.Models
{
	public class UploadImage
	{
		public int Id { get; set; }
		[Required]
		public string? FileName { get; set; }

		[Required]
		[Column(TypeName = "varbinary(max)")]
		public byte[]? ImageData { get; set; }

	}
}