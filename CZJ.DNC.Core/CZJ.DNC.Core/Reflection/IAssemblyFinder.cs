﻿using System.Collections.Generic;
using System.Reflection;

namespace CZJ.Reflection
{
    /// <summary>
    /// 程序集查找器接口
    /// </summary>
    public interface IAssemblyFinder
    {
        /// <summary>
        /// 返回应用程序使用的所有程序集
        /// </summary>
        /// <returns>程序集列表</returns>
        List<Assembly> GetAllAssemblies();
    }
}