/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:52:10
 * Version: 1.0.2441
 */

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace LibreLancer;

public class ConcurrentHashSet<T> : ICollection<T>, IReadOnlyCollection<T>
{
    private readonly ConcurrentDictionary<T, byte> dictionary;

    public ConcurrentHashSet()
    {
        dictionary = new ConcurrentDictionary<T, byte>();
    }

    public ConcurrentHashSet(IEnumerable<T> collection)
    {
        dictionary = new ConcurrentDictionary<T, byte>(collection.Select(x => new KeyValuePair<T, byte>(x, 0)));
    }

    public bool Add(T item) => dictionary.TryAdd(item, 0);
    
    public int Count => dictionary.Count;
    public void Clear() => dictionary.Clear();
    public bool Remove(T item) => dictionary.TryRemove(item, out _);

    public bool Contains(T item) => dictionary.ContainsKey(item);

    public IEnumerator<T> GetEnumerator() => dictionary.Keys.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
    void ICollection<T>.Add(T item) => ((IDictionary<T, byte>) dictionary).Add(item, 0);

    public void CopyTo(T[] array, int arrayIndex) => 
        dictionary.Keys.ToArray().CopyTo(array, arrayIndex);
    

    public bool IsReadOnly => false;
}