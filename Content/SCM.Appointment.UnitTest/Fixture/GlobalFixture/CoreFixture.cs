using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Quantum.FrameworkNetCore.Config;
using Quantum.FrameworkNetCore.UnitTest;
using Quantum.FrameworkNetCore.Rpc.AssemblyTools;
using Xunit.Abstractions;

namespace SCM.UserDefine.UnitTest.Fixture.GlobalFixture
{
    /// <summary>
    /// 全局初始化
    /// </summary>
    public class CoreFixture : IDisposable
    {
        public CoreFixture()
        {
            var servicedll = "SCM.Appointment.Service.dll";
            // 初始化AppName
            var theAssembly = Assembly.LoadFile(System.AppDomain.CurrentDomain.BaseDirectory + servicedll);
            var appName = AssemblyToolProxy.GetCurrentAppName(theAssembly);
            ServerSetting.SetAppNameForTest(appName);
            //初始化缓存和登录信息
            InitLoginUserAndCache.Init(servicedll);
            // 初始化DataBase
            MemoryDatabase.Init();
            ServerSetting.Initlize("TestServer", 0);
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}