/*----------------------------------------------------------------
 Copyright (C) 2015 上海科箭软件科技有限公司版权所有

 项目名称：SCM.Appointment.Service
 创建者：  mark(by template)
 时间：    2018/09/13 
----------------------------------------------------------------*/
using System;
using System.Threading;
using Quantum.FrameworkNetCore.Rpc;

namespace SCM.Appointment.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start ...");
            ServerProxy.Register(typeof(Program).Namespace);
            System.Threading.Thread.Sleep(Timeout.Infinite);
            Console.WriteLine("End ...");
        }
    }
}
