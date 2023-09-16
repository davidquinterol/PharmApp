namespace Pharmapp.Properties
{
    internal class NegocioInventario : INegocioInventario
    {
        public NegocioInventario(IReposInventario repositorioInventario)
        {
            RepositorioInventario = repositorioInventario;
        }

        public IReposInventario RepositorioInventario { get; }
    }
}