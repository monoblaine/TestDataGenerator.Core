﻿using System;

namespace TestDataGenerator.Core.Exceptions
{
    /// <summary>
    /// Used when a exception needs to be thrown by the test data generator.
    /// </summary>
    [Serializable]
    public class GenerationException : Exception
    {
        public GenerationException(string message)
            : base(message)
        {
        }
    }
}