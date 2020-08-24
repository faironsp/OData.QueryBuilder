﻿using System;

namespace OData.QueryBuilder.Conventions.Functions
{
    public interface IConvertFunction
    {
        T ConvertEnumToString<T>(T value) where T : Enum;

        DateTime ConvertDateTimeToString(DateTime value, string format);

        DateTimeOffset ConvertDateTimeOffsetToString(DateTimeOffset value, string format);

        /// <summary>
        /// Converting a string value to an escaped one.
        /// </summary>
        /// <remarks>Only %, /,?, #, & сharacters are escaped.</remarks>
        string ConvertStringToEncodeString(string value);
    }
}
