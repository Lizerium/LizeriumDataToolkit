/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 июля 2026 06:53:44
 * Version: 1.0.2536
 */

namespace LibreLancer.Dll;

public class BinaryResource
{
    public uint Name { get; private set; }
    public byte[] Data { get; private set; }

    public BinaryResource(uint name, byte[] data)
    {
        Name = name;
        Data = data;
    }
}