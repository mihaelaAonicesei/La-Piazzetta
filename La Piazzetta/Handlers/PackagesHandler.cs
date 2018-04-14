using La_Piazzetta.Managers;
using La_Piazzetta.ViewModels;

namespace La_Piazzetta.Handlers
{
    public class PackagesHandler
    {
        private static PackagesHandler instance;
        private static readonly object padlock = new object();
        private readonly PackagesManager packagesManager;

        public static PackagesHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null) instance = new PackagesHandler();

                    return instance;
                }
            }
        }

        public PackagesHandler()
        {
            packagesManager = new PackagesManager();
        }

        public AllPackagesViewModel GetAll()
        {
            var models = packagesManager.GetAll();
            return new AllPackagesViewModel
            {
                Packages = models
            };
        }
    }
}