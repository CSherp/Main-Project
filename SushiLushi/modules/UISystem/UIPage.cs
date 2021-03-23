using System;

namespace UISystem {
    public class Page {
        public string Title { get; set; }

        public Page(string title) {
            this.Title = title;
        }

        public void Update () {
            Console.Clear();
            Console.Title = this.Title;
        }
    }   
}