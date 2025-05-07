using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu.Models
{
    public  class Session
    {
        public Session()
        {
            SetDefaultChairs();
        }
        public string Date { get; set; }
        public string time { get; set; }
        public List<Chairs> chairs { get; set; }

        private void SetDefaultChairs()
        {
            chairs = new List<Chairs>();
            string[] rows = {"a","b","c","d"};
            string[] numbers = { "1", "2", "3", "4","5","6"};

            foreach (string row in rows)
            {
                foreach (string number in numbers)
                {
                    Chairs chair = new Chairs(row, number);
                    chairs.Add(chair);
                }
            }
        }
    }
}
