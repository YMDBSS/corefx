// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// TODO[tinchou]: check override methods and System.Transactions usage

using System.Data.Common;
using System.Data.ProviderBase;

namespace System.Data.Odbc
{
    sealed internal class OdbcConnectionOpen : DbConnectionInternal
    {
        // Construct from a compiled connection string
        internal OdbcConnectionOpen(OdbcConnection outerConnection, OdbcConnectionString connectionOptions)
        {
#if DEBUG
            try
            { // use this to help validate this object is only created after the following permission has been previously demanded in the current codepath
                if (null != outerConnection)
                {
                    outerConnection.UserConnectionOptions.DemandPermission();
                }
                else
                {
                    connectionOptions.DemandPermission();
                }
            }
            catch (System.Security.SecurityException)
            {
                System.Diagnostics.Debug.Assert(false, "unexpected SecurityException for current codepath");
                throw;
            }
#endif
            OdbcEnvironmentHandle environmentHandle = OdbcEnvironment.GetGlobalEnvironmentHandle();
            outerConnection.ConnectionHandle = new OdbcConnectionHandle(outerConnection, connectionOptions, environmentHandle);
        }

        internal OdbcConnection OuterConnection
        {
            get
            {
                OdbcConnection outerConnection = (OdbcConnection)Owner;

                if (null == outerConnection)
                    throw ODBC.OpenConnectionNoOwner();

                return outerConnection;
            }
        }

        override public string ServerVersion
        {
            get
            {
                return OuterConnection.Open_GetServerVersion();
            }
        }

        //override protected void Activate(SysTx.Transaction transaction)
        //{
        //}

        override protected void Activate()
        {
        }

        override public DbTransaction BeginTransaction(IsolationLevel isolevel)
        {
            return BeginOdbcTransaction(isolevel);
        }

        internal OdbcTransaction BeginOdbcTransaction(IsolationLevel isolevel)
        {
            return OuterConnection.Open_BeginTransaction(isolevel);
        }

        override public void ChangeDatabase(string value)
        {
            OuterConnection.Open_ChangeDatabase(value);
        }

        override protected DbReferenceCollection CreateReferenceCollection()
        {
            return new OdbcReferenceCollection();
        }

        override protected void Deactivate()
        {
            NotifyWeakReference(OdbcReferenceCollection.Closing);
        }

        //override public void EnlistTransaction(SysTx.Transaction transaction) {
        //    OuterConnection.Open_EnlistTransaction(transaction);
        //}
    }
}
