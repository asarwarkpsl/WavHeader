namespace WaveHeader
{
    public class WavHeader
    {
        public static void ReadMetaData(string spath)
        {
            FileStream fs = new FileStream(spath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);
       
            byte[] data = br.ReadBytes(4);
            Console.WriteLine($"Riff File:{System.Text.Encoding.UTF8.GetString(data)}");

            data = br.ReadBytes(4);
            Console.WriteLine($"File Size:{BitConverter.ToInt32(data, 0)}");

            data = br.ReadBytes(4);
            Console.WriteLine($"File Type Header:{System.Text.Encoding.UTF8.GetString(data)}");

            data = br.ReadBytes(4);
            Console.WriteLine($"Chunk Marker:{System.Text.Encoding.UTF8.GetString(data)}");

            data = br.ReadBytes(4);
            Console.WriteLine($"Format data length:{BitConverter.ToInt32(data,0)}");

            data = br.ReadBytes(2);
            Console.WriteLine($"Type of Format:{BitConverter.ToInt16(data,0)}");

             data = br.ReadBytes(2);
            Console.WriteLine($"Number of Channels:{BitConverter.ToInt16(data,0)}");

            data = br.ReadBytes(4);
            Console.WriteLine($"Sample Rate:{BitConverter.ToInt32(data, 0)}");

            data = br.ReadBytes(4);
            //Console.WriteLine($"Sample Rate detailed:{BitConverter.ToInt32(data, 0)}");


            data = br.ReadBytes(2);
            //Console.WriteLine($"Bits per sample detail:{BitConverter.ToInt16(data,0)}");

            data = br.ReadBytes(2);
            Console.WriteLine($"Bits per sample:{BitConverter.ToInt16(data,0)}");


            data = br.ReadBytes(4);
            Console.WriteLine($"Data Chunk header:{System.Text.Encoding.UTF8.GetString(data)}");

            data = br.ReadBytes(4);
            Console.WriteLine($"Data Size:{BitConverter.ToInt32(data, 0)}");
        }
    }
}