﻿using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 用户岗位仓储
    /// </summary>
    public class UserPositionRepository : RepositoryBase<UserPosition>, IUserPositionRepository {
        /// <summary>
        /// 初始化用户岗位仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UserPositionRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}