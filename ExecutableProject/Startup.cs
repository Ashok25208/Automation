using System;
using System.Collections.Generic;
using System.Linq;
using LoginTestModule;



namespace ExecutableProject
{
    public partial class Startup
    {
        public void Configuration()
        {
            LoginTest Exe = new LoginTest();
                Exe.Login();
        }
    }
}
