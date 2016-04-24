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
        [TestMethod()]
        public void TinyIntIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.TinyIntIntoBigVariantData;
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
        public void SmallIntIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.SmallIntIntoBigVariantData;
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
        public void IntIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.IntIntoBigVariantData;
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
        public void BigIntIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.BigIntIntoBigVariantData;
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
        public void BitIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.BitIntoBigVariantData;
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
        public void FloatIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.FloatIntoBigVariantData;
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
        public void DoubleIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.DoubleIntoBigVariantData;
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
        public void CompareAllNumericTypes()
        {
            SqlDatabaseTestActions testActions = this.CompareAllNumericTypesData;
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
        public void DecimalIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.DecimalIntoBigVariantData;
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
        public void MoneyIntoBigVariant()
        {
            SqlDatabaseTestActions testActions = this.MoneyIntoBigVariantData;
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DateTimeOffsetIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction TinyIntIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SmallIntIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction IntIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction BigIntIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction BitIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction FloatIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DoubleIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CompareAllNumericTypes_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DecimalIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction MoneyIntoBigVariant_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition10;
            this.DateTimeIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DateTimeOffsetIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.TinyIntIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.SmallIntIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.IntIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.BigIntIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.BitIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.FloatIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DoubleIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.CompareAllNumericTypesData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DecimalIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.MoneyIntoBigVariantData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            DateTimeIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            DateTimeOffsetIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            TinyIntIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            SmallIntIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            IntIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            BigIntIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            BitIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            FloatIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DoubleIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            notEmptyResultSetCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            CompareAllNumericTypes_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DecimalIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            notEmptyResultSetCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            MoneyIntoBigVariant_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
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
            // 
            // DateTimeIntoBigVariantData
            // 
            this.DateTimeIntoBigVariantData.PosttestAction = null;
            this.DateTimeIntoBigVariantData.PretestAction = null;
            this.DateTimeIntoBigVariantData.TestAction = DateTimeIntoBigVariant_TestAction;
            // 
            // DateTimeOffsetIntoBigVariantData
            // 
            this.DateTimeOffsetIntoBigVariantData.PosttestAction = null;
            this.DateTimeOffsetIntoBigVariantData.PretestAction = null;
            this.DateTimeOffsetIntoBigVariantData.TestAction = DateTimeOffsetIntoBigVariant_TestAction;
            // 
            // TinyIntIntoBigVariantData
            // 
            this.TinyIntIntoBigVariantData.PosttestAction = null;
            this.TinyIntIntoBigVariantData.PretestAction = null;
            this.TinyIntIntoBigVariantData.TestAction = TinyIntIntoBigVariant_TestAction;
            // 
            // TinyIntIntoBigVariant_TestAction
            // 
            TinyIntIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition2);
            resources.ApplyResources(TinyIntIntoBigVariant_TestAction, "TinyIntIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition2
            // 
            notEmptyResultSetCondition2.Enabled = true;
            notEmptyResultSetCondition2.Name = "notEmptyResultSetCondition2";
            notEmptyResultSetCondition2.ResultSet = 1;
            // 
            // SmallIntIntoBigVariantData
            // 
            this.SmallIntIntoBigVariantData.PosttestAction = null;
            this.SmallIntIntoBigVariantData.PretestAction = null;
            this.SmallIntIntoBigVariantData.TestAction = SmallIntIntoBigVariant_TestAction;
            // 
            // SmallIntIntoBigVariant_TestAction
            // 
            resources.ApplyResources(SmallIntIntoBigVariant_TestAction, "SmallIntIntoBigVariant_TestAction");
            // 
            // IntIntoBigVariantData
            // 
            this.IntIntoBigVariantData.PosttestAction = null;
            this.IntIntoBigVariantData.PretestAction = null;
            this.IntIntoBigVariantData.TestAction = IntIntoBigVariant_TestAction;
            // 
            // IntIntoBigVariant_TestAction
            // 
            IntIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition4);
            resources.ApplyResources(IntIntoBigVariant_TestAction, "IntIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition4
            // 
            notEmptyResultSetCondition4.Enabled = true;
            notEmptyResultSetCondition4.Name = "notEmptyResultSetCondition4";
            notEmptyResultSetCondition4.ResultSet = 1;
            // 
            // BigIntIntoBigVariantData
            // 
            this.BigIntIntoBigVariantData.PosttestAction = null;
            this.BigIntIntoBigVariantData.PretestAction = null;
            this.BigIntIntoBigVariantData.TestAction = BigIntIntoBigVariant_TestAction;
            // 
            // BigIntIntoBigVariant_TestAction
            // 
            resources.ApplyResources(BigIntIntoBigVariant_TestAction, "BigIntIntoBigVariant_TestAction");
            // 
            // BitIntoBigVariantData
            // 
            this.BitIntoBigVariantData.PosttestAction = null;
            this.BitIntoBigVariantData.PretestAction = null;
            this.BitIntoBigVariantData.TestAction = BitIntoBigVariant_TestAction;
            // 
            // BitIntoBigVariant_TestAction
            // 
            BitIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition5);
            resources.ApplyResources(BitIntoBigVariant_TestAction, "BitIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition5
            // 
            notEmptyResultSetCondition5.Enabled = true;
            notEmptyResultSetCondition5.Name = "notEmptyResultSetCondition5";
            notEmptyResultSetCondition5.ResultSet = 1;
            // 
            // FloatIntoBigVariantData
            // 
            this.FloatIntoBigVariantData.PosttestAction = null;
            this.FloatIntoBigVariantData.PretestAction = null;
            this.FloatIntoBigVariantData.TestAction = FloatIntoBigVariant_TestAction;
            // 
            // FloatIntoBigVariant_TestAction
            // 
            FloatIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition6);
            resources.ApplyResources(FloatIntoBigVariant_TestAction, "FloatIntoBigVariant_TestAction");
            // 
            // DoubleIntoBigVariantData
            // 
            this.DoubleIntoBigVariantData.PosttestAction = null;
            this.DoubleIntoBigVariantData.PretestAction = null;
            this.DoubleIntoBigVariantData.TestAction = DoubleIntoBigVariant_TestAction;
            // 
            // DoubleIntoBigVariant_TestAction
            // 
            DoubleIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition7);
            resources.ApplyResources(DoubleIntoBigVariant_TestAction, "DoubleIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition6
            // 
            notEmptyResultSetCondition6.Enabled = true;
            notEmptyResultSetCondition6.Name = "notEmptyResultSetCondition6";
            notEmptyResultSetCondition6.ResultSet = 1;
            // 
            // notEmptyResultSetCondition7
            // 
            notEmptyResultSetCondition7.Enabled = true;
            notEmptyResultSetCondition7.Name = "notEmptyResultSetCondition7";
            notEmptyResultSetCondition7.ResultSet = 1;
            // 
            // CompareAllNumericTypesData
            // 
            this.CompareAllNumericTypesData.PosttestAction = null;
            this.CompareAllNumericTypesData.PretestAction = null;
            this.CompareAllNumericTypesData.TestAction = CompareAllNumericTypes_TestAction;
            // 
            // CompareAllNumericTypes_TestAction
            // 
            CompareAllNumericTypes_TestAction.Conditions.Add(notEmptyResultSetCondition9);
            resources.ApplyResources(CompareAllNumericTypes_TestAction, "CompareAllNumericTypes_TestAction");
            // 
            // DecimalIntoBigVariantData
            // 
            this.DecimalIntoBigVariantData.PosttestAction = null;
            this.DecimalIntoBigVariantData.PretestAction = null;
            this.DecimalIntoBigVariantData.TestAction = DecimalIntoBigVariant_TestAction;
            // 
            // DecimalIntoBigVariant_TestAction
            // 
            DecimalIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition8);
            resources.ApplyResources(DecimalIntoBigVariant_TestAction, "DecimalIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition8
            // 
            notEmptyResultSetCondition8.Enabled = true;
            notEmptyResultSetCondition8.Name = "notEmptyResultSetCondition8";
            notEmptyResultSetCondition8.ResultSet = 1;
            // 
            // notEmptyResultSetCondition9
            // 
            notEmptyResultSetCondition9.Enabled = true;
            notEmptyResultSetCondition9.Name = "notEmptyResultSetCondition9";
            notEmptyResultSetCondition9.ResultSet = 1;
            // 
            // MoneyIntoBigVariantData
            // 
            this.MoneyIntoBigVariantData.PosttestAction = null;
            this.MoneyIntoBigVariantData.PretestAction = null;
            this.MoneyIntoBigVariantData.TestAction = MoneyIntoBigVariant_TestAction;
            // 
            // MoneyIntoBigVariant_TestAction
            // 
            MoneyIntoBigVariant_TestAction.Conditions.Add(notEmptyResultSetCondition10);
            resources.ApplyResources(MoneyIntoBigVariant_TestAction, "MoneyIntoBigVariant_TestAction");
            // 
            // notEmptyResultSetCondition10
            // 
            notEmptyResultSetCondition10.Enabled = true;
            notEmptyResultSetCondition10.Name = "notEmptyResultSetCondition10";
            notEmptyResultSetCondition10.ResultSet = 1;
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
        private SqlDatabaseTestActions DateTimeOffsetIntoBigVariantData;
        private SqlDatabaseTestActions TinyIntIntoBigVariantData;
        private SqlDatabaseTestActions SmallIntIntoBigVariantData;
        private SqlDatabaseTestActions IntIntoBigVariantData;
        private SqlDatabaseTestActions BigIntIntoBigVariantData;
        private SqlDatabaseTestActions BitIntoBigVariantData;
        private SqlDatabaseTestActions FloatIntoBigVariantData;
        private SqlDatabaseTestActions DoubleIntoBigVariantData;
        private SqlDatabaseTestActions CompareAllNumericTypesData;
        private SqlDatabaseTestActions DecimalIntoBigVariantData;
        private SqlDatabaseTestActions MoneyIntoBigVariantData;
    }
}
