/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 июля 2026 12:56:53
 * Version: 1.0.2545
 */

using System.Collections;
using System.Collections.Generic;

namespace LibreLancer;

public struct StructEnumerable<T,TEnumerator> : IEnumerable<T> where TEnumerator : IEnumerator<T>
{
    public TEnumerator Enumerator;

    public TEnumerator GetEnumerator() => Enumerator;

    IEnumerator<T> IEnumerable<T>.GetEnumerator() => Enumerator;

    IEnumerator IEnumerable.GetEnumerator() => Enumerator;

    public StructEnumerable(TEnumerator enumerator) => this.Enumerator = enumerator;
}
