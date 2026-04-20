/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:22:24
 * Version: 1.0.2444
 */

using System.Text;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data;

public interface IWriteSection
{
    void WriteTo(IniBuilder builder);
}
