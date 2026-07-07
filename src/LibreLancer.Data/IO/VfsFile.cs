/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июля 2026 12:19:54
 * Version: 1.0.2529
 */

using System.IO;

namespace LibreLancer.Data.IO;

public abstract class VfsFile : VfsItem
{
    public abstract Stream OpenRead();
    
    public virtual string GetBackingFilename() => null;
}
