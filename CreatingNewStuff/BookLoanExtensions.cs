using System;

namespace CreatingNewStuff
{
    public static class BookLoanExtensions
    {
        public static bool IsDue(this IBookLoan bookLoan)
        {
            return bookLoan.DueDate != null && bookLoan.DueDate <= DateTime.Today;
        }
    }
}