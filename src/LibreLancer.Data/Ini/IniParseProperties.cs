/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 мая 2026 07:50:48
 * Version: 1.0.2476
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
