﻿// Copyright (c) 2020, Dijji, and released under Ms-PL.  This can be found in the root of this distribution. 

using System;

namespace XstExport
{
    enum WindowsErrorCodes
    {
        ERROR_FILE_NOT_FOUND = 2,
        ERROR_PATH_NOT_FOUND = 3,
        ERROR_ACCESS_DENIED = 5,
        ERROR_INVALID_PARAMETER = 87,
        ERROR_XML_PARSE_ERROR = 1465,
    }

    class XstExportException : Exception
    {
        public string Description { get; set; }
        public Exception Exception { get; set; } = null;
        public WindowsErrorCodes ErrorCode { get; set; }
        public string DisplayString
        {
            get
            {
                if (Exception == null)
                    return Description;
                else
                    return Description + "\r\n" + Exception.Message;
            }
        }
    }
}
