using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExtensionMethods
{
    public static class StreamUtil
    {
        const int BufferSize = 8192;

        public static void Copy(this Stream input, Stream output)
        {
            byte[] buffer = new byte[BufferSize];

            int read;

            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }

        public static byte[] ReadFully(this Stream input)
        {
            using (MemoryStream tempStream = new MemoryStream())
            {
                //CopyTo(input, tempStream);

                input.Copy(tempStream);

                return tempStream.ToArray();
            }
        }
    }

    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ','.', ',' },StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
