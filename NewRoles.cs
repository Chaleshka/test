using Exiled.API.Features;
using Exiled.CustomRoles.API;https://github.com/Chaleshka/test/blob/main/NewRoles.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRoles
{
    public class NewRoles : Plugin<Config>
    {
        public override string Author { get; } = "***";
        public override string Name { get; } = "NewRoles";
        public override string Prefix { get; } = "NR";
        public override Version RequiredExiledVersion { get; } = new Version(4, 1, 6);

        public override void OnEnabled()
        {
            Config.RoleConfigs.test.Register();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
           Config.RoleConfigs.test.Unregister();
            base.OnDisabled();
        }
    }
}
