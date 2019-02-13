using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    interface ITempSensor
    {
        int GetTemp();

        bool RunSelfTest();

    }
}
