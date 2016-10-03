﻿namespace Corvus.Amf.Test.v0
{
    public static class ByteArray
    {
        /// <summary>
        ///     3575
        /// </summary>
        public static readonly byte[] Number64Bytes =
        {
            0x00, 0x40, 0xab, 0xee, 0x00, 0x00, 0x00, 0x00,
            0x00
        };

        /// <summary>
        ///     false
        /// </summary>
        public static readonly byte[] BooleanBytes =
        {
            0x01, 0x00
        };

        /// <summary>
        ///     connect
        /// </summary>
        public static readonly byte[] StringBytes =
        {
            0x02, 0x00, 0x07, 0x63, 0x6f, 0x6e, 0x6e, 0x65,
            0x63, 0x74
        };

        /// <summary>
        ///     fmsVer = FMS/3,5,7,7009
        ///     capabilities = 127
        /// </summary>
        public static readonly byte[] ObjectBytes =
        {
            0x03, 0x00, 0x06, 0x66, 0x6d, 0x73, 0x56, 0x65,
            0x72, 0x02, 0x00, 0x0e, 0x46, 0x4d, 0x53, 0x2f,
            0x33, 0x2c, 0x35, 0x2c, 0x37, 0x2c, 0x37, 0x30,
            0x30, 0x39, 0x00, 0x0c, 0x63, 0x61, 0x70, 0x61,
            0x62, 0x69, 0x6c, 0x69, 0x74, 0x69, 0x65, 0x73,
            0x00, 0x40, 0x5f, 0xc0, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x09
        };

        /// <summary>
        ///     version = 3,5,7,7009
        /// </summary>
        public static readonly byte[] EcmaArrayBytes =
        {
            0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x76,
            0x65, 0x72, 0x73, 0x69, 0x6f, 0x6e, 0x02, 0x00,
            0x0a, 0x33, 0x2c, 0x35, 0x2c, 0x37, 0x2c, 0x37,
            0x30, 0x30, 0x39, 0x00, 0x00, 0x09
        };

        public static readonly byte[] RealDataArrayBytes =
        {
            /* 0000 */ 0x02, 0x00, 0x07, 0x63, // ok
            /* 0010 */ 0x6f, 0x6e, 0x6e, 0x65, 0x63, 0x74, 0x00, 0x3f, /* */ 0xf0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, // ok
            /* 0020 */ 0x00, 0x03, 0x61, 0x70, 0x70, 0x02, 0x00, 0x19, /* */ 0x6c, 0x69, 0x76, 0x65, 0x65, 0x64, 0x67, 0x65, // ok
            /* 0030 */ 0x2f, 0x6c, 0x69, 0x76, 0x65, 0x5f, 0x31, 0x36, /* */ 0x30, 0x39, 0x32, 0x37, 0x5f, 0x30, 0x32, 0x5f, // ok
            /* 0040 */ 0x30, 0x00, 0x08, 0x66, 0x6c, 0x61, 0x73, 0x68, /* */ 0x56, 0x65, 0x72, 0x02, 0x00, 0x0e, 0x57, 0x49, // ok
            /* 0050 */ 0x4e, 0x20, 0x32, 0x33, 0x2c, 0x30, 0x2c, 0x30, /* */ 0x2c, 0x31, 0x36, 0x32, 0x00, 0x06, 0x73, 0x77, // ok
            /* 0060 */ 0x66, 0x55, 0x72, 0x6c, 0x02, 0x00, 0x38, 0x68, /* */ 0x74, 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x6c, 0x69, // ok
            /* 0070 */ 0x76, 0x65, 0x2e, 0x6e, 0x69, 0x63, 0x6f, 0x76, /* */ 0x69, 0x64, 0x65, 0x6f, 0x2e, 0x6a, 0x70, 0x2f, // ok
            /* 0080 */ 0x6e, 0x69, 0x63, 0x6f, 0x6c, 0x69, 0x76, 0x65, /* */ 0x70, 0x6c, 0x61, 0x79, 0x65, 0x72, 0x2e, 0x73, // ok
            /* 0090 */ 0x77, 0x66, 0x3f, 0x31, 0x36, 0x30, 0x35, 0x33, /* */ 0x30, 0x31, 0x33, 0x35, 0x37, 0x32, 0x30, 0x00, // ok
            /* 00a0 */ 0x05, 0x74, 0x63, 0x55, 0x72, 0x6c, 0x02, 0x00, /* */ 0x3e, 0x72, 0x74, 0x6d, 0x70, 0x3a, 0x2f, 0x2f, // ok
            /* 00b0 */ 0x6e, 0x6c, 0x65, 0x75, 0x32, 0x32, 0x2e, 0x6c, /* */ 0x69, 0x76, 0x65, 0x2e, 0x6e, 0x69, 0x63, 0x6f, // ok
            /* 00c0 */ 0x76, 0x69, 0x64, 0x65, 0x6f, 0x2e, 0x6a, 0x70, /* */ 0x3a, 0x31, 0x39, 0x33, 0x35, 0x2f, 0x6c, 0x69, // ok
            /* 00d0 */ 0x76, 0x65, 0x65, 0x64, 0x67, 0x65, 0x2f, 0x6c, /* */ 0x69, 0x76, 0x65, 0x5f, 0x31, 0x36, 0x30, 0x39, // ok
            /* 00e0 */ 0x32, 0x37, 0x5f, 0x30, 0x32, 0x5f, 0x30, 0x00, /* */ 0x04, 0x66, 0x70, 0x61, 0x64, 0x01, 0x00, 0x00, // ok
            /* 00f0 */ 0x0c, 0x63, 0x61, 0x70, 0x61, 0x62, 0x69, 0x6c, /* */ 0x69, 0x74, 0x69, 0x65, 0x73, 0x00, 0x40, 0x6d, // ok
            /* 0100 */ 0xe0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0b, /* */ 0x61, 0x75, 0x64, 0x69, 0x6f, 0x43, 0x6f, 0x64, // ok
            /* 0110 */ 0x65, 0x63, 0x73, 0x00, 0x40, 0xab, 0xee, 0x00, /* */ 0x00, 0x00, 0x00, 0x00, 0x00, 0x0b, 0x76, 0x69, // ok
            /* 0120 */ 0x64, 0x65, 0x6f, 0x43, 0x6f, 0x64, 0x65, 0x63, /* */ 0x73, 0x00, 0x40, 0x6f, 0x80, 0x00, 0x00, 0x00, // ok
            /* 0130 */ 0x00, 0x00, 0x00, 0x0d, 0x76, 0x69, 0x64, 0x65, /* */ 0x6f, 0x46, 0x75, 0x6e, 0x63, 0x74, 0x69, 0x6f, // ok
            /* 0140 */ 0x6e, 0x00, 0x3f, 0xf0, 0x00, 0x00, 0x00, 0x00, /* */ 0x00, 0x00, 0x00, 0x07, 0x70, 0x61, 0x67, 0x65, // ok
            /* 0150 */ 0x55, 0x72, 0x6c, 0x02, 0x00, 0x55, 0x68, 0x74, /* */ 0x74, 0x70, 0x3a, 0x2f, 0x2f, 0x6c, 0x69, 0x76, // ok
            /* 0160 */ 0x65, 0x2e, 0x6e, 0x69, 0x63, 0x6f, 0x76, 0x69, /* */ 0x64, 0x65, 0x6f, 0x2e, 0x6a, 0x70, 0x2f, 0x77, // ok
            /* 0170 */ 0x61, 0x74, 0x63, 0x68, 0x2f, 0x6c, 0x76, 0x32, /* */ 0x37, 0x37, 0x32, 0x32, 0x33, 0x30, 0x30, 0x39, // ok
            /* 0180 */ 0x3f, 0x63, 0x63, 0x5f, 0x72, 0x65, 0x66, 0x65, /* */ 0x72, 0x72, 0x65, 0x72, 0x3d, 0x6c, 0x69, 0x76, // ok
            /* 0190 */ 0x65, 0x5f, 0x74, 0x6f, 0x70, 0x26, 0x72, 0x65, /* */ 0x66, 0x3d, 0x74, 0x6f, 0x70, 0x5f, 0x72, 0x65, // ok
            /* 01a0 */ 0x63, 0x6f, 0x6d, 0x6d, 0x65, 0x6e, 0x64, 0x5f, /* */ 0x36, 0x5f, 0x32, 0x00, 0x0e, 0x6f, 0x62, 0x6a, // ok
            /* 01b0 */ 0x65, 0x63, 0x74, 0x45, 0x6e, 0x63, 0x6f, 0x64, /* */ 0x69, 0x6e, 0x67, 0x00, 0x40, 0x08, 0x00, 0x00, // ok
            /* 01c0 */ 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x09, 0x02, /* */ 0x00, 0x32, 0x35, 0x30, 0x35, 0x36, 0x33, 0x32, // ok
            /* 01d0 */ 0x35, 0x33, 0x3a, 0x6c, 0x76, 0x32, 0x37, 0x37, /* */ 0x32, 0x32, 0x33, 0x30, 0x30, 0x39, 0x3a, 0x30, // ok
            /* 01e0 */ 0x3a, 0x31, 0x34, 0x37, 0x34, 0x39, 0x31, 0x32, /* */ 0x33, 0x34, 0x39, 0x3a, 0x66, 0x64, 0x64, 0x64, // ok
            /* 01f0 */ 0x65, 0x66, 0x36, 0x36, 0x65, 0x63, 0x31, 0x35, /* */ 0x36, 0x32, 0x61, 0x36 // ok
        };
    }
}