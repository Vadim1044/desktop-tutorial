// 10.04.25 задание 1

using System;
using System.Collections.Generic;
using System.Linq;

public struct Library
{
    public List<Book> Books { get; set; }
}

public struct Book
{
    public string Author, Title, YearOfPublication, Publisher;
    public Date LoanDates;

    public Book(string[] bookInfo)
    {
        Author=bookInfo[0];
        Title=bookInfo[1];
        YearOfPublication=bookInfo[2];
        Publisher=bookInfo[3];
        LoanDates=new Date(bookInfo[4], bookInfo[5]);
    }

    public Book(string author,string title,string yearOfPublication,string publisher,string issueDate,string returnDate)
    {
        Author=author;
        Title=title;
        YearOfPublication=yearOfPublication;
        Publisher=publisher;
        LoanDates=new Date(issueDate, returnDate);
    }

    public string GetBookInfo()
    {
        return $"{Author} {Title} {YearOfPublication} {Publisher} {LoanDates.IssueDate} {LoanDates.ReturnDate}";
    }
}

public struct Date
{
    public string IssueDate, ReturnDate;
    public Date(string issueDate, string returnDate){
        IssueDate=issueDate;
        ReturnDate = returnDate;
    }
}

internal struct Program
{
    private static void Main(string[] args){
        Library library = new Library { Books = new List<Book>() };

        while (true){
            Console.Clear();
            Console.WriteLine("1) добавить книгу");
            Console.WriteLine("2) удалить последнюю книгу");
            Console.WriteLine("3) список не выданных книг");
            Console.WriteLine("4) список не возвращенных книг");
            Console.WriteLine("5) выход");
            string userInput = Console.ReadLine();
            if (userInput == "5") break;
            switch (userInput){
                case "1":
                    Console.WriteLine("Введите данные о книге через пробел:\n" +
                                      "Автор Название Дата_публикации Издатель дата_выдачи дата_возврата");
                    string[] bookDetails = Console.ReadLine().Split(' ');
                    try
                    {
                        library.Books.Add(new Book(bookDetails));
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "2":
                    if (library.Books.Any())
                        library.Books.Remove(library.Books.Last());
                    else
                        Console.WriteLine("Нету книг для удаления");
                    break;

                case "3":
                    foreach (Book book in library.Books)
                    {
                        if (book.LoanDates.IssueDate == "-")
                            Console.WriteLine(book.GetBookInfo());
                    }
                    break;

                case "4":
                    foreach (Book book in library.Books)
                    {
                        if (book.LoanDates.ReturnDate == "-" && book.LoanDates.IssueDate != "-")
                            Console.WriteLine(book.GetBookInfo());
                    }
                    break;
            }

            Console.WriteLine("Выберите любую опцию");
            Console.ReadLine();
        }
    }
}