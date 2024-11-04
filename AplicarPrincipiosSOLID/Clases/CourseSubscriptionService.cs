using AplicarPrincipiosSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicarPrincipiosSOLID.Clases
{
    public class CourseSubscriptionService : ICourseSubscriptionService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IEmailService _emailService;

        public CourseSubscriptionService(IPaymentProcessor paymentProcessor, IEmailService emailService)
        {
            _paymentProcessor = paymentProcessor;
            _emailService = emailService;
        }

        public void Subscribe(Student student, Course course)
        {
            Console.WriteLine("Starting course subscription...");

            if (course.Type == "online")
            {
                // 
            }
            else if (course.Type == "live")
            {
                // 
            }

            _paymentProcessor.ProcessPayment(course.Fee);


            _emailService.SendConfirmation(student.Email);

            Console.WriteLine("Course subscription completed.");
        }
    }
}
