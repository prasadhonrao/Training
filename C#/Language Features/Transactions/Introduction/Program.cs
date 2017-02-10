using System;
using System.Data.SqlClient;
using System.Messaging;
using System.Transactions;
using System.Configuration;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Without Any Transaction

            //try
            //{
            //    FirstUpdateToDb();
            //    SecondUpdateToDb();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("EXCEPTION : {0}", ex.Message);
            //}

            #endregion

            #region With Transaction

            //try
            //{
            //    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
            //    {
            //        Console.WriteLine("Isolation level = {0}", Transaction.Current.IsolationLevel);
            //        FirstUpdateToDb();
            //        ThrowExceptionInMethod();
            //        SecondUpdateToDb();
            //        scope.Complete();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("EXCEPTION : {0}", ex.Message);
            //}

            #endregion

            #region With MSMQ which does not support promotion

            // MSMQ always use DTC
            using (var scope = new TransactionScope())
            {
                UpdateMSMQ();
                scope.Complete();
            }
            #endregion

            Console.WriteLine("Press [Enter] to quit.");
            Console.ReadLine();
        }

        private static void ThrowExceptionInMethod()
        {
            throw new ApplicationException("This is a custom exception");
        }

        public static void FirstUpdateToDb()
        {
            var conn = new SqlConnection(ConfigurationManager.AppSettings["connection"].ToString());
            var query = @"Insert into Temp Values('Transaction Test 1')";
            var cmd = new SqlCommand(query,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void SecondUpdateToDb()
        {
            var conn = new SqlConnection(ConfigurationManager.AppSettings["connection"].ToString());
            var query = @"Insert into Temp Values('Transaction Test 2')";
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateMSMQ()
        {
            var queue = new MessageQueue(@".\private$\trainings");
            queue.Send("Test", "Test", MessageQueueTransactionType.Automatic);
        }
    }
}
