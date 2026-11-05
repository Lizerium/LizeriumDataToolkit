/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 ноября 2026 06:53:15
 * Version: 1.0.2649
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