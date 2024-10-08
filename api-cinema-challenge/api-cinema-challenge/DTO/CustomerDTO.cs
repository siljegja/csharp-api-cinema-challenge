﻿using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.PhoneNumber;
            CreatedAt = customer.CreatedAt;
            UpdatedAt = customer.UpdatedAt;
        }
    }
}
 