using BookWiseApp.Database.DAO;
using BookWiseApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database
{
    public class DbService
    {
        private bool isChecking = true;
        private Thread thread;

        public DbService()
        {
            thread = new Thread(DoChecking);
            thread.Start();
        }

        public void StopChecking()
        {
            isChecking = false;
        }

        private void DoChecking()
        {
            while (isChecking)
            {
                Thread.Sleep(5000);
                List<Scan> scans = new ScanDAO().GetAll().ToList();
                
                if (scans.Count > 0){
                    foreach (Scan scan in scans)
                    {
                        // Show new view with book details
                    }
                }
            }
        }
    }
}
