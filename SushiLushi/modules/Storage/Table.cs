using System;
using System.Collections.Generic;

namespace Storage {
    public class TableReservation {
        public int reservationId { get; set; }
        public DateTime datetime { get; set; }
    }

    public class Table {
        public int id { get; set; }
        public int size { get; set; }
        public List<TableReservation> reservations { get; set; }
    }
}

