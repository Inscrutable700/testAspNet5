using System;

namespace WebApplication1.ViewModels
{
    /// <summary>
    /// The home model.
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Gets or sets the friend names.
        /// </summary>
        public string[] FriendNames { get; set; }
    }
}
