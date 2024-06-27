namespace JobPortalAPI.Data.Module
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Mobile { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public int IsDeleted {  get; set; }

        public int CreatedBy { get; set; }

        public int CreatedOn { get; set;}

        public int UpdatedBy { get; set;}

        public int UpdatedOn { get; set;}
    }
}
