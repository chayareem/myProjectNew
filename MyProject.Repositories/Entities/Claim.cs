using System;

namespace MyProject.Repositories.Entities
{
    public enum ePolicy
    {
        allow, deny
    }
    public class Claim
    {
        public int Id { get; set; }
        public Role Role { get; set; }
        public Permission Permission { get; set; }
        public ePolicy Policy { get; set; }
    }
}
