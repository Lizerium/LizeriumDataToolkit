/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 мая 2026 10:47:51
 * Version: 1.0.2477
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