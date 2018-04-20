using La_Piazzetta.Managers;
using La_Piazzetta.ViewModels.Charts;
using System.Collections.Generic;
using System.Linq;

namespace La_Piazzetta.Handlers
{
    public class BAHandler
    {
        private static BAHandler instance = null;
        private static readonly object padlock = new object();
        private readonly BAManager baManager;

        public static BAHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new BAHandler();
                    }

                    return instance;
                }
            }
        }

        public BAHandler()
        {
            baManager = new BAManager();
        }

        public List<ChartProductItem> GetTop5Items()
        {
            return baManager.GetTop5Items().ToList();
        }
    }
}