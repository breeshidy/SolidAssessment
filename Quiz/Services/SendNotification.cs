namespace Quiz.Services
{
    public class SendNotification
    {
        public string SendEmail(Email? email)
        {
            //send email to customer about delivery
            email = new Email();
            //some logic here to send Email

            return "message output";
        }
    }
}
