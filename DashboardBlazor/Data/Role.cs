using Microsoft.AspNetCore.Identity;

namespace DashboardBlazor.Data
{
    public class Role : IdentityRole<int>
    {
        public Role() : base()
        {
        }

        public Role(string name) : base(name)
        {
        }
    }
}
