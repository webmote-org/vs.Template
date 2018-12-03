using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using Quantum.FrameworkNetCore.Cache;
using Quantum.FrameworkNetCore.Extensions.Enum;
using Quantum.FrameworkNetCore.Protocol.RpcProtocol;
using Quantum.FrameworkNetCore.Rpc.Server;
using SCM.RpcProxy;

namespace SCM.Appointment.Service
{
    [InitlizeMethod]
    public class GlobalInit
    {
        /// <summary>
        /// 初始化资源
        /// </summary>
        [InitlizeMethod]
        public static void LoadResource()
        {
            MyAutoMapper.Init();
            //SCMUUIDSRpcProxyManager.Initlize();
            //SCMConfigrationServiceRpcProxyManager.Initlize();
        }
    }
}
