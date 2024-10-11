using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Domain.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infra.Data.Context
{
    public class EshopContext:DbContext
    {
        #region Constractor

        public EshopContext(DbContextOptions<EshopContext> options ):base(options)
        {

        }

        #endregion

        #region Db sets

        #region User

        public DbSet<User> Users { get; set; }

        #endregion

        #endregion
    }
}
