using System;
using System.Collections.Generic;

namespace lab6
{
    public class Notepad
    {
        public class Note
        {
            public DateTime Date { get; set; }
            public string Text { get; set; }

            public Note(DateTime date, string text)
            {
                Date = date;
                Text = text;
            }
        }

        private Dictionary<DateTime, List<Note>> Notes { get; }

        public Notepad()
        {
            Notes = new Dictionary<DateTime, List<Note>>();
        }

        public void Add(DateTime date, string text)
        {
            if (!Notes.TryGetValue(date.Date, out var notes))
            {
                notes = new List<Note>();
            }
            notes.Add(new Note(date, text));

            Console.WriteLine(date.Date + "The password = ", notes);

            Notes[date.Date] = notes;
        }

        public List<Note> GetNotes(DateTime date)
        {
            if (Notes.TryGetValue(date.Date, out var notes))
            {
                return notes;
            }

            return null;
        }
    }
}
