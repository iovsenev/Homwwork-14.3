namespace Homwwork_14._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            GetBookByPage(phoneBook
                .OrderBy(c => c.Name)
                .ThenBy(c => c.LastName));
        }

        static void GetBookByPage(IEnumerable<Contact> contacts)
        {
            while (true)
            {
                Console.WriteLine("\nВведите номер страницы!");
                int pageinput =ConsoleEnter.GetIntNumber(contacts.Count());
                var skip = (pageinput - 1) * 2;
                var take = 2;
                var page = contacts
                    .Skip(skip)
                    .Take(take);
                var i = 1;
                foreach (var contact in page)
                {
                    Console.WriteLine("i: {0}", i);
                    Console.WriteLine(contact.ToString());
                    i++;
                }
                if (ConsoleEnter.CheckExit())
                    return;
            }
        }
    }
}

