using System;
using NUnit.Framework;

namespace CreatingNewStuff
{
    [TestFixture]
    public class Question_1_Default_constructor
    {
        // TODO: Find ways to sabotage these tests; how could you prevent them?
        [Test]
        public void When_the_loan_is_not_yet_due()
        {
            var loan = new BookLoan();
            loan.MemberName = "Jill";
            loan.DueDate = new DateTime(2100, 12, 31);

            Assert.IsFalse(loan.IsDue());
        }

        [Test]
        public void When_the_loan_is_due()
        {
            var loan = new BookLoan();
            loan.MemberName = "Jill";
            loan.DueDate = new DateTime(2000, 12, 31);

            Assert.IsTrue(loan.IsDue());
        }

        [Test]
        public void When_the_loan_is_indefinite()
        {
            var loan = new BookLoan();
            loan.MemberName = "Jill";

            Assert.IsFalse(loan.IsDue());
        }

        internal class BookLoan : IBookLoan
        {
            public string MemberName { get; set; }
            public DateTime? DueDate { get; set; }
        }
    }
}
