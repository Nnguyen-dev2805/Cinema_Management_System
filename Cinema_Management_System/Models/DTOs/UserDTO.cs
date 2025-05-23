﻿namespace Cinema_Management_System.Models.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Staff_Id { get; set; }

        public UserDTO()
        {

        }
        public UserDTO(int id, string username, string password, int staff_Id)
        {
            Id = id;
            Username = username;
            Password = password;
            Staff_Id = staff_Id;
        }

        public UserDTO(string username, string password, int staff_Id)
        {
            Username = username;
            Password = password;
            Staff_Id = staff_Id;
        }
    }
}
