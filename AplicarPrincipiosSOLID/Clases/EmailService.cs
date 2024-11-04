using AplicarPrincipiosSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicarPrincipiosSOLID.Clases
{
    public class EmailService : IEmailService
    {
        public void SendConfirmation(string email)
        {
            Console.WriteLine($"Sending confirmation email to {email}...");
        }
    }
}
