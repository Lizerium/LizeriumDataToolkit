/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 июля 2026 10:56:50
 * Version: 1.0.2527
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
