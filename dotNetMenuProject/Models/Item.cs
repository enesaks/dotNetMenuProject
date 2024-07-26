using System;
namespace dotNetMenuProject.Models
{
	public class Item
	{
        
        public string FullName { get; set; }
        public string Id { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsVerified { get; set; }
        public long LatestStoryTs { get; set; }
        public string ProfilePicUrl { get; set; }
        public string Username { get; set; }
        
    }
}

