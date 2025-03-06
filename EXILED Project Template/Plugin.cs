using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using HarmonyLib;
using System.Collections.Generic;

namespace EXILED_Project_Template
{
    /// <summary>
    /// 插件的驱动
    /// </summary>
    public sealed class Plugin : Exiled.API.Features.Plugin<Config, Translation>
    {
        private static Plugin instance;
        /// <summary>
        /// 获取<seealso cref="Plugin"/>单例
        /// </summary>
        public static Plugin Instance => instance;
        ///<inheritdoc/>
        public override PluginPriority Priority => PluginPriority.First;

        public Harmony Harmony { get; } = new Harmony("$safeprojectname$.Harmony");

        IEnumerable<CustomRole> customRoleList;

        ///<inheritdoc/>
        public override void OnEnabled()
        {
            instance = this;
            Log.Info("==========CustomRole==========");
            customRoleList = CustomRole.RegisterRoles(false, null);
            foreach (CustomRole role in customRoleList)
            {
                Log.Info(role.Name + "----------------OK");
            }
            Log.Info("=============================");
            Harmony.PatchAll();
            base.OnEnabled();
        }

        ///<inheritdoc/>
        public override void OnDisabled()
        {
            instance = null;
            CustomRole.UnregisterRoles(customRoleList);
            Harmony.UnpatchAll();
            base.OnDisabled();
        }
    }
}
