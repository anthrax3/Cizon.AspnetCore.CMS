﻿using Cizon.Domain.Entities;
using Cizon.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cizon.ApplicationService
{
    public class RoleSetingAppService : IRoleSetingAppService
    {
        private readonly IRoleSetingRepository _repository;

        public RoleSetingAppService()
        {
        }

        public RoleSetingAppService(IRoleSetingRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 根据Id删除
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids"></param>
        public void DeleteBatch(List<string> ids)
        {
            _repository.Delete(x => ids.Contains(x.Id));
        }

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RoleSettingDto Get(string id)
        {
            return _repository.Get(id);
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public List<RoleSettingDto> GetAllList()
        {
            return _repository.GetAllList();
        }

        /// <summary>
        /// 根据lambda表达式条件获取实体集合
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<RoleSettingDto> GetAllList(Expression<Func<RoleSettingDto, bool>> predicate)
        {
            return _repository.GetAllList(predicate);
        }

        /// <summary>
        /// 数据插入或更新
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public RoleSettingDto InsertOrUpdate(RoleSettingDto dto)
        {
            return _repository.InsertOrUpdate(dto);
        }



    }
}
