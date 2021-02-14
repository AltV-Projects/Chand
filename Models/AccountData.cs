using System.Collections;
using System.Collections.Generic;

namespace Chand.Models
{
    public class AccountData : BasicData
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HardwareId { get; set; }
        public string SocialClubName { get; set; }
        public string SocialClubHash { get; set; }

        public  ICollection<CharacterData> Characters { get; set; }

    }
}
