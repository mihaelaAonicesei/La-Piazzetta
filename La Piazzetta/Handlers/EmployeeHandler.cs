using La_Piazzetta.Managers;
using La_Piazzetta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace La_Piazzetta.Handlers
{
    public class EmployeeHandler
    {
        private static EmployeeHandler instance = null;
        private static readonly object padlock = new object();
        private readonly EmployeeManager manager;

        public static EmployeeHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeHandler();
                    }

                    return instance;
                }
            }
        }

        public EmployeeHandler()
        {
            manager = new EmployeeManager();
        }

        public List<Employee> GetAll()
        {
            return manager.GetAll();
        }
    }
}