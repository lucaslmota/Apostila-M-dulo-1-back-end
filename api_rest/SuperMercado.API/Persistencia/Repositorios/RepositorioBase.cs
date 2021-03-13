namespace api_rest.Persistencia.Repositorios
{
    public abstract class RepositorioBase
    {
        protected readonly AppDbContext _context;

        public RepositorioBase(AppDbContext context){
            _context = context;
        }
    }
}