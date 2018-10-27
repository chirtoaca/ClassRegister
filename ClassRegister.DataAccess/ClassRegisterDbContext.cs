using ClassRegister.DataModel.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ClassRegister.DataAccess
{
    public class ClassRegisterDbContext : IdentityDbContext<ApplicationUser>
    {
        public ClassRegisterDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }

        public static ClassRegisterDbContext Create()
        {
            return new ClassRegisterDbContext();
        }

    }
}
