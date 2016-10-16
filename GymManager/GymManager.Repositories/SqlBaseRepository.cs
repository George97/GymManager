namespace GymManager.Repositories
{
    public abstract class SqlBaseRepository
        {
            protected string ConnectionString { get; }

            protected SqlBaseRepository(string connection)
            {
                ConnectionString = connection;
            }
        }
}
