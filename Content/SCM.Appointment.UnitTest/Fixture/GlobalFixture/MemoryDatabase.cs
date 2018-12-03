using System;
using System.Collections.Generic;
using System.Text;
using Quantum.FrameworkNetCore.DB.EFEx;
using Quantum.FrameworkNetCore.DB.EFEx.QuantumDbContext;

namespace SCM.UserDefine.UnitTest.Fixture.GlobalFixture
{
    public class MemoryDatabase
    {
        #region 数据库中需要初始化的数据

        //public static readonly VStatementReceipt VStatementReceiptInsert = new VStatementReceipt
        //{
        //    BillingObjectId = "1",
        //    BillingObjectName = "1",
        //    BillingRecStatementId = "1",
        //    BillingStatementReceiptId = "1"
        //};

        #endregion 数据库中需要初始化的数据

        public static void Init()
        {
            // 不需要数据库
        }

        //private static void InsertStatement(IQuantumEFDbContext dbCtx)
        //{
        //    var vCrudRepository = dbCtx.GetRepository<VStatementReceipt>();
        //    vCrudRepository.Insert(VStatementReceiptInsert);
        //}

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}