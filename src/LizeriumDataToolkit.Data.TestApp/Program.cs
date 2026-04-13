/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
 */

using LibreLancer.Data;

using Newtonsoft.Json;

var freelancerPath = "C:\\Program Files (x86)\\Freelancer";

var vfs = LibreLancer.Data.IO.FileSystem.FromPath(freelancerPath);

var ini = new FreelancerIni(vfs);
var data = new FreelancerData(ini, vfs);
data.LoadData((msg) =>
{
    Console.WriteLine(msg);
});

Console.ReadLine();

var settings = new JsonSerializerSettings
{
    TypeNameHandling = TypeNameHandling.Auto
};

var json = JsonConvert.SerializeObject(data, settings);
File.WriteAllText("freelancer_dump.json", json);