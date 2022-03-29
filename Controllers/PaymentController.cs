using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SelfCheckoutMachine.Data;
using SelfCheckoutMachine.Models;
using System.Text.Json.Nodes;

namespace SelfCheckoutMachine.Controllers
{
    [ApiController]
    [Route("/api/v1")]
    public class PaymentController : Controller
    {
        private readonly ILogger<PaymentController> _logger;
        private readonly ApplicationDbContext _db;

        public PaymentController(ILogger<PaymentController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        // Loading the machine with currencies
        [HttpPost]
        [Route("/api/v1/Stock")]
        public IEnumerable<Currency> LoadMachine(List<Currency> currencies)  // List<Currency> currencies
        {
            // !!!!! Legyen validáció (csak számok lehetnek(Value, Amount), csak létező currencyk lehetne(Value)
            // !!!!! Legyen status code hiba esetén
            // when adding currency to the machine, the database will be updated with the amout of currencies
            foreach (var currency in currencies)
            {
                Currency dbCurr = _db.Currencies.FirstOrDefault(u => u.Unit == currency.Unit);
                dbCurr.Amount += currency.Amount;
                _db.SaveChanges();
                Console.WriteLine($"curr val: {currency.Unit} | curr amount: {currency.Amount} ");
            }

            IEnumerable<Currency> currenciesFromDb = _db.Currencies;
            return currenciesFromDb;
        }

        // Currently stored items in the machine
        [HttpGet]
        [Route("/api/v1/Stock")]
        public IEnumerable<Currency> StoredItems()
        {
            IEnumerable<Currency> currenciesFromDb = _db.Currencies;
            return currenciesFromDb;
        }

        // Purchase
        [HttpPost]
        [Route("/api/v1/Checkout")]
        public IEnumerable<Currency> Checkout(Payment payment)
        {
            // calculating the change and the sum of inserted currency
            int insertedSum = 0;
            int changeSum = 0;
            foreach (var inserted in payment.Inserted)
            {
                insertedSum = insertedSum + inserted.Unit * inserted.Amount;
            }
            changeSum = insertedSum - payment.Price;
            Console.WriteLine($"inserted[0] unit: {payment.Inserted[0].Unit} | inserted[0] amount: {payment.Inserted[0].Amount} | price: {payment.Price}");
            Console.WriteLine($"inserted sum: {insertedSum}");
            Console.WriteLine($"change sum: {changeSum}");

            // when adding currency to the machine, the database will be updated with the amout of currencies
            foreach (var currency in payment.Inserted)
            {
                Currency dbCurr = _db.Currencies.FirstOrDefault(u => u.Unit == currency.Unit);
                dbCurr.Amount += currency.Amount;
                _db.SaveChanges();
                Console.WriteLine($"curr val: {currency.Unit} | curr amount: {currency.Amount} ");
            }

            // calculating the change from the currency in the register
            Console.WriteLine($"\n\nchange sum: {changeSum}");
            IEnumerable<Currency> currenciesFromDb = _db.Currencies;
            IEnumerable<Currency> changeCurrencies = Enumerable.Empty<Currency>();
            while (changeSum > 0)
            {
                int maxInRegister = 0;

                try
                {
                    maxInRegister = (from cur in currenciesFromDb
                                     where cur.Amount > 0 && cur.Unit <= changeSum
                                     orderby cur.Unit descending
                                     select cur.Unit).Max();
                    Console.WriteLine($"max in register: {maxInRegister}");

                    changeSum -= maxInRegister;
                    Console.WriteLine($"\n\nchange sum NEW: {changeSum}");
                    changeCurrencies.Append(new Currency { Unit = maxInRegister, Amount = -1, });

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR | NOT ENOUGH CURRENCY!");
                    return null;
                }

            }

            Console.WriteLine("change currencies list");
            foreach (var currency in changeCurrencies)
            {
                Console.WriteLine($"curr unit: {currency.Unit} | curr amount: {currency.Amount}");
            }

            return currenciesFromDb;
        }
    }
}
