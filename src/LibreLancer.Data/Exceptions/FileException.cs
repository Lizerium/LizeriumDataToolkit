/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:53:35
 * Version: 1.0.2448
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Runtime.Serialization;

namespace LibreLancer
{
    [Serializable]
    public abstract class FileException : Exception
    {
        protected FileException() : base("???") { }

        protected FileException(string path) : base(path) { }

        protected FileException(string message, Exception innerException) : base(message, innerException) { }

        protected FileException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }

        public override string Message
        {
            get
            {
                return "\r\nThe File " + base.Message + " could not be read.";
            }
        }
    }
}