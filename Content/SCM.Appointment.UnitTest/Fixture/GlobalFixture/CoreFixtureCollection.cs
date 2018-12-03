using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SCM.UserDefine.UnitTest.Fixture.GlobalFixture
{
    /// <summary>
    /// 全局初始化
    /// </summary>
    [CollectionDefinition("CoreFixture")]
    public class CoreFixtureCollection : ICollectionFixture<CoreFixture>
    {
    }
}