/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2026 09:51:13
 * Version: 1.0.2635
 */

using LibreLancer.Data;

using Newtonsoft.Json;

var freelancerPath = "C:\\Program Files (x86)\\Freelancer";

var vfs = LibreLancer.Data.IO.FileSystem.FromPath(freelancerPath);

var ini = new FreelancerIni(vfs);
var data = new FreelancerData(ini, vfs);

try
{
    data.LoadData((msg) =>
    {
        Console.WriteLine(msg);
    });
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();

var settings = new JsonSerializerSettings
{
    TypeNameHandling = TypeNameHandling.Auto
};

var json = JsonConvert.SerializeObject(data, settings);
File.WriteAllText("freelancer_dump.json", json);