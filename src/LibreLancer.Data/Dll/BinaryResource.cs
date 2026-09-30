/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 сентября 2026 11:01:44
 * Version: 1.0.2614
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