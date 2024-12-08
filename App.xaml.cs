using BeautySalon.DataBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BeautySalon
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static BeautySalonEntities _context;

        public static BeautySalonEntities GetContext()
        {
            if (_context == null) 
                _context = new BeautySalonEntities();
            return _context;
        }
    }
}
