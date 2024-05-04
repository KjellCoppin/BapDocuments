namespace ex1
{
    public class DbContext
    {
        private static readonly Lazy<DbContext> _lazyInstance = new Lazy<DbContext>(() => new DbContext());

        public DbContext Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }
    }
}
