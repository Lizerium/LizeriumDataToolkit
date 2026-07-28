/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 июля 2026 10:11:00
 * Version: 1.0.2550
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