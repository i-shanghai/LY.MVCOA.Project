using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using LY.MVCOA.IBLL;
using LY.MVCOA.BLL;
using LY.MVCOA.IDAL;
using LY.MVCOA.DAL;

namespace LY.MVCOA.Core
{
    public class DependencyRegisterType
    {
        public static void Container_Sys(ref UnityContainer container) {

            container.RegisterType<ISysSampleBLL, SysSampleBLL>();//样例
            container.RegisterType<ISysSampleRepository, SysSampleRepository>();
        }

    }
}
