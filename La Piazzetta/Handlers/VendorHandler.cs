using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using La_Piazzetta.Managers;
using La_Piazzetta.Models;
using La_Piazzetta.ViewModels;

namespace La_Piazzetta.Handlers
{
    public class VendorHandler
    {
        private static VendorHandler instance;
        private static readonly object padlock = new object();
        private readonly VendorManager vendorManager;

        public static VendorHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null) instance = new VendorHandler();

                    return instance;
                }
            }
        }

        public VendorHandler()
        {
            vendorManager = new VendorManager();
        }

        public List<Vendors> GetAll()
        {
            return vendorManager.GetAll().ToList();
        }

        public async Task Add(Vendors newVendor)
        {
            await vendorManager.Add(newVendor);
        }
    }
}