namespace EunigosApi.Models.Dto
{
	public class JobCardDocumentDto
	{
		public string JobcardId { get; set; }
		public string DocumentName { get; set; }
		public string DocumentType { get; set; }
		public string FilePath { get; set; }
		public string? Notes { get; set; }
	}
}
