using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class CoreClass
        {
            interface ICoreService
            {
                ICoreService GetCoreService { get; }

                ICoreService CoreService { get; set; }
            }

            class CoreServiceClass : ICoreService
            {
                ICoreService _coreService;

                public ICoreService GetCoreService
                {
                    get
                    {
                        return _coreService;
                    }
                }

                public ICoreService CoreService
                {
                    get
                    {
                        return _coreService;
                    }
                    set
                    {
                        _coreService = value;
                    }
                }
            }
        }
    }
}
