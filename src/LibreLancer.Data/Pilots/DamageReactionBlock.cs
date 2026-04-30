/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 апреля 2026 09:20:31
 * Version: 1.0.2455
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Collections.Generic;
using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Pilots
{
    [ParsedSection]
    public partial class DamageReactionBlock : PilotBlock
    {
        [Entry("evade_break_damage_trigger_percent")]
        public float EvadeBreakDamageTriggerPercent;
        [Entry("evade_dodge_more_damage_trigger_percent")]
        public float EvadeDodgeMoreDamageTriggerPercent;
        [Entry("engine_kill_face_damage_trigger_percent")]
        public float EngineKillFaceDamageTriggerPercent;
        [Entry("engine_kill_face_damage_trigger_time")]
        public float EngineKillFaceDamageTriggerTime;
        [Entry("roll_damage_trigger_percent")] public float RollDamageTriggerPercent;
        [Entry("roll_damage_trigger_time")] public float RollDamageTriggerTime;
        [Entry("afterburner_damage_trigger_percent")]
        public float AfterburnerDamageTriggerPercent;
        [Entry("afterburner_damage_trigger_time")]
        public float AfterburnerDamageTriggerTime;
        [Entry("brake_reverse_damage_trigger_percent")]
        public float BrakeReverseDamageTriggerPercent;
        [Entry("drop_mines_damage_trigger_percent")]
        public float DropMinesDamageTriggerPercent;
        [Entry("drop_mines_damage_trigger_time")]
        public float DropMinesDamageTriggerTime;
        [Entry("fire_guns_damage_trigger_percent")]
        public float FireGunsDamageTriggerPercent;
        [Entry("fire_guns_damage_trigger_time")]
        public float FireGunsDamageTriggerTime;
        [Entry("fire_missiles_damage_trigger_percent")]
        public float FireMissilesDamageTriggerPercent;
        [Entry("fire_missiles_damage_trigger_time")]
        public float FireMissilesDamageTriggerTime;
    }
}
