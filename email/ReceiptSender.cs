using BookWiseApp.Database.DAO;
using BookWiseApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Net;

namespace BookWiseApp.email
{
    public static class ReceiptSender
    {
        public static void SendReceipt(Loan loan)
        {
            //get smtp client name from app config
            string? client = ConfigurationManager.AppSettings["smtpServer"];
            //get smtp client port from app config
            int port = int.Parse(ConfigurationManager.AppSettings["smtpPort"]);
            //get smtp client username from app config
            string? username = ConfigurationManager.AppSettings["smtpUsername"];
            //get smtp client password from app config
            string? password = ConfigurationManager.AppSettings["smtpPassword"];
            //get smtp client email from app config
            string? email = ConfigurationManager.AppSettings["smtpEmail"];

            Member member = new MemberDAO().GetByID(loan.MemberId);
            Book book = new BookDAO().GetByID(loan.BookId);

            string subject = $"BookWise - Receipt for {book.Title}";
            string body =
                $"Dear {member.FirstName} {member.LastName},\n\n"
                + $"You have borrowed the book {book.Title} from BookWise. "
                + $"Please return the book by {loan.ReturnDate.ToShortDateString()}.\n\n"
                + $"Best regards,\n"
                + $"BookWise";

            try
            {
                var smtpClient = new SmtpClient(client)
                {
                    Port = port,
                    Credentials = new NetworkCredential(username, password),
                    EnableSsl = true
                };
                smtpClient.Send(email, member.Email, subject, body);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
