/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 мая 2026 06:52:40
 * Version: 1.0.2469
 */

using System.IO;

namespace LibreLancer.Data.IO;

public abstract class VfsFile : VfsItem
{
    public abstract Stream OpenRead();
    
    public virtual string GetBackingFilename() => null;
}
