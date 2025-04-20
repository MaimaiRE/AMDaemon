
using System;
using CardMakerRE;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AMDaemon
{
    namespace AquaDX
    {
        public static class Utils
        {
            public static bool _AimeStatus;

            public static string EncodeKeychipID(string keychip)
            {
                if (string.IsNullOrEmpty(keychip)) return null;
                keychip = keychip.Replace("-", "");
                if (keychip.Substring(keychip.Length - 4) == "1337")
                    keychip = keychip.Substring(0, keychip.Length - 4);
                return keychip;
            }
            
            private static int GetHexVal(char hex)
            {
                int val = (int)hex;
                return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
            }
            
            public static byte[] HexStringToByteArray(string hex)
            {
                if (hex.Length % 2 == 1)
                    throw new ArgumentException("Hex string must have an even number of digits.", nameof(hex));

                byte[] arr = new byte[hex.Length >> 1];
                for (int i = 0; i < hex.Length >> 1; ++i)
                {
                    arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
                }
                return arr;
            }


        }
    }
}