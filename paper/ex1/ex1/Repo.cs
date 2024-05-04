namespace ex1
{
    public class Repo
    {
        private DbContext _dbContext;

        public Repo(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
