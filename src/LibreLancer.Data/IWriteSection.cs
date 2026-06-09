/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 июня 2026 16:54:15
 * Version: 1.0.2501
 */

using System.Text;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data;

public interface IWriteSection
{
    void WriteTo(IniBuilder builder);
}
