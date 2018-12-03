using System;
using System.Collections.Generic;
using System.Text;
using Quantum.FrameworkNetCore.Cache;
using Quantum.FrameworkNetCore.JsonEx;
using Quantum.FrameworkNetCore.Protocol.RpcProtocol;
using Quantum.FrameworkNetCore.UnitTest;
using Xunit;
using Xunit.Abstractions;

namespace SCM.Appointment.UnitTest
{
    [Collection("CoreFixture")]
    public class LocalResourceTest : BaseTest
    {
        /// <inheritdoc />
        public LocalResourceTest(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestClearResource()
        {
           
        }
    }
}