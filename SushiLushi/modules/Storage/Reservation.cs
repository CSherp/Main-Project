using System;

namespace Storage {
    public class Reservation {

        public int id { get; set; }
        public bool guestAccount { get; set; }
        public string fullname { get; set; }

        public string email { get; set; }

        public string username { get; set; }

        public int amountPeople { get; set; }

        public string[] peopleNotes { get; set; }

        public DateTime datetime { get; set; }
    }
}