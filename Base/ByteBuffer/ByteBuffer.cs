using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class ByteBuffer
    {
        /// <summary>
        /// 缓冲字节数组
        /// </summary>
        private byte[] data;
        /// <summary>
        /// 字节数组长度
        /// </summary>
        private int arr_length;

        /// <summary>
        /// 构造字节数组初始化
        /// </summary>
        /// <param name="arr_length">字节数组长度</param>
        private ByteBuffer(int arr_length)
        {
            this.data = new byte[arr_length];
            this.arr_length = arr_length;
        }

        /// <summary>
        /// 复制字节数组
        /// </summary>
        /// <param name="data">要复制的字节数组</param>
        private ByteBuffer(byte[] data)
        {
            this.data = data;
            this.arr_length = data.Length;
        }

        /// <summary>
        /// 实例构造入口
        /// </summary>
        public static ByteBuffer NewByteBuffer(int arr_length)
        {
            return new ByteBuffer(arr_length);
        }

        /// <summary>
        /// 复制构造入口
        /// </summary>
        public static ByteBuffer NewByteBuffer(byte[] data)
        {
            return new ByteBuffer(data);
        }


        //以下重载基本数据类型向byte转换
        //传入基类型,返回byte数组

        public byte[] ToByte(Int16 value)
        {
            this.data = BitConverter.GetBytes(value);
            return this.data;
        }

        public byte[] ToByte(Int32 value)
        {
            this.data = BitConverter.GetBytes(value);
            return this.data;
        }

        public byte[] ToByte(Int64 value)
        {
            this.data = BitConverter.GetBytes(value);
            return this.data;
        }

        public byte[] ToByte(float value)
        {
            this.data = BitConverter.GetBytes(value);
            return this.data;
        }

        public byte[] ToByte(double value)
        {
            this.data = BitConverter.GetBytes(value);
            return this.data;
        }

        //以下重载byte数组向基本数据类型转换
        //传入byte数组,返回基类型

        public Int16 ToInt16(byte[] data)
        {
            return BitConverter.ToInt16(data, 0);
        }

        public Int32 ToInt32(byte[] data)
        {
            return BitConverter.ToInt32(data, 0);
        }

        public Int64 ToInt64(byte[] data)
        {
            return BitConverter.ToInt64(data, 0);
        }

        public float ToFloat(byte[] data)
        {
            return BitConverter.ToSingle(data, 0);
        }

        public double ToDouble(byte[] data)
        {
            return BitConverter.ToDouble(data, 0);
        }

        /// <summary>
        /// 返回缓冲字节数组对象
        /// </summary>
        public byte[] GetBuffer()
        {
            return this.data;
        }
    }
}
