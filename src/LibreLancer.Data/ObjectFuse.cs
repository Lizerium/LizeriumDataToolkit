/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 октября 2026 10:20:03
 * Version: 1.0.2641
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data;


public class ObjectFuse
{
    public string Fuse;
    public float DelayUNKNOWN;
    public float Threshold;

    public ObjectFuse()
    {
    }

    public ObjectFuse(Entry e)
    {
        Fuse = e[0].ToString();
        DelayUNKNOWN = e[1].ToSingle();
        Threshold = e[2].ToSingle();
    }
}
