namespace EntityOracleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleDbContext context = new OracleDbContext();
            context.User.Add(new User
            {
                Name = "Tufan",
                Surname = "Dayı"
            });

            context.SaveChanges();
        }
    }
}
