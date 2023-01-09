using Microsoft.EntityFrameworkCore;
using SmartQueue.DataAccess.Abstract.IRepositories;
using SmartQueue.DataAccess.Concrete.EntityFramework.Context;
using SmartQueue.DataAccess.Concrete.EntityFramework.Repositories.GenericRepository;
using SmartQueue.DataAccess.Concrete.ReturnResult;
using SmartQueue.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.DataAccess.Concrete.EntityFramework.Repositories
{
    public class RoleRepository : EFGenericRepository<Role, DataAccessReturnResult<Role>, SmartQueueDbContext>, IRoleRepository
    {
        private readonly SmartQueueDbContext context;
        public RoleRepository(SmartQueueDbContext context) : base(context) 
        {
            this.context = context;
        }

        public async Task<DataAccessReturnResult<Role>> GetAllByIdsAsync(ICollection<UserRole> userRoles, Expression<Func<Role, bool>>? expression = null, bool enableTracking = true, params string[] include)
        {
            var result = new DataAccessReturnResult<Role>();
            try
            {
                
                IQueryable<Role> queryable = context.Roles;
                if (!enableTracking) queryable = queryable.AsNoTracking();
                if (expression != null) queryable = queryable.Where(expression);
                if (include.Count() > 0)
                {
                    foreach (var item in include)
                    {
                        queryable = queryable.Include(item);
                    }
                }

                var roles = await queryable.ToListAsync();
                ICollection<Role> rolesCollection = new List<Role>();
                foreach (var userRole in userRoles)
                {
                    foreach (var role in roles)
                    {
                        if (role.Id == userRole.RoleId)
                        {
                            rolesCollection.Add(role);
                        }
                    }
                }
                result.MainMethod("GetAll Succeed", true, rolesCollection);
                return result;
            }
            catch (Exception ex)
            {
                result.MainMethod(ex.Message, false);
                return result;
            }
        }
    }
}
