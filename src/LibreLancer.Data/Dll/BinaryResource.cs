/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 сентября 2026 06:55:17
 * Version: 1.0.2601
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