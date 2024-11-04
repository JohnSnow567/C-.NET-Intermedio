using AplicarPrincipiosSOLID.Clases;
using AplicarPrincipiosSOLID.Interfaces;
using AplicarPrincipiosSOLID;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Crear servicios
            IStudentRepository studentRepository = new StudentRepository();
            IPaymentProcessor paymentProcessor = new PaymentProcessor();
            IEmailService emailService = new EmailService();
            ICourseSubscriptionService subscriptionService = new CourseSubscriptionService(paymentProcessor, emailService);

            // Crear estudiante y curso
            Student student = new Student
            {
                StudentId = 1,
                FirstName = "Jonathan",
                LastName = "Martinez",
                Email = "jonathan.martinez@example.com"
            };

            Course course = new Course
            {
                CourseId = 101,
                Name = "C# .NET Intermedio",
                Type = "online",
                Fee = 100
            };

            int Pago = 100;

            string email = "ejemplo@gmail.com";

            // Guardar estudiante y suscribir a curso
            studentRepository.Save(student);
            subscriptionService.Subscribe(student, course);
            Console.WriteLine("\n \n \n");
            paymentProcessor.ProcessPayment(Pago);
            emailService.SendConfirmation(email);

            Console.WriteLine("Process completed.");

            Console.ReadKey();
        }

        catch (Exception ex)
        {
            Console.WriteLine("Ha ocurrido un error: ", ex);
        }       
    }
}