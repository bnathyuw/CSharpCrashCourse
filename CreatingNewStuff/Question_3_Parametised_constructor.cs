using System;
using NUnit.Framework;

namespace CreatingNewStuff
{
    public class Question_3_Parametised_constructor
    {
        // TODO: Discuss what is confusing about this setup

        [Test]
        public void When_the_loan_is_not_yet_due()
        {
            var loan = new BookLoan("Jill", new DateTime(2100, 12, 31));

            Assert.IsFalse(loan.IsDue());
        }

        [Test]
        public void When_the_loan_is_due()
        {
            var loan = new BookLoan("Jill", new DateTime(2000, 12, 31));

            Assert.IsTrue(loan.IsDue());
        }

        [Test]
        public void When_the_loan_is_indefinite()
        {
            var loan = new BookLoan("Jill");

            Assert.IsFalse(loan.IsDue());
        }

        internal class BookLoan : IBookLoan
        {
            public BookLoan(string memberName, DateTime dueDate)
            {
                MemberName = memberName;
                DueDate = dueDate;
            }

            public BookLoan(string memberName)
            {
                MemberName = memberName;
            }

            public string MemberName { get; private set; }
            public DateTime? DueDate { get; private set; }
        } 
    }
}