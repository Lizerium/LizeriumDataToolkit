/*
 * Author: Nikolay Dvurechensky and Librelancer Contributors
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:56
 * Version: 1.0.2431
 */

// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using LibreLancer.Data.Ini;

namespace LibreLancer.Data.Equipment
{
    [ParsedSection]
    public partial class MineDropper : AbstractEquipment
    {
        [Entry("projectile_archetype")] public string ProjectileArchetype;
        [Entry("dry_fire_sound")] public string DryFireSound;
        [Entry("power_usage")] public float PowerUsage;
        [Entry("refire_delay")] public float RefireDelay;
        [Entry("muzzle_velocity")] public float MuzzleVelocity;
        [Entry("damage_per_fire")] public float DamagePerFire;
    }
}
