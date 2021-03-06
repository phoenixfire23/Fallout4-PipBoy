﻿namespace PipBoyTest
{
    public static class DebugSettings
    {
        public static bool DumpInitialPacketParsing = false;
        public static bool DumpInitialPacketContent = false;
        public static bool DumpPacketParsing = false;

        public static bool DumpTcpStream = true;                    // dump incoming network data to TcpDumpFile
        public static string TcpDumpFile = "tcp.dump";

        public static bool UseTcp = false;                           // if false; read InputFile, if true; use Host/Port
        public static string InputFile = "complex.dump";
        public const string Host = "192.168.0.133";
        public const int Port = 27000;
    }
}
