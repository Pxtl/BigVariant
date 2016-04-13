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
    public class SqlVariantBigVariant : SqlDatabaseTestClass
    {

        public SqlVariantBigVariant()
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
        public void DateTimeIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.DateTimeIntoBigVariantData;
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
        public void DateTime2IntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.DateTime2IntoBigVariantData;
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
        [TestMethod()]
        public void DateTimeOffsetIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.DateTimeOffsetIntoBigVariantData;
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DateTimeIntoBigVariant_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlVariantBigVariant));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DateTime2IntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DateTimeOffsetIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition3;
            this.DateTimeIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DateTime2IntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DateTimeOffsetIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            DateTimeIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            DateTime2IntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            DateTimeOffsetIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            // 
            // DateTimeIntoBigVariantData
            // 
            this.DateTimeIntoBigVariantData.PosttestAction = null;
            this.DateTimeIntoBigVariantData.PretestAction = null;
            this.DateTimeIntoBigVariantData.TestAction = DateTimeIntoBigVariant_TestAction;
            // 
            // DateTimeIntoBigVariant_TestAction
            // 
            DateTimeIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            resources.ApplyResources(DateTimeIntoBigVariant_TestAction, "DateTimeIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
            // 
            // DateTime2IntoBigVariantData
            // 
            this.DateTime2IntoBigVariantData.PosttestAction = null;
            this.DateTime2IntoBigVariantData.PretestAction = null;
            this.DateTime2IntoBigVariantData.TestAction = DateTime2IntoBigVariant_TestAction;
            // 
            // DateTime2IntoBigVariant_TestAction
            // 
            DateTime2IntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition2);
            resources.ApplyResources(DateTime2IntoBigVariant_TestAction, "DateTime2IntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition2
            // 
            notEmptyResultSetCondition2.Enabled = true;
            notEmptyResultSetCondition2.Name = "notEmptyResultSetCondition2";
            notEmptyResultSetCondition2.ResultSet = 1;
            // 
            // DateTimeOffsetIntoBigVariantData
            // 
            this.DateTimeOffsetIntoBigVariantData.PosttestAction = null;
            this.DateTimeOffsetIntoBigVariantData.PretestAction = null;
            this.DateTimeOffsetIntoBigVariantData.TestAction = DateTimeOffsetIntoBigVariant_TestAction;
            // 
            // DateTimeOffsetIntoBigVariant_TestAction
            // 
            DateTimeOffsetIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition3);
            resources.ApplyResources(DateTimeOffsetIntoBigVariant_TestAction, "DateTimeOffsetIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition3
            // 
            notEmptyResultSetCondition3.Enabled = true;
            notEmptyResultSetCondition3.Name = "notEmptyResultSetCondition3";
            notEmptyResultSetCondition3.ResultSet = 1;
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

        private SqlDatabaseTestActions DateTimeIntoBigVariantData;
        private SqlDatabaseTestActions DateTime2IntoBigVariantData;
        private SqlDatabaseTestActions DateTimeOffsetIntoBigVariantData;
    }
}
