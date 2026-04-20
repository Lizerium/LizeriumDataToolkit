/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:22:24
 * Version: 1.0.2444
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