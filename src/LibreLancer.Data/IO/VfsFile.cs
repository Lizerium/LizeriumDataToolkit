/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 октября 2026 06:53:11
 * Version: 1.0.2621
 */

using System.IO;

namespace LibreLancer.Data.IO;

public abstract class VfsFile : VfsItem
{
    public abstract Stream OpenRead();
    
    public virtual string GetBackingFilename() => null;
}
