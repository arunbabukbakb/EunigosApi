using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EunigosApi.Models.Entity.JobCardManagement
{
	public class JobcardDocument
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Id { get; set; } = Guid.NewGuid().ToString();
		public string JobcardId { get; set; }
		public virtual JobCard JobCard { get; set; }
		public string DocumentName { get; set; }
		public string DocumentType { get; set; }
		public string FilePath { get; set; }
		public string Notes { get; set; }
	}
}
