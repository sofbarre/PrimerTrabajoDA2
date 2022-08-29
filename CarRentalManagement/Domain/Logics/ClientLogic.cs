using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Logics
{
    public class ClientLogic
    {
        public List<Client> Clients { get; set; } = new List<Client>
        {
            new Client{Name ="Jorge" , Country = "Uruguay" , Active = true},
            new Client{Name ="Facha" , Country = "Brasil" , Active = false},
            new Client{Name ="Alfred" , Country = "Argentina" , Active = true}

        };

        public List<Client> GetClientsByNameAndCountry(String name, String country)
        {
            return Clients.FindAll(x => x.Name == name && x.Country == country);
        }
    }
}
