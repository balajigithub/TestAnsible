using CancerCouncilPalindrome.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CancerCouncilPalindrome.Controllers
{
    [Produces("application/json")]
    [Route("api/Palindrome")]
    public class PalindromeController : Controller
    {
        private readonly DatabaseContext _context;

        public PalindromeController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("{InputString}")]
        public string CheckPalindrome(string InputString)
        {
            {
                int min = 0;
                int max = InputString.Length - 1;
                while (true)
                {
                    if (min > max)
                    {
                        _context.AddPalindromeNames.Add(new PalindromeData { Name = InputString });
                        _context.SaveChanges();
                        return "Yes Palindrome";
                    }
                    char a = InputString[min];
                    char b = InputString[max];

                    // Scan forward for a while invalid.
                    while (!char.IsLetterOrDigit(a))
                    {
                        min++;
                        if (min > max)
                        {
                            _context.AddPalindromeNames.Add(new PalindromeData { Name = InputString });
                            _context.SaveChanges();

                            return "Yes Palindrome";
                        }
                        a = InputString[min];
                    }

                    // Scan backward for b while invalid.
                    while (!char.IsLetterOrDigit(b))
                    {
                        max--;
                        if (min > max)
                        {
                            _context.AddPalindromeNames.Add(new PalindromeData { Name = InputString });
                            _context.SaveChanges();
                            return "Yes Palindrome";
                        }
                        b = InputString[max];
                    }

                    if (char.ToLower(a) != char.ToLower(b))
                    {
                        return "Not a Palindrome";
                    }
                    min++;
                    max--;
                }
            }
        }

        [HttpGet]
        public IEnumerable<PalindromeData> GetAll()
        {
            return _context.AddPalindromeNames.ToList();
        }
    }
}