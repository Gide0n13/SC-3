using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMailSender.Model
{
    class DBclass
    {
        private RecipientsDataContext recipients = new RecipientsDataContext();

        public IQueryable<Emails> Recipients
        {
            get
            {
                return from c in recipients.Emails select c;
            }
        }
    }
}
