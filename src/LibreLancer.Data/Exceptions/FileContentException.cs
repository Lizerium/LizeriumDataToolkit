/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:40
 * Version: 1.0.2449
 */

// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Runtime.Serialization;

namespace LibreLancer
{
    [Serializable]
    public class FileContentException : FileException
    {
        private string format, message;

        public FileContentException() : base() { }

        public FileContentException(string path) : base(path) { }

        public FileContentException(string message, Exception innerException) : base(message, innerException) { }

        public FileContentException(string format, string message)
            : base()
        {
            this.format = format;
            this.message = message;
        }

        public FileContentException(string path, string format, string message)
            : base(path)
        {
            this.format = format;
            this.message = message;
        }

        protected FileContentException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override string Message
        {
            get
            {
                return base.Message + "\r\n" + "Invalid " + format + " file: " + message;
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //TODO
            base.GetObjectData(info, context);
        }
    }
}