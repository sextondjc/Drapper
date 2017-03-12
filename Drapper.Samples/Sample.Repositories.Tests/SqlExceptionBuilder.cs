using System;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace Sample.Repositories.Tests
{
    /// <summary>
    /// Handy utility class to throw a <see cref="SqlException"/> during mocking. 
    /// </summary>
    /// <remarks>
    /// Lifted pretty much directly from http://stackoverflow.com/a/29939664. 
    /// Edited to replace explicit types with var & call return statements earlier 
    /// (save a variable - it's the right thing to do :) )
    /// </remarks>
    public class SqlExceptionBuilder
    {
        private int errorNumber;
        private string errorMessage;

        public SqlException BuildComplete()
        {
            var error = this.CreateError();
            var errorCollection = this.CreateErrorCollection(error);
            return this.CreateException(errorCollection);
        }

        public SqlExceptionBuilder WithErrorNumber(int number)
        {
            this.errorNumber = number;
            return this;
        }

        public SqlExceptionBuilder WithErrorMessage(string message)
        {
            this.errorMessage = message;
            return this;
        }

        private SqlError CreateError()
        {
            // Create instance via reflection...
            var ctors = typeof(SqlError).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
            var firstSqlErrorCtor = ctors.FirstOrDefault(
                ctor =>
                ctor.GetParameters().Count() == 7); // Need a specific constructor!

            return firstSqlErrorCtor.Invoke(
                new object[]
                {
                this.errorNumber,
                new byte(),
                new byte(),
                string.Empty,
                string.Empty,
                string.Empty,
                new int()
                }) as SqlError;
        }

        private SqlErrorCollection CreateErrorCollection(SqlError error)
        {
            // Create instance via reflection...
            var sqlErrorCollectionCtor = typeof(SqlErrorCollection).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)[0];
            var errorCollection = sqlErrorCollectionCtor.Invoke(new object[] { }) as SqlErrorCollection;

            // Add error...
            typeof(SqlErrorCollection).GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(errorCollection, new object[] { error });

            return errorCollection;
        }

        private SqlException CreateException(SqlErrorCollection errorCollection)
        {
            // Create instance via reflection...
            var ctor = typeof(SqlException).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)[0];
            return ctor.Invoke(
                new object[]
                { 
                // With message and error collection...
                this.errorMessage,
                errorCollection,
                null,
                Guid.NewGuid()
                }) as SqlException;
        }
    }
}