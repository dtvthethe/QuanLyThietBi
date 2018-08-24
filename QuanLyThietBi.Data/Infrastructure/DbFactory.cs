namespace QuanLyThietBi.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private QuanLyThietBiDbContext dbContext;

        public QuanLyThietBiDbContext Init()
        {
            return dbContext ?? (dbContext = new QuanLyThietBiDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}