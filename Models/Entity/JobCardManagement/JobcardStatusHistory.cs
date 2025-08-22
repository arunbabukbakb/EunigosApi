using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Models.Enum;
namespace EunigosApi.Models.Entity.JobCardManagement
{
	public class JobcardStatusHistory
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public string JobcardId { get; set; }

		public virtual JobCard JobCard { get; set; }

		public string Reason { get; set; }
		public string Remarks { get; set; }
		public DateTime? SubmitDate { get; set; }

		// Document metadata
		public string DocumentName { get; set; }
		public string DocumentType { get; set; }
		public string FilePath { get; set; }

		public JobcardHistoryStatus Status { get; set; }

		public string RequestedUserId { get; set; }
		public virtual User RequestedUser { get; set; }


		public DateTime RequestedDate { get; set; }

		public string ApprovedPersonId { get; set; }
		public virtual User ApprovedPerson { get; set; }
		public DateTime? ApprovedDatetime { get; set; }

		// History type (totalloss, jobadjusted, canceljobcard)

		public string HistoryType { get; set; }
	}
}
