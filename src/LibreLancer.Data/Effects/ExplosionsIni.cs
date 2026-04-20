/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:22:24
 * Version: 1.0.2444
 */

using System.Collections.Generic;
using LibreLancer.Data.Ini;
using LibreLancer.Data.IO;

namespace LibreLancer.Data.Effects;

[ParsedIni]
public partial class ExplosionsIni
{
    [Section("Explosion")]
    public List<Explosion> Explosions = new List<Explosion>();
    [Section("Debris")]
    public List<Debris> Debris = new List<Debris>();
    [Section("Simple")]
    public List<Simple> Simples = new List<Simple>();

    public void AddFile(string filename, FileSystem vfs) => ParseIni(filename, vfs);
}
