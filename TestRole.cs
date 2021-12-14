using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRoles
{
    public class TestRole : CustomRole
    {
        public override uint Id { get; set; } = 21;
        public override RoleType Role { get; set; } = RoleType.ClassD;
        public override int MaxHealth { get; set; } = 150;
        public override string Name { get; set; } = "test";
        public override string Description { get; set; } = "test";
        protected virtual SpawnProperties SpawnProperties { get; set; } = new SpawnProperties
        {
            Limit = 1,
            RoleSpawnPoints = new List<RoleSpawnPoint>
            {
                new RoleSpawnPoint
                {
                    Role = RoleType.ClassD,
                    Chance = 50,
                }//,
                //new RoleSpawnPoint
                //{
                //    Role = RoleType.Scientist,
                //    Chance = 50,
                //}
            },
            DynamicSpawnPoints = new List<DynamicSpawnPoint>
            {
                new DynamicSpawnPoint
                {
                    Location = Exiled.CustomItems.API.SpawnLocation.InsideGr18,
                    Chance = 50,
                }
            }
        };
        protected virtual bool RemovalKillsPlayer { get; set; } = true;
        protected virtual bool KeepRoleOnDeath { get; set; } = false;

    }
}
