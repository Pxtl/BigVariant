using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PxtlCa.BigVariant.Test
{
    [TestClass()]
    public class SqlStringBigVariant : SqlDatabaseTestClass
    {

        public SqlStringBigVariant()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void SmallSqlStringIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.SmallSqlStringIntoBigVariantData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void LargeSqlStringIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.LargeSqlStringIntoBigVariantData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }


        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SmallSqlStringIntoBigVariant_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlStringBigVariant));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction LargeSqlStringIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition2;
            this.SmallSqlStringIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.LargeSqlStringIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            SmallSqlStringIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            LargeSqlStringIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            notEmptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            // 
            // SmallSqlStringIntoBigVariant_TestAction
            // 
            SmallSqlStringIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            resources.ApplyResources(SmallSqlStringIntoBigVariant_TestAction, "SmallSqlStringIntoBigVariant_TestAction");
            // 
            // SmallSqlStringIntoBigVariantData
            // 
            this.SmallSqlStringIntoBigVariantData.PosttestAction = null;
            this.SmallSqlStringIntoBigVariantData.PretestAction = null;
            this.SmallSqlStringIntoBigVariantData.TestAction = SmallSqlStringIntoBigVariant_TestAction;
            // 
            // LargeSqlStringIntoBigVariantData
            // 
            this.LargeSqlStringIntoBigVariantData.PosttestAction = null;
            this.LargeSqlStringIntoBigVariantData.PretestAction = null;
            this.LargeSqlStringIntoBigVariantData.TestAction = LargeSqlStringIntoBigVariant_TestAction;
            // 
            // LargeSqlStringIntoBigVariant_TestAction
            // 
            LargeSqlStringIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition2);
            resources.ApplyResources(LargeSqlStringIntoBigVariant_TestAction, "LargeSqlStringIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
            // 
            // notEmptyResultSetCondition2
            // 
            notEmptyResultSetCondition2.Enabled = true;
            notEmptyResultSetCondition2.Name = "notEmptyResultSetCondition2";
            notEmptyResultSetCondition2.ResultSet = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private SqlDatabaseTestActions SmallSqlStringIntoBigVariantData;
        private SqlDatabaseTestActions LargeSqlStringIntoBigVariantData;
    }
}
