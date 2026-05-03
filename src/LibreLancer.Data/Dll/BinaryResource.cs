/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 мая 2026 06:53:12
 * Version: 1.0.2464
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