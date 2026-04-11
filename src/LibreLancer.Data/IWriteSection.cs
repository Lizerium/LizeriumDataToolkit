/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:39:36
 * Version: 1.0.2429
 */

using System.Text;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data;

public interface IWriteSection
{
    void WriteTo(IniBuilder builder);
}
