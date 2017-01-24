﻿//------------------------------------------------------------------------------
// <copyright file="UnsafeNativeMethods.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <owner current="true" primary="true">[....]</owner>
// <owner current="true" primary="false">[....]</owner>
// <owner current="true" primary="false">[....]</owner>
//------------------------------------------------------------------------------

using System.Data.Odbc;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Text;

namespace System.Data.Common
{
    static class ExternDll
    {
        public const string Odbc32 = "odbc32.dll";
    }


    [SuppressUnmanagedCodeSecurityAttribute()]
    internal static partial class UnsafeNativeMethods
    {

        //
        // ODBC32
        //
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLAllocHandle(
            /*SQLSMALLINT*/ODBC32.SQL_HANDLE HandleType,
            /*SQLHANDLE*/IntPtr InputHandle,
            /*SQLHANDLE* */out IntPtr OutputHandle) {
            OutputHandle = IntPtr.Zero;
            return ODBC32.RetCode.ERROR;
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLAllocHandle(
            /*SQLSMALLINT*/ODBC32.SQL_HANDLE HandleType,
            /*SQLHANDLE*/OdbcHandle InputHandle,
            /*SQLHANDLE* */out IntPtr OutputHandle)
        {
            OutputHandle = IntPtr.Zero;
            return ODBC32.RetCode.ERROR;
        }


        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLBindCol(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLUSMALLINT*/UInt16 ColumnNumber,
            /*SQLSMALLINT*/ODBC32.SQL_C TargetType,
            /*SQLPOINTER*/HandleRef TargetValue,
            /*SQLLEN*/IntPtr BufferLength,
            /*SQLLEN* */IntPtr StrLen_or_Ind)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLBindCol(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLUSMALLINT*/UInt16 ColumnNumber,
            /*SQLSMALLINT*/ODBC32.SQL_C TargetType,
            /*SQLPOINTER*/IntPtr TargetValue,
            /*SQLLEN*/IntPtr BufferLength,
            /*SQLLEN* */IntPtr StrLen_or_Ind)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLBindParameter(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLUSMALLINT*/UInt16 ParameterNumber,
            /*SQLSMALLINT*/Int16 ParamDirection,
            /*SQLSMALLINT*/ODBC32.SQL_C SQLCType,
            /*SQLSMALLINT*/Int16 SQLType,
            /*SQLULEN*/IntPtr cbColDef,
            /*SQLSMALLINT*/IntPtr ibScale,
            /*SQLPOINTER*/HandleRef rgbValue,
            /*SQLLEN*/IntPtr BufferLength,
            /*SQLLEN* */HandleRef StrLen_or_Ind)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLCancel(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLCloseCursor(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLColAttributeW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLUSMALLINT*/Int16 ColumnNumber,
            /*SQLUSMALLINT*/Int16 FieldIdentifier,
            /*SQLPOINTER*/CNativeBuffer CharacterAttribute,
            /*SQLSMALLINT*/Int16 BufferLength,
            /*SQLSMALLINT* */out Int16 StringLength,
            /*SQLPOINTER*/out IntPtr NumericAttribute)
        {
            StringLength = Int16.MinValue;
            NumericAttribute = IntPtr.Zero;
            return ODBC32.RetCode.ERROR;
        }

        // note: in sql.h this is defined differently for the 64Bit platform.
        // However, for us the code is not different for SQLPOINTER or SQLLEN ...
        // frome sql.h:
        // #ifdef _WIN64
        // SQLRETURN  SQL_API SQLColAttribute (SQLHSTMT StatementHandle,
        //            SQLUSMALLINT ColumnNumber, SQLUSMALLINT FieldIdentifier,
        //            SQLPOINTER CharacterAttribute, SQLSMALLINT BufferLength,
        //            SQLSMALLINT *StringLength, SQLLEN *NumericAttribute) {}
        // #else
        // SQLRETURN  SQL_API SQLColAttribute (SQLHSTMT StatementHandle,
        //            SQLUSMALLINT ColumnNumber, SQLUSMALLINT FieldIdentifier,
        //            SQLPOINTER CharacterAttribute, SQLSMALLINT BufferLength,
        //            SQLSMALLINT *StringLength, SQLPOINTER NumericAttribute) {}
        // #endif


        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLColumnsW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string CatalogName,
            /*SQLSMALLINT*/Int16 NameLen1,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string SchemaName,
            /*SQLSMALLINT*/Int16 NameLen2,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string TableName,
            /*SQLSMALLINT*/Int16 NameLen3,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string ColumnName,
            /*SQLSMALLINT*/Int16 NameLen4)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLDisconnect(
            /*SQLHDBC*/IntPtr ConnectionHandle)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLDriverConnectW(
            /*SQLHDBC*/OdbcConnectionHandle hdbc,
            /*SQLHWND*/IntPtr hwnd,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string               connectionstring,
            /*SQLSMALLINT*/Int16 cbConnectionstring,
            /*SQLCHAR* */IntPtr connectionstringout,
            /*SQLSMALLINT*/Int16 cbConnectionstringoutMax,
            /*SQLSMALLINT* */out Int16 cbConnectionstringout,
            /*SQLUSMALLINT*/Int16 fDriverCompletion)
        {
            cbConnectionstringout = Int16.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLEndTran(
            /*SQLSMALLINT*/ODBC32.SQL_HANDLE HandleType,
            /*SQLHANDLE*/IntPtr Handle,
            /*SQLSMALLINT*/Int16 CompletionType)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLExecDirectW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string   StatementText,
            /*SQLINTEGER*/Int32 TextLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLExecute(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLFetch(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLFreeHandle(
            /*SQLSMALLINT*/ODBC32.SQL_HANDLE HandleType,
            /*SQLHSTMT*/IntPtr StatementHandle)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLFreeStmt(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLUSMALLINT*/ODBC32.STMT Option)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetConnectAttrW(
            /*SQLHBDC*/OdbcConnectionHandle ConnectionHandle,
            /*SQLINTEGER*/ODBC32.SQL_ATTR Attribute,
            /*SQLPOINTER*/byte[] Value,
            /*SQLINTEGER*/Int32 BufferLength,
            /*SQLINTEGER* */out Int32 StringLength)
        {
            StringLength = Int32.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetData(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLUSMALLINT*/UInt16 ColumnNumber,
            /*SQLSMALLINT*/ODBC32.SQL_C TargetType,
            /*SQLPOINTER*/CNativeBuffer TargetValue,
            /*SQLLEN*/IntPtr BufferLength, // sql.h differs from MSDN
                                           /*SQLLEN* */out IntPtr StrLen_or_Ind)
        {
            StrLen_or_Ind = IntPtr.Zero;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetDescFieldW(
            /*SQLHSTMT*/OdbcDescriptorHandle StatementHandle,
            /*SQLUSMALLINT*/Int16 RecNumber,
            /*SQLUSMALLINT*/ODBC32.SQL_DESC FieldIdentifier,
            /*SQLPOINTER*/CNativeBuffer ValuePointer,
            /*SQLINTEGER*/Int32 BufferLength,
            /*SQLINTEGER* */out Int32 StringLength)
        {
            StringLength = Int32.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetDiagRecW(
            /*SQLSMALLINT*/ODBC32.SQL_HANDLE HandleType,
            /*SQLHANDLE*/OdbcHandle Handle,
            /*SQLSMALLINT*/Int16 RecNumber,
            /*SQLCHAR* */  StringBuilder rchState,
            /*SQLINTEGER* */out Int32 NativeError,
            /*SQLCHAR* */StringBuilder MessageText,
            /*SQLSMALLINT*/Int16 BufferLength,
            /*SQLSMALLINT* */out Int16 TextLength)
        {
            NativeError = Int32.MinValue;
            TextLength = Int16.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetDiagFieldW(
           /*SQLSMALLINT*/ ODBC32.SQL_HANDLE HandleType,
           /*SQLHANDLE*/   OdbcHandle Handle,
           /*SQLSMALLINT*/ Int16 RecNumber,
           /*SQLSMALLINT*/ Int16 DiagIdentifier,
           [MarshalAs(UnmanagedType.LPWStr)]
           /*SQLPOINTER*/  StringBuilder    rchState,
           /*SQLSMALLINT*/ Int16 BufferLength,
           /*SQLSMALLINT* */ out Int16 StringLength)
        {
            StringLength = Int16.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetFunctions(
            /*SQLHBDC*/OdbcConnectionHandle hdbc,
            /*SQLUSMALLINT*/ODBC32.SQL_API fFunction,
            /*SQLUSMALLINT* */out Int16 pfExists)
        {
            pfExists = Int16.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetInfoW(
            /*SQLHBDC*/OdbcConnectionHandle hdbc,
            /*SQLUSMALLINT*/ODBC32.SQL_INFO fInfoType,
            /*SQLPOINTER*/byte[] rgbInfoValue,
            /*SQLSMALLINT*/Int16 cbInfoValueMax,
            /*SQLSMALLINT* */out Int16 pcbInfoValue)
        {
            pcbInfoValue = Int16.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetInfoW(
            /*SQLHBDC*/OdbcConnectionHandle hdbc,
            /*SQLUSMALLINT*/ODBC32.SQL_INFO fInfoType,
            /*SQLPOINTER*/byte[] rgbInfoValue,
            /*SQLSMALLINT*/Int16 cbInfoValueMax,
            /*SQLSMALLINT* */IntPtr pcbInfoValue)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetStmtAttrW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLINTEGER*/ODBC32.SQL_ATTR Attribute,
            /*SQLPOINTER*/out IntPtr Value,
            /*SQLINTEGER*/Int32 BufferLength,
            /*SQLINTEGER*/out Int32 StringLength)
        {
            Value = IntPtr.Zero;
            StringLength = Int32.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLGetTypeInfo(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLSMALLINT*/Int16 fSqlType)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLMoreResults(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLNumResultCols(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLSMALLINT* */out Int16 ColumnCount)
        {
            ColumnCount = Int16.MinValue;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLPrepareW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string   StatementText,
            /*SQLINTEGER*/Int32 TextLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLPrimaryKeysW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string CatalogName,
            /*SQLSMALLINT*/Int16 NameLen1,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */ string SchemaName,
            /*SQLSMALLINT*/Int16 NameLen2,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string TableName,
            /*SQLSMALLINT*/Int16 NameLen3)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLProcedureColumnsW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)] /*SQLCHAR* */ string CatalogName,
            /*SQLSMALLINT*/Int16 NameLen1,
            [In, MarshalAs(UnmanagedType.LPWStr)] /*SQLCHAR* */ string SchemaName,
            /*SQLSMALLINT*/Int16 NameLen2,
            [In, MarshalAs(UnmanagedType.LPWStr)] /*SQLCHAR* */ string ProcName,
            /*SQLSMALLINT*/Int16 NameLen3,
            [In, MarshalAs(UnmanagedType.LPWStr)] /*SQLCHAR* */ string ColumnName,
            /*SQLSMALLINT*/Int16 NameLen4)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLProceduresW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)] /*SQLCHAR* */ string CatalogName,
            /*SQLSMALLINT*/Int16 NameLen1,
            [In, MarshalAs(UnmanagedType.LPWStr)] /*SQLCHAR* */ string SchemaName,
            /*SQLSMALLINT*/Int16 NameLen2,
            [In, MarshalAs(UnmanagedType.LPWStr)] /*SQLCHAR* */ string ProcName,
            /*SQLSMALLINT*/Int16 NameLen3)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLRowCount(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLLEN* */out IntPtr RowCount)
        {
            RowCount = IntPtr.Zero;
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetConnectAttrW(
            /*SQLHBDC*/OdbcConnectionHandle ConnectionHandle,
            /*SQLINTEGER*/ODBC32.SQL_ATTR Attribute,
            /*SQLPOINTER*/System.Transactions.IDtcTransaction Value,
            /*SQLINTEGER*/Int32 StringLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetConnectAttrW(
            /*SQLHBDC*/OdbcConnectionHandle ConnectionHandle,
            /*SQLINTEGER*/ODBC32.SQL_ATTR Attribute,
            /*SQLPOINTER*/string Value,
            /*SQLINTEGER*/Int32 StringLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetConnectAttrW(
            /*SQLHBDC*/OdbcConnectionHandle ConnectionHandle,
            /*SQLINTEGER*/ODBC32.SQL_ATTR Attribute,
            /*SQLPOINTER*/IntPtr Value,
            /*SQLINTEGER*/Int32 StringLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetConnectAttrW( // used only for AutoCommitOn
                                                                               /*SQLHBDC*/IntPtr ConnectionHandle,
            /*SQLINTEGER*/ODBC32.SQL_ATTR Attribute,
            /*SQLPOINTER*/IntPtr Value,
            /*SQLINTEGER*/Int32 StringLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetDescFieldW(
            /*SQLHSTMT*/OdbcDescriptorHandle StatementHandle,
            /*SQLSMALLINT*/Int16 ColumnNumber,
            /*SQLSMALLINT*/ODBC32.SQL_DESC FieldIdentifier,
            /*SQLPOINTER*/HandleRef CharacterAttribute,
            /*SQLINTEGER*/Int32 BufferLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetDescFieldW(
            /*SQLHSTMT*/OdbcDescriptorHandle StatementHandle,
            /*SQLSMALLINT*/Int16 ColumnNumber,
            /*SQLSMALLINT*/ODBC32.SQL_DESC FieldIdentifier,
            /*SQLPOINTER*/IntPtr CharacterAttribute,
            /*SQLINTEGER*/Int32 BufferLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        // user can set SQL_ATTR_CONNECTION_POOLING attribute with envHandle = null, this attribute is process-level attribute
        [ResourceExposure(ResourceScope.Process)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetEnvAttr(
            /*SQLHENV*/OdbcEnvironmentHandle EnvironmentHandle,
            /*SQLINTEGER*/ODBC32.SQL_ATTR Attribute,
            /*SQLPOINTER*/IntPtr Value,
            /*SQLINTEGER*/ODBC32.SQL_IS StringLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSetStmtAttrW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLINTEGER*/Int32 Attribute,
            /*SQLPOINTER*/IntPtr Value,
            /*SQLINTEGER*/Int32 StringLength)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLSpecialColumnsW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            /*SQLUSMALLINT*/ODBC32.SQL_SPECIALCOLS IdentifierType,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string CatalogName,
            /*SQLSMALLINT*/Int16 NameLen1,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string SchemaName,
            /*SQLSMALLINT*/Int16 NameLen2,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string TableName,
            /*SQLSMALLINT*/Int16 NameLen3,
            /*SQLUSMALLINT*/ODBC32.SQL_SCOPE Scope,
            /*SQLUSMALLINT*/ ODBC32.SQL_NULLABILITY Nullable)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLStatisticsW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string CatalogName,
            /*SQLSMALLINT*/Int16 NameLen1,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string SchemaName,
            /*SQLSMALLINT*/Int16 NameLen2,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string TableName,
            /*SQLSMALLINT*/Int16 NameLen3,
            /*SQLUSMALLINT*/Int16 Unique,
            /*SQLUSMALLINT*/Int16 Reserved)
        {
            return ODBC32.RetCode.ERROR;
        }

        [ResourceExposure(ResourceScope.None)]
        static internal /*SQLRETURN*/ODBC32.RetCode SQLTablesW(
            /*SQLHSTMT*/OdbcStatementHandle StatementHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string CatalogName,
            /*SQLSMALLINT*/Int16 NameLen1,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string SchemaName,
            /*SQLSMALLINT*/Int16 NameLen2,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string TableName,
            /*SQLSMALLINT*/Int16 NameLen3,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            /*SQLCHAR* */string TableType,
            /*SQLSMALLINT*/Int16 NameLen4)
        {
            return ODBC32.RetCode.ERROR;
        }
    }
}