namespace ex1
{
    public class Compression
    {
        // Strategy interface
        public interface ICompression
        {
            void CompressFolder(string folderName);
        }

        // Concrete Strategy
        public class RarCompression : ICompression
        {
            public void CompressFolder(string folderName)
            {
                Console.WriteLine($"{folderName} compressed using RAR.");
            }
        }

        // Concrete Strategy
        public class ZipCompression : ICompression
        {
            public void CompressFolder(string folderName)
            {
                Console.WriteLine($"{folderName} compressed using ZIP.");
            }
        }

        // Context class
        public class CompressionContext
        {
            private ICompression _compression;

            public CompressionContext(ICompression compression)
            {
                _compression = compression;
            }

            public void SetCompression(ICompression compression)
            {
                _compression = compression;
            }

            public void Compress(string folderName)
            {
                _compression.CompressFolder(folderName);
            }
        }

        // Client code
        public class Program
        {
            public static void Main(string[] args)
            {
                CompressionContext context = new CompressionContext(new RarCompression());
                context.Compress("Folder1");

                context.SetCompression(new ZipCompression());
                context.Compress("Folder2");
            }
        }
    }
}
