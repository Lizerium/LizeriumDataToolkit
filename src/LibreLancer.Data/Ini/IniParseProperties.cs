/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 сентября 2026 08:44:43
 * Version: 1.0.2604
 */

using System.Collections.Generic;

namespace LibreLancer.Data.Ini;

public sealed class IniParseProperties
{
    public static IniParseProperties Empty { get; } = new();

    private readonly Dictionary<string, object> properties = new();

    public object? this[string property]
    {
        get
        {
            properties.TryGetValue(property, out var result);
            return result;
        }
    }

    public IniParseProperties()
    {
    }

    public IniParseProperties(IEnumerable<KeyValuePair<string, object>> properties)
    {
        this.properties = new(properties);
    }
}
