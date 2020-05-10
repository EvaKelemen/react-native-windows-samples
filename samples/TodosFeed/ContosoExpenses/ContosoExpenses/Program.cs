using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoExpenses
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new Uwp.App())
            {
                App app = new App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
