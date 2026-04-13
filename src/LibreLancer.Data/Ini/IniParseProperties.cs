/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
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
