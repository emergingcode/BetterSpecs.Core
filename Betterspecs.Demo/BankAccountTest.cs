using Microsoft.VisualStudio.TestTools.UnitTesting;
using Betterspecs.Core;
using Betterspecs.Demo.Model;

namespace Betterspecs.Demo
{
    [TestClass]
    public class BankAccountTest : Spec
    {
        [TestMethod]
        public void TestMethod1()
        {
            Describe["Account bank operations"] = () =>
            {
                Context["with a account that have $100"] = () =>
                {
                    Let.Add("account_with_100", () => new BankAccount(100));

                    Context["when credited $100"] = () =>
                    {
                        Let.Get<BankAccount>("account_with_100").Credit(100);

                        It["The balance is $200"] = () => 
                            Assert.AreEqual(200, Let.Get<BankAccount>("accont_with_100").Balance);
                    };

                    Context["when debited $100"] = () =>
                    {
                        Let.Get<BankAccount>("account_with_100").Debit(100);

                        It["The balance is 100"] = () => 
                            Assert.AreEqual(100, Let.Get<BankAccount>("accont_with_100").Balance);
                    };

                };
            };
        }
    }
}
