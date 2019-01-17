using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6;
using System;

namespace lab6Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNotes()
        {
            var date = new DateTime(2018, 10, 12);
            var notepad = new Notepad();
            notepad.Add(date, "text1");
            notepad.Add(date, "text2");
            var date1 = new DateTime(2018, 12, 25);
            notepad.Add(date1, "text3");

            Assert.AreEqual(notepad.GetNotes(date).Count, 2);

            Assert.AreNotEqual(notepad.GetNotes(date1).Count, 2);

            Assert.AreEqual(notepad.GetNotes(date)[0].Text, "text1");
            Assert.AreEqual(notepad.GetNotes(date)[1].Text, "text2");

        }
    }
}
