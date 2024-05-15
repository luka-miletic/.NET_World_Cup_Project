namespace DataAccessLayer.Repository
{
    public static class RepositoryFactory
    {
        private static IRepository repo;

        public static IRepository GetRepository()
        {
            if(repo != null)
            {
                return repo;
            }

            repo = new Repository();

            return repo;
        }
    }
}
