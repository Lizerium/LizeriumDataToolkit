/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:25:20
 * Version: 1.0.2432
 */

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Missions
{

    public struct EmpathyEvent
    {
        public EmpathyEventType Type;
        public float ChangeAmount;

        public EmpathyEvent(Entry e)
        {
            switch (e[0].ToString().ToLowerInvariant())
            {
                case "object_destruction":
                    Type = EmpathyEventType.ObjectDestruction;
                    break;
                case "random_mission_success":
                    Type = EmpathyEventType.RandomMissionSuccess;
                    break;
                case "random_mission_failure":
                    Type = EmpathyEventType.RandomMissionFailure;
                    break;
                case "random_mission_abortion":
                    Type = EmpathyEventType.RandomMissionAbort;
                    break;
                default:
                    FLLog.Error("Ini", $"Bad empathy event {e[0]} at {e.Section.File}:{e.Line}");
                    Type = EmpathyEventType.None;
                    break;
            }
            ChangeAmount = e[1].ToSingle();
        }
    }

    public enum EmpathyEventType
    {
        None,
        ObjectDestruction,
        RandomMissionSuccess,
        RandomMissionFailure,
        RandomMissionAbort
    }
}
