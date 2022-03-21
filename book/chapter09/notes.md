# Working with Files, Streams, and Sterialization 

## Managing the filesystem
> Your applications will often need to perform input and output with files and directories in different environments. 
> - The `System` and `System.IO` namespaces contain classes for this purpose.

## Controlling how you work with files 

When working with files, you often need to control how they are opened. 
- The `File.Open` method has overloads to specify additional options using `enum` values.
    - `FileMode`: This controls what you want to do with the file, like `CreateNew`, `OpenOrCreate`, or `Tuncate`.
    - `FileAccess`: This controls what level of access you need, like `ReadWrite`.
    - `FileShare`: This controls locks on the file to allow other processes the specified level of access, like `Read`.

You may want to open a file and read from it, and allow other processes to read it  too, as shown below. 
```cs
FileStream file = File.Open(pathToFile,
    FileMode.Open, FileAccess.Read, FileShare.Read);
```

## Reading and writing with streams
A **stream** is a sequence of bytes that can be read from and written to. 
- Although files can be processed rather like arrays, with random access provided by knowing the position of a byte within a file, it can be useful to process files as a stream in which the bytes can be accessed in sequential order.
- Streams can also be used to process terminal input and output and networking resources such as sockets and ports that do not provide random access and cannot seek to a position.

| Member | Description |
| ------ | ----------- |
| `CanRead`, `CanWrite` | This determines whether you can read from and write to the stream. |
| `Length`, `Position` | This determines the total number of bytes and the current position within the stream. These properties may throw an exception for some types of stream. |
| `Dispose()` | This closes the stream and releases its resources. | 
| `Flush()` | If the stream has a buffer, then the bytes in the buffer are written to the stream and the buffer is cleared. | 
| `Read()`, `ReadAsync()` | This reads a specified number of bytes from the stream into a byte array and advances the positon. | 
| `ReadByte()` | This reads the next byte from the stream and advances the positon. |
| `Seek()` | This moves the position to the specified positon (if `CanSeek` is `true`). | 
| `Write()`, `WriteAsync()` | This writes the conents of a byte array into the stream. | 
| `WriteByte()` | This writes a byte to the stream. |