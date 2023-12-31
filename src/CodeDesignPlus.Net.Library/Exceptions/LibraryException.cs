﻿using System.Runtime.Serialization;

namespace CodeDesignPlus.Net.Library.Exceptions;

/// <summary>
/// The exception that is thrown when an error occurs within CodeDesignPlus.Net.Library. 
/// </summary>
[Serializable]
public class LibraryException : Exception
{
    /// <summary>
    /// Contains the errors
    /// </summary>
    public IEnumerable<string> Errors { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryException"/> class.
    /// </summary>
    public LibraryException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryException"/> class.
    /// </summary>
    /// <param name="errors">The custom errors</param>
    public LibraryException(IEnumerable<string> errors)
    {
        this.Errors = errors;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public LibraryException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="errors">The custom errors</param>
    public LibraryException(string message, IEnumerable<string> errors) : base(message)
    {
        this.Errors = errors;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic)
    /// if no inner exception is specified.
    /// </param>
    public LibraryException(string message, Exception innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="errors">The custom errors</param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic)
    /// if no inner exception is specified.
    /// </param>
    public LibraryException(string message, IEnumerable<string> errors, Exception innerException) : base(message, innerException)
    {
        this.Errors = errors;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryException"/> class.
    /// </summary>
    /// <param name="info">
    /// The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.
    /// </param>
    /// <param name="context">
    /// The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.
    /// </param>
    protected LibraryException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        if (info != null)
        {
            Errors = (IEnumerable<string>)info.GetValue(nameof(this.Errors), typeof(IEnumerable<string>));
        }
    }

    /// <summary>
    /// Populates a SerializationInfo with the data needed to serialize the target object.
    /// </summary>
    /// <param name="info">The SerializationInfo to populate with data.</param>
    /// <param name="context">The destination (see StreamingContext) for this serialization.</param>
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);

        info?.AddValue(nameof(Errors), this.Errors);
    }
}
