﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace ConnectionFactoryDb
{
    public class OracleDatabase : Database
    {
        public override IDbConnection CreateConnection()
        {
            return new OracleConnection(connectionString);
        }

        public override IDbCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public override IDbConnection CreateOpenConnection()
        {
            OracleConnection connection = (OracleConnection)CreateConnection();
            connection.Open();

            return connection;
        }

        public override IDbCommand CreateCommand(string commandText, System.Data.IDbConnection connection)
        {
            OracleCommand command = (OracleCommand)CreateCommand();

            command.CommandText = commandText;
            command.Connection = (OracleConnection)connection;
            command.CommandType = CommandType.Text;

            return command;
        }

        public override IDbCommand CreateStoredProcCommand(string procName, System.Data.IDbConnection connection)
        {
            OracleCommand command = (OracleCommand)CreateCommand();

            command.CommandText = procName;
            command.Connection = (OracleConnection)connection;
            command.CommandType = CommandType.StoredProcedure;

            return command;

        }

        public override IDataParameter CreateParameter(string parameterName, object parameterValue)
        {
            return new OracleParameter(parameterName, parameterValue);
        }
    }
}
