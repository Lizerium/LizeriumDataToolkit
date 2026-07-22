/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 июля 2026 12:57:03
 * Version: 1.0.2544
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreLancer;

public class LoadingTasks
{
    private List<Task> allTasks = new List<Task>();
    public Task Begin(Action loader, params Task[] dependencies)
    {
        var t = Task.Run(async () =>
        {
            if (dependencies is {Length: > 0})
                await Task.WhenAll(dependencies);
            loader();
        });
        allTasks.Add(t);
        return t;
    }
    public void WaitAll()
    {
        Task.WaitAll(allTasks.ToArray());
    }
}