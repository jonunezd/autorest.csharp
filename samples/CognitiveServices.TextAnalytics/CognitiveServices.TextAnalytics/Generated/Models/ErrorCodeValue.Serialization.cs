// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace CognitiveServices.TextAnalytics.Models
{
    internal static class ErrorCodeValueExtensions
    {
        public static string ToSerialString(this ErrorCodeValue value) => value switch
        {
            ErrorCodeValue.InvalidRequest => "invalidRequest",
            ErrorCodeValue.InvalidArgument => "invalidArgument",
            ErrorCodeValue.InternalServerError => "internalServerError",
            ErrorCodeValue.ServiceUnavailable => "serviceUnavailable",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ErrorCodeValue value.")
        };

        public static ErrorCodeValue ToErrorCodeValue(this string value) => value switch
        {
            "invalidRequest" => ErrorCodeValue.InvalidRequest,
            "invalidArgument" => ErrorCodeValue.InvalidArgument,
            "internalServerError" => ErrorCodeValue.InternalServerError,
            "serviceUnavailable" => ErrorCodeValue.ServiceUnavailable,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ErrorCodeValue value.")
        };
    }
}
