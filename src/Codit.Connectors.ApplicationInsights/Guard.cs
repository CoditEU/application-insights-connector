﻿using System;
using System.Runtime.CompilerServices;

namespace Codit.Connectors.ApplicationInsights
{
    public class Guard
    {
        /// <summary>
        ///     Verifies that a parameter value is not null, empty or whitespace
        /// </summary>
        /// <param name="value">Value of the parameter</param>
        /// <param name="parameterName">Name of the parameter</param>
        /// <param name="callerMemberName">Information about the source of the issue. It is autogenerated so should not be supplied</param>
        /// <param name="callerFilePath">Information about the source of the issue. It is autogenerated so should not be supplied</param>
        /// <param name="callerLineNumber">Information about the source of the issue. It is autogenerated so should not be supplied</param>
        public static void AgainstNullOrWhitespace(string value, string parameterName, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = default(int))
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(parameterName, $"{parameterName} was not supplied to {callerMemberName} (at {callerFilePath}: {callerLineNumber})");
            }
        }

        /// <summary>
        ///     Verifies that a parameter value is not null
        /// </summary>
        /// <param name="value">Value of the parameter</param>
        /// <param name="parameterName">Name of the parameter</param>
        /// <param name="callerMemberName">Information about the source of the issue. It is autogenerated so should not be supplied</param>
        /// <param name="callerFilePath">Information about the source of the issue. It is autogenerated so should not be supplied</param>
        /// <param name="callerLineNumber">Information about the source of the issue. It is autogenerated so should not be supplied</param>
        public static void AgainstNull(object value, string parameterName, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = default(int))
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, $"{parameterName} was not supplied to {callerMemberName} (at {callerFilePath}: {callerLineNumber})");
            }
        }
    }
}