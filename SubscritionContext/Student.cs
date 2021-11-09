using System.Collections.Generic;
using System.Linq;
using Curse.NotificationContext;
using Curse.SharedContext;

namespace Curse.SubscritionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscritions = new List<Subscrition>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }

        public IList<Subscrition> Subscritions { get; set; }

        public void CreateSubscrition(Subscrition subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já tem assinatura ativa"));
                return;
            }
            else
            {
                Subscritions.Add(subscription);
            }
        }

        public bool IsPremium => Subscritions.Any(x => !x.IsInactive);
    }
}