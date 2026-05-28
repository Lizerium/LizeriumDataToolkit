/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 мая 2026 17:31:25
 * Version: 1.0.2489
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