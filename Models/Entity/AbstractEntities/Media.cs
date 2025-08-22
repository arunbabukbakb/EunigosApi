namespace EunigosApi.Models.Entity.AbstractEntities
{
    public abstract class Media : AuditInfo
    {
        //public string File { get; set; }

        public string Url { get; set; }

        public string FileName { get; set; }

        public int FileSize { get; set; }

        public string MimeType { get; set; }

        public string AltText { get; set; }

        public string Description { get; set; }
        
    }
}
