using System.IO;

namespace NUnitWithInheritanceDemo
{
    public static class MyWriter
    {
        public static void WriteLine(string message)
        {
            using (StreamWriter writer = File.AppendText("Output.txt"))
            {
                writer.WriteLine(message);
            }
        }
    }
}