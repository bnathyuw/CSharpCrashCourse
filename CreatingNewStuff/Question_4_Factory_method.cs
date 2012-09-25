using System;
using NUnit.Framework;

namespace CreatingNewStuff
{
    public class Question_4_Factory_method
    {
        // TODO: Discuss whether this is always the perfect setup
        
        [Test]
        public void When_the_loan_is_not_yet_due()
        {
            var loan = BookLoan.CreateBookLoanWithDueDate("Jill", new DateTime(2100, 12, 31));

            Assert.IsFalse(loan.IsDue());
        }

        [Test]
        public void When_the_loan_is_due()
        {
            var loan = BookLoan.CreateBookLoanWithDueDate("Jill", new DateTime(2000, 12, 31));

            Assert.IsTrue(loan.IsDue());
        }

        [Test]
        public void When_the_loan_is_indefinite()
        {
            var loan = BookLoan.CreateIndefiniteBookLoan("Jill");

            Assert.IsFalse(loan.IsDue());
        }

        internal class BookLoan : IBookLoan
        {
            public static BookLoan CreateIndefiniteBookLoan(string memberName)
            {
                return new BookLoan(memberName, null);
            }

            public static BookLoan CreateBookLoanWithDueDate(string memberName, DateTime dueDate)
            {
                return new BookLoan(memberName, dueDate);
            }

            private BookLoan(string memberName, DateTime? dueDate)
            {
                MemberName = memberName;
                DueDate = dueDate;
            }

            public string MemberName { get; private set; }
            public DateTime? DueDate { get; private set; }
        }  
    }
}