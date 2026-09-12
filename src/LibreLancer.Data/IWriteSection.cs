/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2026 06:53:18
 * Version: 1.0.2596
 */

using System.Text;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data;

public interface IWriteSection
{
    void WriteTo(IniBuilder builder);
}
