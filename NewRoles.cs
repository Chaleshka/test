using Exiled.API.Features;
using Exiled.CustomRoles.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRoles
{
    public class NewRoles : Plugin<Config>
    {
        //private static readonly NewRoles InstanceValue = new NewRoles();

        //public static NewRoles Instance => InstanceValue;
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
