using System;
using System.Collections.Generic;
using System.Text;
using Quantum.FrameworkNetCore.AttributeEx;

namespace SCM.Appointment.Service
{
    /// <summary>
    /// 接口返回的错误代码定义
    /// from xxx~xxxxx
    /// </summary>
    [ErrorCode]
    public enum MyErrorCode
    {
        /// <summary>
        /// 参数非法
        /// </summary>
        //[CodeDesc("参数非法")]
        //ParamInValid = 100001,
    }
}
