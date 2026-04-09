/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:58:14
 * Version: 1.0.2427
 */

using System.Runtime.InteropServices;

namespace LibreLancer.Data.IO;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct Zip32EndOfCentralDirectory
{
    //Skip signature
    public ushort DiskNumber;
    public ushort CentralDirectoryDiskNumber;
    public ushort CentralDirectoryCount;
    public ushort CentralDirectoryTotal;
    public uint CentralDirectorySize;
    public uint CentralDirectoryOffset;
    public uint CommentLength;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct ZipCentralDirectory
{
    public uint Signature;
    public ushort Version;
    public ushort VersionNeeded;
    public ushort GeneralBits;
    public ushort CompressionMethod;
    public uint ModTime;
    public uint DataCrc;
    public uint CompressedSize;
    public uint UncompressedSize;
    public ushort FileNameLength;
    public ushort ExtraFieldLength;
    public ushort CommentLength;
    public ushort DiskNumber;
    public ushort InternalFileAttributes;
    public uint ExtFileAttributes;
    public uint LocalHeaderOffset;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct ZipLocalFileHeader
{
    public uint Signature;
    public ushort VersionNeeded;
    public ushort GeneralBits;
    public ushort Compression;
    public uint ModTime;
    public uint DataCrc;
    public uint CompressedSize;
    public uint UncompressedSize;
    public ushort FileNameLength;
    public ushort ExtraFieldLength;
}
