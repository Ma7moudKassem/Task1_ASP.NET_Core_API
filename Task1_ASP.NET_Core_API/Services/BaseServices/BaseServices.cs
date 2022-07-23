namespace Task1_ASP.NET_Core_API.Services.BaseServices
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : BaseEntity
    {
        protected DbSet<TEntity> dbSet;

        private readonly ApplicationDbContext _context;
        public BaseServices(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll() => await dbSet.ToListAsync();
        public async Task<TEntity> GetById(int id) =>await dbSet.SingleOrDefaultAsync(e => e.Id == id);

        public async Task<TEntity> Add(TEntity entity)
        {
           await dbSet.AddAsync(entity);
            _context.SaveChanges();
            return entity;
            
        }       

        //public async Task<Prospect> AddNew(Prospect prospect)
        //{
        //    await _context.Prospects.AddAsync(prospect);
        //    _context.SaveChanges();
        //    return prospect;
            
        //}

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
            _context.SaveChanges();
        }

    }
}
