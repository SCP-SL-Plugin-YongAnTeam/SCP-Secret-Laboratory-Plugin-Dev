using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System.Collections.Generic;

namespace EXILED_Item_Template
{
    [CustomRole(RoleTypeId.None)]
    public sealed class CustomRoleTemplate : CustomRole
    {
        public override uint Id { get; set; } = 114514;
        public override int MaxHealth { get; set; } = 100;
        public override string Name { get; set; } = "CustomRole Template";
        public override string Description { get; set; } = "hello exiled";
        public override string CustomInfo { get; set; } = "Template Role";
        public override bool KeepRoleOnChangingRole { get; set; } = true;
        public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;
        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties() { Limit = 1 , RoomSpawnPoints = [new() { Room = RoomType.LczTCross }] };
        public override List<string> Inventory { get; set; } =
        [
            ItemType.KeycardMTFOperative.ToString(),
            ItemType.GunE11SR.ToString(),
            ItemType.ArmorCombat.ToString(),
            ItemType.Medkit.ToString(),
            ItemType.Radio.ToString(),
            ItemType.GrenadeHE.ToString(),
        ];
        public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new() { { AmmoType.Nato556, 100 } , { AmmoType.Nato762, 6 } };
        public override bool KeepInventoryOnSpawn { get; set; } = false;

        protected override void SubscribeEvents()
        {


            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {


            base.UnsubscribeEvents();
        }
    }
}
