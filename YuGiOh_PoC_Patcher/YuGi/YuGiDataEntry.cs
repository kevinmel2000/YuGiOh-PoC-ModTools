using System;
using System.Text;

namespace YuGiOh_PoC_Patcher.YuGi
{
    public class YuGiDataEntry
    {
        public int Offset;
        public int Size;
        public int SizeExtra;
        public string FileName;

        public YuGiDataEntry(byte[] bytes)
        {
            FileName = ConvertToFileName(bytes, 0, 256);
            Offset = BitConverter.ToInt32(bytes, 256);
            Size = BitConverter.ToInt32(bytes, 260);
            SizeExtra = BitConverter.ToInt32(bytes, 264);
        }

        private string ConvertToFileName(byte[] bytes, int index, int length)
        {
            if (index + length > bytes.Length) throw new ArgumentException("Index and/or length is exceeding the given byte array!");
            byte[] result = new byte[256];
            for (int i = index; i < index + length; i++)
            {
                result[i] = (byte)(((bytes[i] & 0xF0) >> 4) | ((bytes[i] & 0x0F) << 4));
            }
            return Encoding.ASCII.GetString(result).Trim('\0');
        }

        private byte[] ConvertToBytes(string fileName)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(fileName);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)(((bytes[i] & 0xF0) >> 4) | ((bytes[i] & 0x0F) << 4));
            }
            return bytes;
        }

        public override string ToString()
        {
            return String.Format("Offset: {0}, Size: {1}, SizeExtra: {2}, FileName: {3}", Offset, Size, SizeExtra, FileName);
        }
    }
}