/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 сентября 2026 08:14:39
 * Version: 1.0.2602
 */

namespace LibreLancer.Dll;

public class VersionInfoResource
{
    public byte[] Data { get; private set; }

    public VersionInfoResource(byte[] data)
    {
        Data = data;
    }
}