using Exiled.API.Interfaces;
using System.ComponentModel;

namespace EXILED_Project_Template
{
    /// <summary>
    /// 插件的配置
    /// </summary>
    public sealed class Config : IConfig
    {
        ///<inheritdoc/>
        public bool IsEnabled { get; set; } = true;
        ///<inheritdoc/>
        public bool Debug { get; set; }
        
    }
}
