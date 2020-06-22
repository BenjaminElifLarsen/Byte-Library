using System;
using System.Collections.Generic;

namespace Converter
{
    /// <summary>
    /// Class <c>BitConversion</c>.
    /// Converts between byte arrays, strings and intergers. 
    /// Allows for both big and little endians on all public functions and can swap an array to the other version. 
    /// <list type = "bullet">
    /// <item>
    /// <term>+ValueToBitArray</term>
    /// <description>Converts an interger to a byte array.
    /// Overloaded with ushort, short, ulong, long, uint and int.
    /// Return: void, out byte[].</description>
    /// </item>
    /// <item>
    /// <term>+ValueToBitArrayQuick</term>
    /// <description>Converts an interger to a byte array. Quicker than ValueToBitArrayQuick.
    /// Overloaded with ushort, short, ulong, long, uint and int.
    /// Return: void, out byte[].</description>
    /// </item>
    /// <item>
    /// <term>-charListToByte</term>
    /// <description>Converts a char IList to a byte array.
    /// Return: void, ref byte[].</description>
    /// </item>
    /// <item>
    /// <term>-ValueToChar</term>
    /// <description>Converts a value to a char IList.
    /// Overloaded with ushort, short, ulong, long, uint and int.</description>
    /// Return: IList of char.
    /// </item>
    /// <item>
    /// <term>+ValueToBitString</term>
    /// <description>Creates a string with the binary digits making on the value passed to it. 
    /// Return: string. </description>
    /// </item>
    /// <item>
    /// <term>-CharListToString</term>
    /// <description>Converts a IList of char to a string.
    /// Return: void, out string.</description>
    /// </item>
    /// <item>
    /// <term>+ByteConverterToInterger</term>
    /// <description>Converts a byte array to an interger. 
    /// Overloaded with ulong, long, uint, int, ushort and short. 
    /// Return: void, ref of the variable type.</description>
    /// </item>
    /// <item>
    /// <term>+EndianSwap</term>
    /// <description>Changes little endian to big endian and the other way around.
    /// Return: void, ref byte[].</description>
    /// </item>
    /// <item>
    /// <term>-ArraySwap</term>
    /// <description>Called by EndianSwap. Calculates how many swaps are need to be done.
    /// Return: void, ref byte[].</description>
    /// </item>
    /// <item>
    /// <term>-Swap</term>
    /// <description>Swaps two values around.
    /// Return: void, ref byte and ref byte.</description>
    /// </item>
    /// <item>
    /// <term>+ByteArrayToASCII</term>
    /// <description>Converts a byte array to a string. Each byte is converted into an ASCII value. 
    /// Return: string.</description>
    /// </item>
    /// <item>
    /// <term>+ASCIIToByteArray</term>
    /// <description>Converts a string to a byte array. Each sign is converted into an byte.
    /// Return: byte[].</description>
    /// </item>
    /// </list>
    /// </summary>
    public class Conversion
    {
        /// <summary>
        /// Converts an ushort <paramref name="value"/> into an array, <paramref name="bitArray"/>, of two bytes.
        /// Is a quicker version of ValueToBitArray.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArrayQuick(short value, out byte[] bitArray, bool littleEndian = true)
        {
            short bitHider = 0b_0000_0000_1111_1111;
            byte byteAmount = 2;
            bitArray = new byte[byteAmount];
            for (int i = 0; i < byteAmount; i++)
            {
                bitArray[i] = (byte)(value & bitHider);
                value >>= 8;
            }
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an ushort <paramref name="value"/> into an array, <paramref name="bitArray"/>, of two bytes.
        /// Is a quicker version of ValueToBitArray.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArrayQuick(ushort value, out byte[] bitArray, bool littleEndian = true)
        {
            ushort bitHider = 0b_0000_0000_1111_1111;
            byte byteAmount = 2;
            bitArray = new byte[byteAmount];
            for (int i = 0; i < byteAmount; i++)
            {
                bitArray[i] = (byte)(value & bitHider);
                value >>= 8;
            }
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an ushort <paramref name="value"/> into an array, <paramref name="bitArray"/>, of four bytes.
        /// Is a quicker version of ValueToBitArray.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArrayQuick(int value, out byte[] bitArray, bool littleEndian = true)
        {
            int bitHider = 0b_0000_0000_10000_0000_10000_0000_1111_1111;
            byte byteAmount = 4;
            bitArray = new byte[byteAmount];
            for (int i = 0; i < byteAmount; i++)
            {
                bitArray[i] = (byte)(value & bitHider);
                value >>= 8;
            }
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an ushort <paramref name="value"/> into an array, <paramref name="bitArray"/>, of four bytes.
        /// Is a quicker version of ValueToBitArray.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArrayQuick(uint value, out byte[] bitArray, bool littleEndian = true)
        {
            uint bitHider = 0b_0000_0000_10000_0000_10000_0000_1111_1111;
            byte byteAmount = 4;
            bitArray = new byte[byteAmount];
            for (int i = 0; i < byteAmount; i++)
            {
                bitArray[i] = (byte)(value & bitHider);
                value >>= 8;
            }
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an ushort <paramref name="value"/> into an array, <paramref name="bitArray"/>, of eight bytes.
        /// Is a quicker version of ValueToBitArray.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArrayQuick(long value, out byte[] bitArray, bool littleEndian = true)
        {
            long bitHider = 0b_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_1111_1111;
            byte byteAmount = 8;
            bitArray = new byte[byteAmount];
            for (int i = 0; i < byteAmount; i++)
            {
                bitArray[i] = (byte)(value & bitHider);
                value >>= 8;
            }
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an ushort <paramref name="value"/> into an array, <paramref name="bitArray"/>, of eight bytes.
        /// Is a quicker version of ValueToBitArray.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArrayQuick(ulong value, out byte[] bitArray, bool littleEndian = true)
        {
            ulong bitHider = 0b_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_1111_1111;
            byte byteAmount = 8;
            bitArray = new byte[byteAmount];
            for (int i = 0; i < byteAmount; i++)
            {
                bitArray[i] = (byte)(value & bitHider);
                value >>= 8;
            }
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an ushort <paramref name="value"/> into an array, <paramref name="bitArray"/>, of two bytes.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArray(ushort value, out byte[] bitArray, bool littleEndian = true)
        {
            bitArray = new byte[2];
            charListToByte(ValueToCharArray(value), ref bitArray);
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts a short <paramref name="value"/> into an array, <paramref name="bitArray"/>, of two bytes.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArray(short value, out byte[] bitArray, bool littleEndian = true)
        {
            bitArray = new byte[2];
            charListToByte(ValueToCharArray(value), ref bitArray);
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an ulong v<paramref name="value"/> into an array, <paramref name="bitArray"/>, of eight bytes.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArray(ulong value, out byte[] bitArray, bool littleEndian = true)
        {
            bitArray = new byte[8];
            charListToByte(ValueToCharArray(value), ref bitArray);
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts a long <paramref name="value"/> into an array, <paramref name="bitArray"/>, of eight bytes.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArray(long value, out byte[] bitArray, bool littleEndian = true)
        {
            bitArray = new byte[8];
            charListToByte(ValueToCharArray(value), ref bitArray);
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an uint <paramref name="value"/> into an array, <paramref name="bitArray"/>, of four bytes. 
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArray(uint value, out byte[] bitArray, bool littleEndian = true)
        {
            bitArray = new byte[4];
            charListToByte(ValueToCharArray(value), ref bitArray);
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts an int <paramref name="value"/> into an array, <paramref name="bitArray"/>, of four bytes.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="bitArray">The byte array that contains "value" in bytes.</param> 
        /// <param name="littleEndian">If false, the function will return the array as big endian, else little endian.</param>
        public static void ValueToBitArray(int value, out byte[] bitArray, bool littleEndian = true)
        { //make a quicker version that focos more on bitwise operations
            bitArray = new byte[4];
            charListToByte(ValueToCharArray(value), ref bitArray);
            if (!littleEndian)
                ArraySwap(ref bitArray);
        }

        /// <summary>
        /// Converts a char list into a byte array
        /// </summary>
        /// <param name="arrayOfChars">The char to convert, each element is either '0' or '1'</param>
        /// <param name="bitArray">The byte array, length is the arrayOfChars's length / 8, with the value of the bits. Returned as little endian</param>
        private static void charListToByte(IList<char> arrayOfChars, ref byte[] bitArray)
        {//function that gather entries in the IList<char> in groups of 8, raise them to their specific power depending on their posistion
            //and place them into an byte array. 
            IList<byte> bitCharArray = new List<byte>();
            byte n = 0;
            byte numberOfBits = (byte)(arrayOfChars.Count);
            for (int i = 0; i <= numberOfBits - 1; i++)
            {
                byte bitValue = arrayOfChars[i] == '1' ? (byte)2 : (byte)0;
                bitCharArray.Add(bitValue);
                if (bitCharArray.Count == 8)
                {
                    for (int k = 0; k <= 7; k++)
                        bitArray[n] += bitCharArray[k] != 0 ? (byte)Math.Pow(bitCharArray[k], k) : (byte)0;
                    n++;
                    bitCharArray = new List<byte>();
                }
            }
        }

        /// <summary>
        /// Takes an ushort variable and returns it's bits in a char
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>Returns an IList<char> which each entry either being '0' or '1' </char></returns>
        private static IList<char> ValueToCharArray(ushort value)
        {
            IList<char> charList = new List<char>();
            for (int n = 15; n >= 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value >>= 1;
                charList.Add(m);
            }
            return charList;
        }

        /// <summary>
        /// Takes a short variable and returns it's bits in a char
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>Returns an IList<char> which each entry either being '0' or '1' </char></returns>
        private static IList<char> ValueToCharArray(short value)
        {
            IList<char> charList = new List<char>();
            for (int n = 15; n >= 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value >>= 1;
                charList.Add(m);
            }
            return charList;
        }

        /// <summary>
        /// Takes a long variable and returns it's bits in a char
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>Returns an IList<char> which each entry either being '0' or '1' </char></returns>
        private static IList<char> ValueToCharArray(long value)
        {
            IList<char> charList = new List<char>();
            for (int n = 63; n >= 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value >>= 1;
                charList.Add(m);
            }
            return charList;
        }

        /// <summary>
        /// Takes an ulong variable and returns it's bits in a char
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>Returns an IList<char> which each entry either being '0' or '1' </char></returns>
        private static IList<char> ValueToCharArray(ulong value)
        {
            IList<char> charList = new List<char>();
            for (int n = 63; n >= 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value >>= 1;
                charList.Add(m);
            }
            return charList;
        }

        /// <summary>
        /// Takes an uint variable and returns it's bits in a char
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>Returns an IList<char> which each entry either being '0' or '1' </char></returns>
        private static IList<char> ValueToCharArray(uint value)
        {
            IList<char> charList = new List<char>();
            for (int n = 31; n >= 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value >>= 1;
                charList.Add(m);
            }
            return charList;
        }

        /// <summary>
        /// Takes an int variable and returns it's bits in a char
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>Returns an IList<char> which each entry either being '0' or '1' </char></returns>
        private static IList<char> ValueToCharArray(int value)
        {
            IList<char> charList = new List<char>();
            for (int n = 31; n >= 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value >>= 1;
                charList.Add(m);
            }
            return charList;
        }

        /// <summary>
        /// Takes a byte variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(byte value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 8; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (byte)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Takes a sbyte variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(sbyte value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 8; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (sbyte)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Takes a short variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(short value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 8; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (short)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Takes an ushort variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(ushort value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 8; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (ushort)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Takes an int variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(int value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 32; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (int)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Takes an unit variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(uint value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 32; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (uint)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Takes long variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(long value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 8; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (long)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Takes an ulong variable and returns it's bits in a string
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="bitString">String representing the bit of the value variable</param>
        public static void ValueToBitString(ulong value, out string bitString)
        {
            bitString = null;
            IList<char> charList = new List<char>();
            for (int n = 8; n > 0; n--)
            {
                char m = value % 2 != 0 ? '1' : '0';
                value = (ulong)(value >> 1);
                charList.Add(m);
            }
            CharListToString(charList, out bitString);
        }

        /// <summary>
        /// Converts a list of chars, consisting of '1's and '0's, to a string
        /// </summary>
        /// <param name="list">Char list to convert</param>
        /// <param name="convertedToString">The string representing the bits</param>
        private static void CharListToString(IList<char> list, out string convertedToString)
        {
            convertedToString = "";
            for (int n = list.Count - 1; n >= 0; n--)
                convertedToString += list[n].ToString();
        }

        /// <summary>
        /// Converts an endian byte array into the value it represent.
        /// </summary>
        /// <param name="byteArray">The byte array with the values to convert</param>
        /// <param name="value">The actual value of the byte array</param>
        /// <param name="littleEndian">Whether the array is big or little endian</param>
        public static void ByteConverterToInterger(byte[] byteArray, ref ulong value, bool littleEndian = true)
        { //unsigned
            if (!littleEndian)
                ArraySwap(ref byteArray);
            for (int n = byteArray.Length - 1; n >= 0; n--)
                value |= (ulong)(byteArray[n] << (8 * (n)));
        }

        /// <summary>
        /// Converts an endian byte array into the value it represent.
        /// </summary>
        /// <param name="byteArray">The byte array with the values to convert</param>
        /// <param name="value">The actual value of the byte array</param>
        /// <param name="littleEndian">Whether the array is big or little endian</param>
        public static void ByteConverterToInterger(byte[] byteArray, ref uint value, bool littleEndian = true)
        { //unsigned
            if (!littleEndian)
                ArraySwap(ref byteArray);
            for (int n = byteArray.Length - 1; n >= 0; n--)
                value |= (uint)(byteArray[n] << (8 * (n)));
        }

        /// <summary>
        /// Converts an endian byte array into the value it represent.
        /// </summary>
        /// <param name="byteArray">The byte array with the values to convert</param>
        /// <param name="value">The actual value of the byte array</param>
        /// <param name="littleEndian">Whether the array is big or little endian</param>
        public static void ByteConverterToInterger(byte[] byteArray, ref ushort value, bool littleEndian = true)
        { //unsigned
            if (!littleEndian)
                ArraySwap(ref byteArray);
            for (int n = byteArray.Length - 1; n >= 0; n--)
                value |= (ushort)(byteArray[n] << (8 * (n)));
        }

        /// <summary>
        /// Converts an endian byte array into the value it represent.
        /// </summary>
        /// <param name="byteArray">The byte array with the values to convert</param>
        /// <param name="value">The actual value of the byte array</param>
        /// <param name="littleEndian">Whether the array is big or little endian</param>
        public static void ByteConverterToInterger(byte[] byteArray, ref long value, bool littleEndian = true)
        { //signed
            if (!littleEndian)
                ArraySwap(ref byteArray);
            for (int n = byteArray.Length - 1; n >= 0; n--)
                value |= (long)(byteArray[n] << (8 * (n)));
        }

        /// <summary>
        /// Converts an endian byte array into the value it represent.
        /// </summary>
        /// <param name="byteArray">The byte array with the values to convert</param>
        /// <param name="value">The actual value of the byte array</param>
        /// <param name="littleEndian">Whether the array is big or little endian</param>
        public static void ByteConverterToInterger(byte[] byteArray, ref int value, bool littleEndian = true)
        { //signed
            if (!littleEndian)
                ArraySwap(ref byteArray);
            for (int n = byteArray.Length - 1; n >= 0; n--)
                value |= (int)(byteArray[n] << (8 * (n)));
        }

        /// <summary>
        /// Converts an endian byte array into the value it represent.
        /// </summary>
        /// <param name="byteArray">The byte array with the values to convert</param>
        /// <param name="value">The actual value of the byte array</param>
        /// <param name="littleEndian">Whether the array is big or little endian</param>
        public static void ByteConverterToInterger(byte[] byteArray, ref short value, bool littleEndian = true)
        { //signed
            if (!littleEndian)
                ArraySwap(ref byteArray);
            for (int n = byteArray.Length - 1; n >= 0; n--)
                value |= (short)(byteArray[n] << (8 * (n)));
        }


        /// <summary>
        /// Swaps array of one endian type to the other type
        /// </summary>
        /// <param name="byteArray">The byte array to swap</param>
        public static void EndianSwap(ref byte[] byteArray)
        {
            ArraySwap(ref byteArray);
        }

        /// <summary>
        /// Swaps values in an array around. Start at the edges and work toward the middle.
        /// If uneven amount of elements in the array, middle element is not swapped. 
        /// The elements swapped are byteArray[i] and byteArray[byteArray.length ( - 1 + 1 * i), i being 0, 1... floor(byteArray.length/2).
        /// </summary>
        /// <param name="byteArray">Array which values are to be swapped</param>
        private static void ArraySwap(ref byte[] byteArray)
        { //swap...? consider switch in stead of
            int amountOfSwap = byteArray.Length % 2 == 0 ? byteArray.Length / 2 : (byteArray.Length - 1) / 2;
            for (int n = 0; n < amountOfSwap; n++)
            {
                Swap(ref byteArray[n], ref byteArray[byteArray.Length - (1 + 1 * n)]);
            }
        }

        /// <summary>
        /// Swaps two values around
        /// </summary>
        /// <param name="first">First value to swap</param>
        /// <param name="second">Second value to swap</param>
        private static void Swap(ref byte first, ref byte second)
        {
            byte temp = first;
            first = second;
            second = temp;
        }

        /// <summary>
        /// Converts the values of a byte array into chars and return them in a standard ASCII string. 
        /// Assumes big endian by default. If array is little endian, set littleEndian to true 
        /// </summary>
        /// <param name="bitArray">Byte array consisting of char's given in their byte values</param>
        /// <param name="littleEndian">If false the elements in the array will be swapped around.</param>
        /// <returns>A string consisting of the chars from the bitArray</returns>
        public static string ByteArrayToASCII(byte[] bitArray, bool littleEndian = false) //consider added the bool to those function that returns arrays or takes arrays
        {
            if (littleEndian)
                ArraySwap(ref bitArray);
            string translationOfArray = "";
            foreach (byte bt in bitArray)
                translationOfArray += (char)bt;
            return translationOfArray;
        }

        /// <summary>
        /// Converts a standard ASCII string into the bytes that makes it up.
        /// Assumes big endian by default. If array is little endian, set littleEndian to true 
        /// The return array is big endian.
        /// </summary>
        /// <param name="toConvert">String to convert to bytes</param>
        /// <param name="littleEndian">If false the elements in the array will be swapped around.</param>
        /// <returns>Returns a byte array, each entry is a char from <paramref name="toConvert"/></returns>
        public static byte[] ASCIIToByteArray(string toConvert, bool littleEndian = false) //allow it to return both big and little endian
        {
            uint index = 0;
            byte[] bitArray = new byte[toConvert.Length];
            foreach(char chr in toConvert)
            {
                bitArray[index] = (byte)chr;
                index++;
            }
            if (littleEndian)
                ArraySwap(ref bitArray);
            return bitArray;
        }

        //public static void FactionsToBinary()
        //{
        //    //turns faction into a binary string, use the old converter code and improve it
        //}

        //public static void BinaryToFaction()
        //{
        //    //turns binary string into a faction, use the old converter code and improve it
        //}


    }
}
