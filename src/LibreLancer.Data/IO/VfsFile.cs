/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2026 06:52:51
 * Version: 1.0.2584
 */

using System.IO;

namespace LibreLancer.Data.IO;

public abstract class VfsFile : VfsItem
{
    public abstract Stream OpenRead();
    
    public virtual string GetBackingFilename() => null;
}
